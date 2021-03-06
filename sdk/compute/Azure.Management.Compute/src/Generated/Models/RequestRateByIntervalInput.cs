// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Management.Compute.Models
{
    /// <summary> Api request input for LogAnalytics getRequestRateByInterval Api. </summary>
    public partial class RequestRateByIntervalInput : LogAnalyticsInputBase
    {
        /// <summary> Initializes a new instance of RequestRateByIntervalInput. </summary>
        /// <param name="blobContainerSasUri"> SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to. </param>
        /// <param name="fromTime"> From time of the query. </param>
        /// <param name="toTime"> To time of the query. </param>
        /// <param name="intervalLength"> Interval value in minutes used to create LogAnalytics call rate logs. </param>
        public RequestRateByIntervalInput(string blobContainerSasUri, DateTimeOffset fromTime, DateTimeOffset toTime, IntervalInMins intervalLength) : base(blobContainerSasUri, fromTime, toTime)
        {
            if (blobContainerSasUri == null)
            {
                throw new ArgumentNullException(nameof(blobContainerSasUri));
            }

            IntervalLength = intervalLength;
        }

        /// <summary> Initializes a new instance of RequestRateByIntervalInput. </summary>
        /// <param name="blobContainerSasUri"> SAS Uri of the logging blob container to which LogAnalytics Api writes output logs to. </param>
        /// <param name="fromTime"> From time of the query. </param>
        /// <param name="toTime"> To time of the query. </param>
        /// <param name="groupByThrottlePolicy"> Group query result by Throttle Policy applied. </param>
        /// <param name="groupByOperationName"> Group query result by Operation Name. </param>
        /// <param name="groupByResourceName"> Group query result by Resource Name. </param>
        /// <param name="intervalLength"> Interval value in minutes used to create LogAnalytics call rate logs. </param>
        internal RequestRateByIntervalInput(string blobContainerSasUri, DateTimeOffset fromTime, DateTimeOffset toTime, bool? groupByThrottlePolicy, bool? groupByOperationName, bool? groupByResourceName, IntervalInMins intervalLength) : base(blobContainerSasUri, fromTime, toTime, groupByThrottlePolicy, groupByOperationName, groupByResourceName)
        {
            IntervalLength = intervalLength;
        }

        /// <summary> Interval value in minutes used to create LogAnalytics call rate logs. </summary>
        public IntervalInMins IntervalLength { get; }
    }
}
