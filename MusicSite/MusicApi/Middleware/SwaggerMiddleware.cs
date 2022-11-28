﻿using System.Net;

namespace MusicApi.Middleware
{
    public class SwaggerAuthMiddleware
    {

        private readonly RequestDelegate next;

        public SwaggerAuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            // 也可以根据是否是本地做判断 IsLocalRequest
            if (context.Request.Path.Value!.ToLower().Contains("index.html"))
            {
                // 判断权限是否正确
                if (IsAuthorized(context))
                {
                    await next.Invoke(context);
                    return;
                }

                // 无权限，跳转swagger登录页
                context.Response.Redirect("/swg-login.html");
            }
            else
            {
                await next.Invoke(context);
            }
        }

        public bool IsAuthorized(HttpContext context)
        {
            // 使用session模式
            // 可以使用其他的
            return context.Session.GetString("swagger-code") == "success";
        }

        /// <summary>
        /// 判断是不是本地访问
        /// 本地不用swagger拦截
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public bool IsLocalRequest(HttpContext context)
        {
            if (context.Connection.RemoteIpAddress == null && context.Connection.LocalIpAddress == null)
            {
                return true;
            }
            if (context.Connection.RemoteIpAddress!.Equals(context.Connection.LocalIpAddress))
            {
                return true;
            }
            if (IPAddress.IsLoopback(context.Connection.RemoteIpAddress))
            {
                return true;
            }
            return false;
        }
    }
    // 定义扩展
    public static class SwaggerAuthorizeExtensions
    {
        public static IApplicationBuilder UseSwaggerAuthorized(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SwaggerAuthMiddleware>();
        }
    }
}
