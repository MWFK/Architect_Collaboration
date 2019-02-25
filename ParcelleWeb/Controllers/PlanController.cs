using ParcelleDeTerre.Domaine.Entities;
using ParcelleWeb.Helpers;
using ParcelleWeb.Models;
using ServicesSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ParcelleWeb.Controllers
{
    public class PlanController : Controller
    {
        ServicePlan myserviceplan;
        ServiceArchitecte servicearchitecte;
        ServiceParcelle serviceparcelle;
        
        public PlanController()
        {
            myserviceplan = new ServicePlan();
            servicearchitecte = new ServiceArchitecte();
            serviceparcelle = new ServiceParcelle();
            
        }
        // GET: Plan
        public ActionResult Index()
        {
            return View();
        }

        // GET: Plan/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Plan/Create
        public ActionResult Create()
        {
            PlanVM p = new PlanVM();
            p.Architectes = servicearchitecte.GetMany().ToSelectListItems();
            p.Parcelles = serviceparcelle.GetMany().ToSelectListItems();
            //ViewBag.Architecte = new SelectList(architectes, "NumeroArchitecte", "Nom");
            //ViewBag.Parcelle = new SelectList(parcelles, "NumeroParcelle", "Endroit.Rue");
            
            return View(p);
        }

        // POST: Plan/Create
        [HttpPost]
        public ActionResult Create(PlanVM pvm)
        {
            Plan p = new Plan
            {
                DateDebut = pvm.DateDebut,
                DureeRealisation = pvm.DureeRealisation,
                NombreEtages = pvm.NombreEtages,
                NombrePieces = pvm.NombrePieces,
                Surface = pvm.Surface,
                Etat = Etat.Encours,
                NumeroParcelle = pvm.NumeroParcelle,
                NumeroArchitecte = pvm.NumeroArchitecte
            };
            myserviceplan.Add(p);
            myserviceplan.Commit();
            // myserviceplan.Dispose();
            return RedirectToAction("Index","Architecte");
        }

        // GET: Plan/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Plan/Edit/5
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

        // GET: Plan/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Plan/Delete/5
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
