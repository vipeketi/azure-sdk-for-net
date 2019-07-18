﻿using System;
using System.Globalization;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Azure.Messaging.EventHubs.Errors;

namespace Azure.Messaging.EventHubs.Core
{
    /// <summary>
    ///   The default retry policy for the Event Hubs client library, respecting the
    ///   configuration specified as a set of <see cref="RetryOptions" />.
    /// </summary>
    ///
    /// <seealso cref="RetryOptions"/>
    ///
    internal class BasicRetryPolicy : EventHubRetryPolicy
    {
        /// <summary>The seed to use for initializing random number generated for a given thread-specific instance.</summary>
        private static int s_randomSeed = Environment.TickCount;

        /// <summary>The random number generator to use for a specific thread.</summary>
        private static readonly ThreadLocal<Random> s_random = new ThreadLocal<Random>(() => new Random(Interlocked.Increment(ref s_randomSeed)), false);

        /// <summary>
        ///   The set of options responsible for configuring the retry
        ///   behavior.
        /// </summary>
        ///
        public RetryOptions Options { get; }

        /// <summary>
        ///   The factor to apply to the base delay for use as a base jitter value.
        /// </summary>
        ///
        /// <value>This factor is used as the basis for random jitter to apply to the calculated retry duration.</value>
        ///
        public double JitterFactor { get; } = 0.08;

        /// <summary>
        ///   Initializes a new instance of the <see cref="BasicRetryPolicy"/> class.
        /// </summary>
        ///
        /// <param name="retryOptions">The options which control the retry approach.</param>
        ///
        public BasicRetryPolicy(RetryOptions retryOptions)
        {
            Guard.ArgumentNotNull(nameof(retryOptions), retryOptions);
            Options = retryOptions;
        }

        /// <summary>
        ///   Calculates the amount of time to allow the curent attempt for an operation to
        ///   complete before considering it to be timed out.
        /// </summary>
        ///
        /// <param name="attemptCount">The number of total attempts that have been made, including the initial attempt before any retries.</param>
        ///
        /// <returns>The amount of time to allow for an operation to complete.</returns>
        ///
        public override TimeSpan CalculateTryTimeout(int attemptCount) => Options.TryTimeout;

        /// <summary>
        ///   Calculates the amount of time to wait before another attempt should be made.
        /// </summary>
        ///
        /// <param name="lastException">The last exception that was observed for the operation to be retried.</param>
        /// <param name="attemptCount">The number of total attempts that have been made, including the initial attempt before any retries.</param>
        ///
        /// <returns>The amount of time to delay before retrying the associated operation; if <c>null</c>, then the operation is no longer eligible to be retried.</returns>
        ///
        public override TimeSpan? CalculateRetryDelay(Exception lastException,
                                                      int attemptCount)
        {
            if ((Options.MaximumRetries <= 0)
                || (Options.Delay == TimeSpan.Zero)
                || (Options.MaximumDelay == TimeSpan.Zero)
                || (attemptCount > Options.MaximumRetries)
                || (!ShouldRetryException(lastException)))
            {
                return null;
            }

            var baseJitterSeconds = (Options.Delay.TotalSeconds * JitterFactor);
            TimeSpan retryDelay;

            switch (Options.Mode)
            {
                case RetryMode.Fixed:
                    retryDelay = CalculateFixedDelay(Options.Delay.TotalSeconds, baseJitterSeconds, s_random.Value);
                    break;

                case RetryMode.Exponential:
                    retryDelay = CalculateExponentiayDelay(attemptCount, Options.Delay.TotalSeconds, baseJitterSeconds, s_random.Value);
                    break;

                default:
                    throw new NotSupportedException(String.Format(CultureInfo.CurrentCulture, Resources.UnknownRetryMode, Options.Mode.ToString()));
            }

            // Adjust the delay, if needed, to keep within the maximum
            // duration.

            if (Options.MaximumDelay < retryDelay)
            {
                return Options.MaximumDelay;
            }

            return retryDelay;
        }

        /// <summary>
        ///   Determines if an exception should be retried.
        /// </summary>
        ///
        /// <param name="exception">The exception to consider.</param>
        ///
        /// <returns><c>true</c> to retry the exception; otherwise, <c>false</c>.</returns>
        ///
        private static bool ShouldRetryException(Exception exception)
        {
            if (exception is TaskCanceledException)
            {
                exception = exception?.InnerException;
            }
            else if (exception is AggregateException aggregateEx)
            {
                exception = aggregateEx?.Flatten().InnerException;
            }

            switch (exception)
            {
                case null:
                    return false;

                case EventHubsException ex:
                    return ex.IsTransient;

                case TimeoutException _:
                case OperationCanceledException _:
                case SocketException _:
                    return true;

                default:
                    return false;
            }
        }

        /// <summary>
        ///   Calculates the delay for an exponential backoff.
        /// </summary>
        ///
        /// <param name="attemptCount">The number of total attempts that have been made, including the initial attempt before any retries.</param>
        /// <param name="baseDelaySeconds">The delay to use as a basis for the exponential backoff, in seconds.</param>
        /// <param name="baseJitterSeconds">The delay to use as the basis for a random jitter value, in seconds.</param>
        /// <param name="random">The random number generator to use for the calculation.</param>
        ///
        /// <returns>The recommended duration to delay before retrying; this value does not take the maximum delay or eligibility for retry into account.</returns>
        ///
        private static TimeSpan CalculateExponentiayDelay(int attemptCount,
                                                          double baseDelaySeconds,
                                                          double baseJitterSeconds,
                                                          Random random) =>
            TimeSpan.FromSeconds((Math.Pow(2, attemptCount) * baseDelaySeconds) + (random.NextDouble() * baseJitterSeconds));

        /// <summary>
        ///   Calculates the delay for a fixed backoff.
        /// </summary>
        ///
        /// <param name="baseDelaySeconds">The delay to use as a basis for the fixed backoff, in seconds.</param>
        /// <param name="baseJitterSeconds">The delay to use as the basis for a random jitter value, in seconds.</param>
        /// <param name="random">The random number generator to use for the calculation.</param>
        ///
        /// <returns>The recommended duration to delay before retrying; this value does not take the maximum delay or eligibility for retry into account.</returns>
        ///
        private static TimeSpan CalculateFixedDelay(double baseDelaySeconds,
                                                    double baseJitterSeconds,
                                                    Random random) =>
            TimeSpan.FromSeconds(baseDelaySeconds + (random.NextDouble() * baseJitterSeconds));
    }
}