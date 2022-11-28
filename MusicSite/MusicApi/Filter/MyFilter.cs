using Microsoft.AspNetCore.Mvc.Filters;

namespace MusicApi.Filter
{
    public class MyFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            Console.WriteLine("Action前执行");
            await next();
            Console.WriteLine("Action后执行");
        }
    }
}
