﻿using System;
using System.Net;
using System.Net.Http.Headers;

namespace Docker.Registry.DotNet
{
    public class RegistryApiException : Exception
    {
        internal RegistryApiException(RegistryApiResponse response)
            : base($"Docker API responded with status code={response.StatusCode}")
        {
            StatusCode = response.StatusCode;
            Headers = response.Headers;
        }

        public HttpStatusCode StatusCode { get; }

        public HttpResponseHeaders Headers { get; }
    }
}