using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace MusicApi.Middleware
{ 
    public class SwaggerEndpointsFilterMiddleware
    {
        private readonly RequestDelegate _next;

        public SwaggerEndpointsFilterMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path.Value != null && httpContext.Request.Path.HasValue &&  httpContext.Request.Path.Value.Contains("swagger.json", StringComparison.InvariantCultureIgnoreCase))
            {
                var originalStream = httpContext.Response.Body;
                using (var memoryStream = new MemoryStream())
                {
                    //截获原始响应，将响应内容写入 MemoryStream
                    httpContext.Response.Body = memoryStream;

                    await _next(httpContext);

                    //获取当前用户可访问的 Endpoints
                    var validEndpoints = GetValidEndpoints(httpContext.Request);

                    memoryStream.Position = 0;
                    using (var sr = new StreamReader(memoryStream))
                    {
                        //将修改过的 json 写入响应 
                        await originalStream.WriteAsync(CreateSwaggerJson(sr.ReadToEnd(), validEndpoints));
                    }

                    httpContext.Response.Body = originalStream;
                    return;
                }
            }

            await _next(httpContext);
        }
        private IEnumerable<string> GetValidEndpoints(HttpRequest request)
        { 
            var list = new List<string>();
            list.Add("/api/Account");
            list.Add("/api/Account/swgLogin");
            list.Add("/api/Captcha/Captcha");
            list.Add("/api/Captcha/Validate");
            list.Add("/api/Demo/GetEmployeeList");
            list.Add("/api/Demo/GetEmployeeList2");
            list.Add("/api/Demo/Get");
            list.Add("/api/Demo/PostTest");
            list.Add("/api/Demo/AddEmployee");
            list.Add("/api/Demo/CreateEmployee");
            list.Add("/api/Demo/AddTest");
            list.Add("/api/Test/GetGithubHome");
            list.Add("/api/Test/GetGithubTest");
            list.Add("/api/Test/GetDemo");
            list.Add("/api/Test/GetToken");
            list.Add("/api/Test/Get");
            list.Add("/api/Test/PostTest/PostTest");
            list.Add("/api/Warm/Get");
            list.Add("/api/Warm/ParamterCheckIng"); 
            return list;
        }
        private byte[] CreateSwaggerJson(string json, IEnumerable<string> validEndpoints)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var utf8JsonWriter = new Utf8JsonWriter(memoryStream))
                {
                    using (var jsonDocument = JsonDocument.Parse(json))
                    {
                        utf8JsonWriter.WriteStartObject();

                        foreach (var element in jsonDocument.RootElement.EnumerateObject())
                        {
                            if (element.Name == "paths")
                            {
                                utf8JsonWriter.WritePropertyName(element.Name);
                                utf8JsonWriter.WriteStartObject();

                                //遍历 paths 子节点，检查 Endpoint 是否已授权
                                foreach (var endpoint in element.Value.EnumerateObject())
                                {
                                    if (validEndpoints.Contains(endpoint.Name))
                                    {
                                        endpoint.WriteTo(utf8JsonWriter);
                                    }
                                }

                                utf8JsonWriter.WriteEndObject();
                            }
                            else
                            {
                                element.WriteTo(utf8JsonWriter);
                            }
                        }

                        utf8JsonWriter.WriteEndObject();
                    }
                }

                return memoryStream.ToArray();
            }
        }
    }
}
