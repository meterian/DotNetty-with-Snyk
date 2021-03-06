// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DotNetty.Codecs.Http
{
    public interface IHttpResponse : IHttpMessage
    {
        HttpResponseStatus Status { get; }

        IHttpResponse SetStatus(HttpResponseStatus status);
    }
}
