using Framework.Cache;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace MusicApi.Attributes
{
    /// <summary>
    /// 拦截器 实现指定时间访问次数
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class PreventDoublePostAttribute : ActionFilterAttribute
    {
        private const string UniqFormuId = "LastProcessedToken";
        public override async void OnActionExecuting(ActionExecutingContext context)
        { 
            string _kay= UniqFormuId +"-"+ Dns.GetHostName();
            var requestToken = CacheFactory.Cache.GetCache<string>(_kay);

            if (!string.IsNullOrEmpty(requestToken))
            {
               //context.ModelState.AddModelError(string.Empty, "Looks like you accidentally submitted the same form twice.");
                //context.HttpContext.Response.StatusCode= StatusCodes.Status423Locked;
                await context.HttpContext.Response.WriteAsJsonAsync(new {code= StatusCodes.Status423Locked });
                context.Result = new EmptyResult();//终止后面的action执行
            }
            else
            {
                requestToken = Guid.NewGuid().ToString();
                CacheFactory.Cache.SetCache(_kay, requestToken, DateTime.Now.AddSeconds(30));
            } 
        }

    }

}
