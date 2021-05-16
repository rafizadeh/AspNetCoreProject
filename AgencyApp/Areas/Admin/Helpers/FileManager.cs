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

        //public static string Upload(IFormFile file, string _path)
        //{
        //    string filename = Path.GetFileName(file.FileName);
        //    string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", filename);

        //    using (var stream = new FileStream(path, FileMode.Create))
        //    {
        //        file.CopyToAsync(stream);
        //    }

        //    return filename;
        //}

        //public static void Delete(string filename, string _path)
        //{
        //    string path = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Uploads", filename);

        //    if (File.Exists(path))
        //    {
        //        File.Delete(path);
        //    }
        //}

    }
}
