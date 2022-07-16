using personelimmvc.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace personelimmvc.Controllers
{
    public class departmanController : Controller
    {
        personelim bag = new personelim();
        // GET: departman
        public ActionResult Index()
        {
            var model = bag.Departman.ToList();
            return View(model);
        }
    }
}