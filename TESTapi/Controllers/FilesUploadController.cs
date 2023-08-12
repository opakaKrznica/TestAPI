using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TESTapi.Models;

namespace TESTapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesUploadController : ControllerBase
    {
        public readonly IWebHostEnvironment _env;

        public FilesUploadController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpPost]

        public void Post(UploadedFile uploadedFile)
        {
            var root = $"{_env.ContentRootPath}\\WebShopPictures\\{uploadedFile.ProductId}";
            if (!Directory.Exists(root))
            {
                Directory.CreateDirectory(root);
            }

            var path = $"{root}\\{uploadedFile.FileName}";
            var fs = System.IO.File.Create(path);
            fs.Write(uploadedFile.FileContent, 0,
            uploadedFile.FileContent.Length);
            fs.Close();
        }

        //[HttpGet("get-product-photos/{id}")]
        //public IEnumerable<ImageFilePath> GetProductPhotos(int id)
        //{
        //    List<ImageFilePath> files = new List<ImageFilePath>();
        //    DirectoryInfo dirInfo = new DirectoryInfo($"{_env.ContentRootPath}\\WebShopPicture\\{id}");

        //    var request = HttpContext.Request;
        //    var baseUrl = $"{request.Scheme}://{request.Host}";
        //    if (dirInfo.Exists)
        //    {
        //        foreach (FileInfo fInfo in dirInfo.GetFiles())
        //        {
        //            files.Add(new ImageFilePath()
        //            {
        //                imagePath = baseUrl + "/WebShopPictures/" + id + "/" + fInfo.Name,
        //                ProductId = id
        //            });
        //        }
        //    }
        //    return files.ToList();
        //}
    }
}
