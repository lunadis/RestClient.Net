﻿using System;

namespace RestClient.Net.Abstractions
{
    public class Trace
    {
        public HttpRequestMethod HttpRequestMethod { get; }
        public Uri RequestUri { get; }
        public byte[] BodyData { get; }
        public TraceEvent RestEvent { get; }
        public int? HttpStatusCode { get; }
        public IHeadersCollection HeadersCollection { get; }

        public Trace(
            HttpRequestMethod httpRequestMethod,
            Uri requestUri,
            byte[] bodyData,
            TraceEvent traceType,
            int? httpStatusCode,
            IHeadersCollection headersCollection)
        {
            HttpRequestMethod = httpRequestMethod;
            RequestUri = requestUri;
            BodyData = bodyData;
            RestEvent = traceType;
            HttpStatusCode = httpStatusCode;
            HeadersCollection = headersCollection;
        }
    }
}