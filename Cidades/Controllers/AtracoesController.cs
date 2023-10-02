using Cidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cidades.Controllers
{
    public class AtracoesController : Controller
    {
        // GET: Atracoes
        public ActionResult Index()
        {
            CidadesBDEntities banco = new CidadesBDEntities();
            var Atracoes = banco.Atracoes;
            return View(Atracoes);
        }

        // GET: Atracoes/Details/5
        public ActionResult Details(int id)
        {
            var atracoes = new CidadesBDEntities().Atracoes
         .Where(x => x.ID == id).SingleOrDefault();

            return View(atracoes);
        }

        // GET: Atracoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Atracoes/Create
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

        // GET: Atracoes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Atracoes/Edit/5
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

        // GET: Atracoes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Atracoes/Delete/5
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
