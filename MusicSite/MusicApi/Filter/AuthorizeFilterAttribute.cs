using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using Framework.Admin.Code;

namespace MusicApi.Filter
{
    /// <summary>
    /// 验证token和记录日志
    /// </summary>
    public class AuthorizeFilterAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// 忽略token的方法
        /// </summary>
        public static readonly string[] IgnoreToken = { "GetWxOpenId", "Login", "LoginOff" };

        /// <summary>
        /// 异步接口日志
        /// </summary>
        /// <param name="context"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            string token = context.HttpContext.Request.Headers["ApiToken"].ParseToString();
            OperatorInfo user = await Operator.Instance.Current(token);
            if (user != null)
            {
                // 根据传入的Token，设置CustomerId
                if (context.ActionArguments != null && context.ActionArguments.Count > 0)
                {
                    PropertyInfo property = context.ActionArguments.FirstOrDefault().Value.GetType().GetProperty("Token");
                    if (property != null)
                    {
                        property.SetValue(context.ActionArguments.FirstOrDefault().Value, token, null);
                    }
                    switch (context.HttpContext.Request.Method.ToUpper())
                    {
                        case "GET":
                            break;

                        case "POST":
                            property = context.ActionArguments.FirstOrDefault().Value.GetType().GetProperty("CustomerId");
                            if (property != null)
                            {
                                property.SetValue(context.ActionArguments.FirstOrDefault().Value, user.UserId, null);
                            }
                            break;
                    }
                }
            }
            await next();

            sw.Stop(); 
        }
    }
}
