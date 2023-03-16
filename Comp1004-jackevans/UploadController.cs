using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace Comp1004_jackevans
{
    public class UploadController : Controller
    {
        public IActionResult Index(IFormFile files)
        {
            var fileName = Path.GetFileName(files.FileName);
            var uniqueFileName = Convert.ToString(Guid.NewGuid());
            var fileExtension = Path.GetExtension(fileName);
            var newFileName = String.Concat(uniqueFileName, fileExtension);
            var filePath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Images")).Root + $@"\{newFileName}";
            using (FileStream fs = System.IO.File.Create(filePath))
            {
                files.CopyTo(fs);
                fs.Flush();
            }
            return View();
        }
    }
}
