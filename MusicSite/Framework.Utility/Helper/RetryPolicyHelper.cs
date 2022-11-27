namespace Framework.Utility.Helper
{
    public static class RetryPolicyHelper
    {
        static int sleepMillisecondsTimeout = 100;
        /// <summary>
        /// 若发生 Exception (资料库查询过时)，重复执行相同操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handler"></param>
        /// <param name="retryTimes">预设值 3次，传入 0直接 return default(T)</param>
        /// <returns></returns>
        public static T Retry<T>(Func<T> handler, int retryTimes = 3)
        {
            if (retryTimes <= 0)
            {
                return default(T);
            }

            try
            {
                return handler();
            }
            catch (Exception e)
            {
                retryTimes--;
                //logger.Error($"剩余次数: {retryTimes}, retry error: {e.Message}, Exception detail: {e.Message}");
                Thread.Sleep(sleepMillisecondsTimeout);
                return Retry(handler, retryTimes);
            }
        }

        /// <summary>
        /// 传入多个动作，遇到 Exception依序执行 (资料库查詢过时，改用不同条件查询)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="handlers"></param>
        /// <returns></returns>
        public static T Retry<T>(params Func<T>[] handlers)
        {
            for (int i = 0; i < handlers.Length; i++)
            {
                var handler = handlers[i];
                try
                {
                    return handler();
                }
                catch (Exception e)
                {
                    //logger.Error($"第 {i}次执行错误(start from 0): retry error: {e.Message}, Exception detail: {e.Message}");
                    System.Threading.Thread.Sleep(sleepMillisecondsTimeout);
                }
            }
            return default(T);
        }

        /// <summary>
        ///  若发生 Exception (资料库查询过时)，重复执行相同操作
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="retryTimes">预设重试 3次，传入 0直接 return</param>
        public static void Retry(Action handler, int retryTimes = 3)
        {
            if (retryTimes <= 0)
            {
                return;
            }

            try
            {
                handler();
            }
            catch (Exception e)
            {
                retryTimes--;
                //logger.Error($"剩余重试次数: {retryTimes}, retry error: {e.Message}, Exception detail: {e.Message}");
                System.Threading.Thread.Sleep(sleepMillisecondsTimeout);
                Retry(handler, retryTimes);
            }
        }

    }
}
