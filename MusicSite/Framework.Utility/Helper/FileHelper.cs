using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Framework.Utility.Config;

namespace Framework.Utility.Helper
{
    public class FileHelper
    {
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="files"></param>
        /// <returns></returns>
        public Tuple<bool, List<string>> SaveFile(string savePath, IFormFileCollection files)
        {
            List<string> filenames = new List<string>();

            var filePath = GlobalConfig.wwwwroot + Path.DirectorySeparatorChar  + savePath;

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            try
            {
                foreach (IFormFile formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        string fileExt = Path.GetExtension(formFile.FileName);
                        long fileSize = formFile.Length;
                        string newFileName = Guid.NewGuid().ToString("N") + fileExt;
                         
                        using (var stream = new FileStream(filePath + Path.DirectorySeparatorChar + newFileName, FileMode.Create))
                        {
                            formFile.CopyTo(stream);
                        }
                        filenames.Add(savePath +"/" + newFileName);
                    }
                }

                return Tuple.Create(true, filenames);
            }
            catch (Exception)
            {
                return Tuple.Create(false, filenames);
            }
        }
    }
}
