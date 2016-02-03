using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResponseAnalysis.Models;

namespace ResponseAnalysis.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SurveyDBContext db = new SurveyDBContext();
            List<SM> SurveyList1  = db.SMs.ToList();
                  

            return View(SurveyList1);
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
    }
}