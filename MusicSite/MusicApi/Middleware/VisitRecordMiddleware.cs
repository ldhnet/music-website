using Framework.Models.Entities;
using Framework.Admin.Contracts;

namespace MusicApi.Middleware
{
    public class VisitRecordMiddleware
    {
        private readonly RequestDelegate _next;

        public VisitRecordMiddleware(RequestDelegate requestDelegate)
        {
            _next = requestDelegate;
        }

        public Task Invoke(HttpContext context, IVisitRecordContract visitRecordContract)
        {
            var request = context.Request;
            var response = context.Response;

            visitRecordContract.SaveEntity(new VisitRecord
            {
                Ip = request.Host.Value,
                RequestPath = request.Path,
                RequestQueryString = request.QueryString.Value,
                RequestMethod = request.Method,
                UserAgent = request.Headers.UserAgent,
                CreateTime = DateTime.Now
            });

            return _next(context);
        }
    }
}
