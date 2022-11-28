using Framework.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace NUnitTest
{
    [TestFixture]
    public class Tests
    {
        private IBannerRepository _bannerRepository;
        private IUnitOfWork _unitOfWork;
        [SetUp]
        public void Setup()
        {
            MyDBContext conn = new MyDBContext();
            _unitOfWork = new UnitOfWork(conn);
            _bannerRepository = new BannerRepository(_unitOfWork);
        }
 

        [Test]
        public void Test1()
        {
            MyDBContext conn = new MyDBContext();

            var list2 = conn.Set<Biz_Banner>().AsNoTracking().ToList();
            var list =  _bannerRepository.EntitiesAsNoTracking.ToList();
            Assert.Pass();
        }
    }
}