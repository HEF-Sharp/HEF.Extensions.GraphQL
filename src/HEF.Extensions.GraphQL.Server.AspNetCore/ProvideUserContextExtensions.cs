using GraphQL.Execution;
using Microsoft.AspNetCore.Http;
using System;

namespace GraphQL.Server.Transports.AspNetCore
{
    public static class ProvideUserContextExtensions
    {
        public static HttpContext GetHttpContext(this IProvideUserContext provideContext)
        {
            if (provideContext == null)
                throw new ArgumentNullException(nameof(provideContext));

            if (provideContext.UserContext is HttpContextUserContext httpUserContext)
                return httpUserContext.Context;

            throw new ArgumentException($"can't resolve HttpContext from target UserContext");
        }
    }
}
