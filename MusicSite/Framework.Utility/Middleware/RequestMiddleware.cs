//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Framework.Utility.Middleware
//{
//    public class RequestMiddleware
//    {
//        private readonly RequestDelegate _next;

//        public RequestMiddleware(RequestDelegate next)
//        {
//            this._next = next;
//        }

//        public Task Invoke(HttpContext context)
//        {
//            context.Request.EnableRewind(); //支持context.Request.Body重复读取，内部调用了EnableBuffering方法，否则在使用部分方法或属性时会报错误System.NotSupportedException: Specified method is not supported，例如context.Request.Body.Position
//            if (context.Request.ContentLength == null)
//            {
//                return this._next(context);
//            }

//            string sessionPhone = context.Session.GetString("phone");
//            if (string.IsNullOrEmpty(sessionPhone))
//            {
//                context.Session.SetString("phone", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
//            }
//            return this._next(context);
//        }
//    }
//}
