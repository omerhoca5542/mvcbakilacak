using personelimmvc.Models.EntityFramework;
using personelimmvc.view_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace personelimmvc.Controllers
{
    public class personelController : Controller
    {
        personelim bag = new personelim();
        // GET: personel
        public ActionResult Index()
        {
            var model = bag.personel.ToList();
            return View(model);
        }
        public ActionResult Yeni()
        {
            var model = new Personelformviewmodels()
            {// modele Personelformviewmodel de bulunan departmanlar nesnesine
// departmanlar tablosunu listeleyerek  attı
                departmanlar = bag.Departman.ToList()

            };

            return View("Personelform",model);
            // personelform sayfasına da modeli gönderdi
        }
        public ActionResult kaydet(personel personel) {

            
            if (personel.id==0)// 0 olması kaydetme anlamına gelecek
            {
                bag.personel.Add(personel);  
            }
            else
            {

            }
            bag.SaveChanges();
            return RedirectToAction("Index");
        }

    
    }
}