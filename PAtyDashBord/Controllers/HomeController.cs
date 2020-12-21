﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PAtyDashBord.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sobre.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contatos.";

            return View();
        }
        public ActionResult Esquema() 
        {
            ViewBag.Menssage = "Esquema";
            return View();
        }
    }
}