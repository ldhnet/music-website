namespace MusicApi.Code
{
    public class RefreshTokenService : BackgroundService, IDisposable
    {
        private readonly ITokenManager tokenManager;

        public RefreshTokenService(ITokenManager tokenManager)
        {
            this.tokenManager = tokenManager;
        }

        protected async override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            tokenManager.Token = await GetToken();

            //1 分钟刷新一次
            var timer = new PeriodicTimer(TimeSpan.FromMinutes(1));

            while (await timer.WaitForNextTickAsync(stoppingToken))
            {
                tokenManager.Token = await GetToken();
            }
        }

        private async Task<string> GetToken()
        {
            //调用第三方服务获取Token

            var result = Task.Run(() => {
                Console.WriteLine("Token 已经刷新");
                Console.WriteLine($"刷新Token func 线程Id === {Thread.CurrentThread.ManagedThreadId}");
                
            }); 

            return await Task.FromResult(Guid.NewGuid().ToString()); 
        }
    }
}
