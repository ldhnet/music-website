using Framework.Utility.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Helper
{
    public class HttpClientHelper
    {

       // public IRepository<Sys_SynchronizationNo, int> SynchronizationNoRepository { protected get; set; }

        private readonly string WEBAPI = ""; //ConfigurationManager.AppSettings["SynchronizationServer"] + "/api/{0}?timestamp={1}&{2}";

        private readonly string TOKEN = "Bearer ";//+ ConfigurationManager.AppSettings["HRMSAcessToken"];

        private const string ORG_CONTROLLER = "getorganizationlist"; 

        private void SynchronizationRESTask(DateTime date)
        {
            #region 同步部门

            long timestamp = 0;
            //var no = 1;//SynchronizationNoRepository.FindExists(p => p.Key == "organizationlist");
            //if (no != null)
            //    timestamp = no;

            var url = string.Format(WEBAPI, ORG_CONTROLLER, timestamp, "");
            var res = GetDataFromApi(url);

            var count = JsonHelper.FromJson<int>(res);

            var pageString = string.Format("pageindex={0}&pagesize={1}", 1, 3000);

            if (count > 0)
            {
                url = string.Format(WEBAPI, ORG_CONTROLLER, timestamp, pageString);

                res = GetDataFromApi(url);

                var query = JsonHelper.FromJson<List<ApiOrganizationDto>>(res);

                if (query.Any())
                {

                    //UnitOfWork.TransactionEnabled = true;

                    query.OrderBy(p => p.TreePath).ToList().ForEach(o =>
                    {
                        var entity = new ApiOrganizationDto(); //OrganizationRepository.FindExists(p => p.Id == o.Id);
                        if (entity == null)
                        {
                            //var newentity = Mapper.Map<Biz_Organization>(o);
                            //OrganizationRepository.Insert(newentity);
                        }
                        else
                        {
                            entity.Name = o.Name;
                            entity.Remark = o.Remark;
                            entity.ParentId = o.ParentId;
                            entity.SortCode = o.SortCode;
                            entity.TreePath = o.TreePath;
                            entity.IsDeleted = o.IsDeleted;
                            //OrganizationRepository.Update(entity);
                        }

                    });

                    //if (no != null)
                    //{
                    //    no.Value = query.Max(p => p.Timestamp);
                    //    SynchronizationNoRepository.Update(no);
                    //}
                    //else
                    //{
                    //    SynchronizationNoRepository.Insert(new Sys_SynchronizationNo { Key = "organizationlist", Value = query.Max(p => p.Timestamp), CreateBy = "system" });
                    //}

                    //UnitOfWork.SaveChanges();
                }
            }


            #endregion
             
        }

        public class ApiOrganizationDto
        {
            /// <summary>
            /// 获取或设置 主键，唯一标识
            /// </summary>
            public int Id { get; set; }

            public string Name { get; set; }

            public string TreePath { get; set; }

            public string Remark { get; set; }

            public int SortCode { get; set; }

            public int? ParentId { get; set; }

            [NotMapped]
            public long Timestamp { get; set; }

            public bool IsDeleted { get; set; }

        }
         
        private string GetDataFromApi(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Credentials = CredentialCache.DefaultCredentials;

            request.ProtocolVersion = HttpVersion.Version11;

            //request.UserAgent = DefaultUserAgent;

            //equest.KeepAlive = true;

            request.Headers.Add("Authorization", TOKEN);

            request.Method = "GET";

            request.Accept = "application/json";

            //request.Headers.Add("Accept-Language", LANGUAGE);

            //request.Headers.Add("Accept-Topic", LM);

            //request.Proxy = wproxy;

            //request.ContentType = CODEC;

            //request.SendChunked = true;

            //request.ContentLength = voice.Length;

            //ServicePointManager.ServerCertificateValidationCallback = ((sender, certificate, chain, sslPolicyErrors) => true);

            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;

            var result = string.Empty;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader readStream = new StreamReader(responseStream, Encoding.UTF8))
                    {
                        result = readStream.ReadToEnd();
                    }
                }
            }

            return result;

        }
        /// <summary>
        /// HttpClient 常用配置
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private async Task<string> HttpClient_config(string url)
        {
            //var socketsHttpHandler = new SocketsHttpHandler()
            //{
            //    UseCookies = false,// 是否自动处理cookie
            //};
            //var client = new HttpClient(socketsHttpHandler);


            //var socketsHttpHandler = new SocketsHttpHandler()
            //{
            //    AllowAutoRedirect = true,//是否自动重定向
            //    MaxAutomaticRedirections = 50//自动重定向的最大次数
            //};
            //var client = new HttpClient(socketsHttpHandler);

            //var socketsHttpHandler = new SocketsHttpHandler()
            //{
            //    //每个请求连接的最大数量，默认是int.MaxValue,可以认为是不限制
            //    MaxConnectionsPerServer = 100,
            //    //连接池中TCP连接最多可以闲置多久,默认2分钟
            //    PooledConnectionIdleTimeout = TimeSpan.FromMinutes(2),
            //    //连接最长的存活时间,默认是不限制的,一般不用设置
            //    PooledConnectionLifetime = Timeout.InfiniteTimeSpan,
            //};
            //var client = new HttpClient(socketsHttpHandler);


            //var socketsHttpHandler = new SocketsHttpHandler()
            //{
            //    //建立TCP连接时的超时时间,默认不限制
            //    ConnectTimeout = Timeout.InfiniteTimeSpan,
            //    //等待服务返回statusCode=100的超时时间,默认1秒
            //    Expect100ContinueTimeout = TimeSpan.FromSeconds(1),
            //};
            //var client = new HttpClient(socketsHttpHandler);
            ////等待响应超时时间，默认：100秒。
            //client.Timeout = TimeSpan.FromSeconds(100);


            //var client = new HttpClient();
            //client.DefaultRequestVersion = HttpVersion.Version20;
            //client.DefaultRequestHeaders.Add("machine-id", "1");


            var httpClient =new HttpClient();

            httpClient.DefaultRequestHeaders.Add("Authorization", TOKEN);

            var response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();//如果不返回200就报异常
            var statusCode = response.StatusCode;
            var header = response.Headers;
            var result = await response.Content.ReadAsStringAsync(); 
            return result;
        }

        /// <summary>
        /// HttpClient 下载
        /// </summary>
        /// <returns></returns>
        private async Task HttpClient_Download()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync("http://localhost:9000/middledata.mp4");//763M
            var fileStream = new FileStream("e:\\middle.db", FileMode.OpenOrCreate, FileAccess.Write);
            await response.Content.CopyToAsync(fileStream);
            fileStream.Close(); 
        }

        /// <summary>
        /// HttpClient 大文件下载
        /// </summary>
        /// <returns></returns>
        private async Task HttpClient_Download_BigFile()
        {
            var httpClient = new HttpClient();

           // httpClient.MaxResponseContentBufferSize = 2L << 32; //调成4GB，发现报错

            var url = "http://localhost:9000/bigdata.mp4";
            var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);
            var totalLength = response.Content.Headers.ContentLength;
            var contentStream = await response.Content.ReadAsStreamAsync();
            var fileStream = new FileStream("e:\\bigdata.db", FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer = new byte[5 * 1024];//5KB缓存
            long readLength = 0L;
            int length;
            while ((length = await contentStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                readLength += length;
                if (totalLength > 0)
                {
                    Console.WriteLine("下载进度: " + Math.Round((double)readLength / totalLength.Value * 100, 2) + "%");
                }
                else
                {
                    Console.WriteLine("已下载: " + Math.Round((readLength / 1024.0), 2) + "KB");
                }
                fileStream.Write(buffer, 0, length);
            }
            fileStream.Close(); 
        }


        /// <summary>
        /// HttpClient post 数据
        /// </summary>
        /// <returns></returns>
        private async Task HttpClient_post()
        {
            var httpClient = new HttpClient();
            var url = "http://192.168.0.9:9000/Demo/PostUrlCode";
            var response = await httpClient.PostAsync(url, new FormUrlEncodedContent(new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("name","小明"),
                new KeyValuePair<string, string>("age","20")
            }));
            var str = await response.Content.ReadAsStringAsync();


            ////注意：asp.net core webapi和mvc模式解析参数的时候存在差别，这里是asp.net core webapi
            //[HttpPost]
            //public string PostUrlCode([FromForm] string name, [FromForm] int age)
            //{
            //    var str = "";
            //    foreach (var header in Request.Headers)
            //    {
            //        str += $"{header.Key}: {header.Value.ToString()}\r\n";
            //    }
            //    return $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {name} {age} \r\n{str}";
            //}
             
        }


        private async Task HttpClient_post_model()
        {
            var httpClient = new HttpClient();
            var url = "http://192.168.0.9:9000/Demo/PostUrlJson";

            var response = await httpClient.PostAsync(
                url,
                new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(new { Name = "小明", Id = 1 }), Encoding.UTF8, "application/json"));
            var str = await response.Content.ReadAsStringAsync();


            //[HttpPost]
            //public string PostUrlJson([FromBody] RequestModel req)
            //{
            //    var str = "";
            //    foreach (var header in Request.Headers)
            //    {
            //        str += $"{header.Key}: {header.Value.ToString()}\r\n";
            //    }
            //    return $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {req.Name} {req.Id} \r\n{str}";
            //}

            //public class RequestModel
            //        {
            //            public int Id { get; set; }
            //            public string Name { get; set; }
            //        } 
        }

        /// <summary>
        /// HttpClient post 文件
        /// </summary>
        /// <returns></returns>
        private async Task HttpClient_post_multipart()
        {

            var httpClient = new HttpClient();
            var url = "http://localhost:9000/Demo/PostMulti";
            var content = new MultipartFormDataContent();
            content.Add(new StringContent("小明"), "name");
            content.Add(new StringContent("18"), "age");
            //注意：要指定filename，即：test.txt，否则后台不认为是一个文件，而是普通的参数
            content.Add(new ByteArrayContent(System.IO.File.ReadAllBytes("e:\\test.txt")), "file", "test.txt");
            var response = await httpClient.PostAsync(url, content);
            var str = await response.Content.ReadAsStringAsync();


            //[HttpPost]
            //public string PostMulti([FromForm] string name, [FromForm] int age)
            //{
            //    var str = "";
            //    foreach (var header in Request.Headers)
            //    {
            //        str += $"{header.Key}: {header.Value.ToString()}\r\n";
            //    }
            //    if (Request.Form.Files.Count > 0)
            //    {
            //        var file = Request.Form.Files[0];
            //        var fileName = file.FileName;
            //        var fileLength = file.Length;
            //        using var stream = file.OpenReadStream();
            //        var bytearr = new byte[fileLength];
            //        stream.ReadAsync(bytearr);
            //        var fileContent = Encoding.UTF8.GetString(bytearr);
            //        str += "\r\n" + fileContent;
            //    }
            //    return $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {name} {age} \r\n{str}";
            //}

        }
    }
} 