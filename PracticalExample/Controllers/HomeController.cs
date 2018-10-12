using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PracticalExample.Models;

namespace PracticalExample.Controllers
{
    public class HomeController : Controller
    {
        #region Default
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        #endregion

        public IActionResult Registration()
        {
            return View();
        }

        public IActionResult Files()
        {
            var files = new List<Models.Files>()
            {
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                },
                new Models.Files
                {
                    Id = 1,
                    Name = "adasdasdasd",
                    Description = "adasdasdasd",
                    Url = "adasdasdasd",
                    ContentType = "adasdasdasd"
                }
            };

            var vm = new ViewModels.FilesViewModel(files);

            ViewData.Add("vm", vm);
            return View();
        }
    }
}
