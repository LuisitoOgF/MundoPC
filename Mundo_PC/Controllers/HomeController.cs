﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mundo_PC.Controllers
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
        public ActionResult productos()
        {
            return View();
        }
        public ActionResult mis_compras()
        {
            return View();
        }
        public ActionResult carrito()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult registro()
        {
            return View();
        }
        public ActionResult finalizar_compra()
        {
            return View();
        }
    }
}