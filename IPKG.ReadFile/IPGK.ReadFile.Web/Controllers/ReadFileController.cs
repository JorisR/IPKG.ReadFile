using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using IPGK.ReadFile.Encryption;
using IPGK.ReadFile.Security;
using Microsoft.AspNetCore.Mvc;
using IPGK.ReadFile.Web.Models;

namespace IPGK.ReadFile.Web.Controllers
{
    public class ReadFileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ReadFileModel model)
        {
            try
            {
                var encryption = new ReverseEncryption();
                var security = new SecurityService();
                File file;
                switch (model.FileType)
                {
                    case FileType.FlatFile:
                        file = new FlatFile(encryption, security);
                        break;
                    case FileType.XmlFile:
                        file = new XmlFile(encryption, security);
                        break;
                    case FileType.Json:
                        file = new Json(encryption, security);
                        break;
                    default:
                        throw new Exception("error on filetype");
                }

                return Content(file.ReadFile(model.File, model.UseEncryption, model.UseSecurity, model.UserRole));

            }
            catch
            {
                return RedirectToAction("Index");
            }
        }

    }
}
