using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Infra.Data.Repositories;
using BExpensesModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BExpensesModeloDDD.MVC.Controllers
{
    public class PaisController : Controller
    {
        private readonly RepositoryPais _PaisRepository = new RepositoryPais();
        //
        // GET: /Pais/
        public ActionResult Index()
        {
            var paisViewModel = Mapper.Map<IEnumerable<Pais>, IEnumerable<PaisViewModel>>(_PaisRepository.GetAll());
            return View(paisViewModel);
        }

        //
        // GET: /Pais/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pais/Create
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

        //
        // GET: /Pais/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Pais/Edit/5
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

        //
        // GET: /Pais/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Pais/Delete/5
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
