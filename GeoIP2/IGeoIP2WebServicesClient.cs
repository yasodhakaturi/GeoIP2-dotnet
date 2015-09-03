﻿using MaxMind.GeoIP2.Responses;
using System.Net;

namespace MaxMind.GeoIP2
{
    /// <summary>
    ///     Interface for web-service client
    /// </summary>
    public interface IGeoIP2WebServicesClient : IGeoIP2Provider
    {
        /// <summary>
        ///     Returns an <see cref="InsightsResponse" /> for the specified ip address.
        /// </summary>
        /// <param name="ipAddress">The ip address.</param>
        /// <returns>An <see cref="InsightsResponse" /></returns>
        InsightsResponse Insights(string ipAddress);

        /// <summary>
        ///     Returns an <see cref="InsightsResponse" /> for the specified ip address.
        /// </summary>
        /// <param name="ip">The ip address.</param>
        /// <returns>An <see cref="InsightsResponse" /></returns>
        InsightsResponse Insights(IPAddress ip);
    }
}