using Framework.Models.Entities;
using Framework.Utility.ViewModels; 
namespace Framework.Admin.Contracts
{
    public interface IBannerContract
    {
        TData<List<Biz_Banner>> GetAllBanner();
    }
}
