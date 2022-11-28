using Microsoft.AspNetCore.Mvc.Filters;

namespace MusicApi.Filter
{

    //[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]
    //public class GSWFilterAttribute<TFilter> : Attribute, IFilterFactory, IOrderedFilter where TFilter : IAsyncActionFilter
    //{
    //    public bool IsReusable { get; set; }

    //    public int Order { get; set; }

    //    public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
    //    {
    //        if (serviceProvider != null)
    //        {
    //            var filter = (IFilterMetadata)serviceProvider.GetRequiredService(typeof(TFilter));
    //            if (filter is IFilterFactory filterFactory)
    //            {
    //                filter = filterFactory.CreateInstance(serviceProvider);
    //            }
    //            return filter;
    //        }
    //        else
    //        {
    //            throw new ArgumentNullException(nameof(serviceProvider));
    //        }
    //    }
    //}
}
