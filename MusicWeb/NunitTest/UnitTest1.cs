using HSharp.Contracts.MusicContracts;
using HSharp.Services.MusicServices;

namespace NunitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task Test1()
        {
           IConsumerContract _consumerContract = new ConsumerService();
            var result =await _consumerContract.AllUser();
          
        }
    }
}