using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication9.Models.ViewModel;
using WebApplication9.Service;

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
            //var grid = new List<DataViewModel>();

            //    for (int i = 1; i < 10; i++)
            //    {
            //    grid.Add(new DataViewModel { ID = i, Category = "out", InputDate = DateTime.Parse("2017/06/09"), Money = 1000, Message = "AAA" });

            //    }



            //return View(grid);
            getData();
            return View(ViewBag.grid);
        }

        public ActionResult Input()
        {
            List<SelectListItem> mySelectItemList = new List<SelectListItem>();

            mySelectItemList.Add(new SelectListItem()
            {
                Text = "支出",
                Value = "1",
                Selected = true
            });

            mySelectItemList.Add(new SelectListItem()
            {
                Text = "收入",
                Value = "0",
                Selected = false
            });

            //var inputCategory = new List<DataViewModel>();


            //inputCategory.Add(new DataViewModel { CategoryList = mySelectItemList });

            var viewmodel = new DataViewModel()
            {
                CategoryList = mySelectItemList
            };




            return View(viewmodel);
            //getData();
            //return View(ViewBag.CategoryList);
        }

        private void getData()
        {
            UtilMethod UM = new UtilMethod();
            //ViewBag.CategoryList = UM.CategoryList();
            ViewBag.grid = UM.grid();
        }


    }
}