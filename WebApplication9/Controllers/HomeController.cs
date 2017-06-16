﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models.ViewModel;

namespace WebApplication9.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Output()
        {
            var grid = new List<DataViewModel>
            {

                new DataViewModel {ID=1,Category="out",InputDate="2017/06/09",Money=1000,Message="AAA" },
                new DataViewModel {ID=2,Category="out",InputDate="2017/06/09",Money=1000,Message="AAA" },
                new DataViewModel {ID=3,Category="out",InputDate="2017/06/09",Money=1000,Message="AAA" },
                new DataViewModel {ID=3,Category="out",InputDate="2017/06/09",Money=1000,Message="AAA" }
            };

            return View(grid);
        }
    }
}