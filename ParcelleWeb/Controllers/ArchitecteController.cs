using ParcelleDeTerre.Domaine.Entities;
using ServicesSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcelleWeb.Controllers
{
    public class ArchitecteController : Controller
    {
        ServiceArchitecte myserviceAr;
        public ArchitecteController()
        {
            myserviceAr = new ServiceArchitecte();
        }
        // GET: Architecte
        public ActionResult Index()
        {
            List<Architecte> architectes = new List<Architecte>();
            architectes = myserviceAr.GetMany().ToList();
            foreach (var item in architectes)
            {
                item.NombreProjetsEncours = myserviceAr.NbreProjetsEnCours(item);
                item.NombresProjetsParAnnée = myserviceAr.NbreProjetsAnnee(item);
            }
            
            return View(architectes);
        }

        // GET: Architecte/Details/5
        public ActionResult Details(int id)
        {
            Architecte a = myserviceAr.GetById(id);
            return View(a);
        }

        // GET: Architecte/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Architecte/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Architecte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Architecte/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Architecte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Architecte/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
