using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using task1.Models;

namespace task1.Controllers
{
    public class HomeController : Controller
    {
        databaseContext db = new databaseContext();
        public ActionResult Index()
        {
            var data = (from fst in db.Images select fst).ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpPost]
        public JsonResult postAbout()
        {
            Images img = new Images();
            for (int i = 0; i < Request.Files.Count; i++)
            {
                var file = Request.Files[i];

                var fileName = new Random().Next().ToString() + Path.GetExtension(file.FileName);
                try
                {
                    var path = Path.Combine(Server.MapPath("/images/"), fileName);
                    file.SaveAs(path);
                    img.ImgName = fileName;
                    db.Images.Add(img);
                    db.SaveChanges();
                }
                catch (Exception e)
                {

                }
                
            }
            return Json(true, JsonRequestBehavior.AllowGet);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}