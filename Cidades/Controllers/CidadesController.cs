using Antlr.Runtime.Misc;
using Cidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cidades.Controllers
{
    public class CidadesController : Controller
    {
        // GET: Cidades
        public ActionResult Index()
        {
            CidadesBDEntities banco = new CidadesBDEntities();
            var cidades = banco.Cidades;
            return View(cidades);
        }

        // GET: Cidades/Details/5
        [HttpGet]
        public ActionResult Details(int id)
        {
            var cidades = new CidadesBDEntities().Cidades
            .Where(x => x.ID == id).SingleOrDefault();

            return View(cidades);

        }

        // GET: Cidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cidades/Create
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

        // GET: Cidades/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cidades/Edit/5
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

        // GET: Cidades/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cidades/Delete/5
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
