using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using baitap2.Models;

namespace baitap2.Controllers
{
    public class DemoController : Controller
    {
        giaiphuongtrinh gpt = new giaiphuongtrinh();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult hello()
        {
            return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double hesoA, double hesoB)
        {
            double x = gpt.Giaiphuongtrinhbacnhat(hesoA, hesoB);
            ViewBag.nghiepPT = x;
            return View();
        }
    }
}