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
            MyDBContext conn= new MyDBContext();
            _unitOfWork = new UnitOfWork(conn);
            _bannerRepository = new BannerRepository(_unitOfWork); 
        }
 

        [Test]
        public void Test1()
        { 
            var list = _bannerRepository.EntitiesAsNoTracking.ToList();
            Assert.Pass();
        }
    }
}