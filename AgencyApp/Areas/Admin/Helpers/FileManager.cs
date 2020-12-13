using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AgencyApp.Areas.Admin.Helpers
{
    public class FileManager
    {
        private readonly IHostingEnvironment _env;
        public FileManager(IHostingEnvironment env)
        {
            _env = env;
        }


        //public static string Upload(IFormFile File, string _path)
        //{
        //    string filename = DateTime.Now.ToString("yyyyMMddHHmmssfff") + File.FileName;
        //    string path = Path.Combine(HttpContext.Current.Server.MapPath($"~/Uploads/{_path}/"), filename);
        //    File.SaveAs(path);

        //    return filename;
        //}

        //public static void Delete(string filename, string _path)
        //{
        //    string path = Path.Combine(HttpContext.Current.Server.MapPath($"~/Uploads/{_path}/"), filename);

        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //    }
        //}

    }
}
