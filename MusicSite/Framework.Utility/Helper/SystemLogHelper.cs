using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Utility.Helper
{
    public  class SystemLogHelper
    {
        public static void Writelog(string logContent)
        {
            StreamWriter stream;
            //写入日志内容
            string path = AppDomain.CurrentDomain.BaseDirectory + "//logs";
            //检查物理路径是否存在，不存在则创建路径
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            stream = new StreamWriter(path + $"\\log{DateTime.Now.ToString("yyyyMMdd")}.txt", true, Encoding.Default);
            stream.Write(DateTime.Now.ToString() + ":" + logContent);
            stream.Write("\r\n");//追加写入
            stream.Flush();
            stream.Close();//一定要关闭流
        }
    }
}
