﻿using Microsoft.AspNetCore.Http;
using System;

namespace JadeFramework.Core.Mvc.Extensions
{
    /// <summary>
    /// HttpRequest扩展
    /// </summary>
    public static class HttpRequestExtensions
    {
        /// <summary>
        /// 是否是AJAX请求
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }
            return request.Headers != null &&
                   request.Headers["X-Requested-With"] == "XMLHttpRequest";
        }
    }
}
