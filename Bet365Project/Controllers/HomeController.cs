﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bet365Project.Controllers
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

        public ActionResult List001MA()
        {

            using (var db = new MainDbContext())
            {

                var userId = db.scoccer.Where(u => u.ID == 0).Select(u => u.LEAGUE).ToList();
                string userNo = userId[0].ToString();

            }

            return View();
        }
    }
}