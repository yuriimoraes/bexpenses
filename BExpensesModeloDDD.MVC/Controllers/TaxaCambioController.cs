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
    public class TaxaCambioController : Controller
    {
        private readonly RepositoryTaxaCambio _taxaCambioRepository = new RepositoryTaxaCambio();
        //
        // GET: /TaxaCambio/
        public ActionResult Index()
        {
            var taxaCambioViewModel = Mapper.Map<IEnumerable<TaxaCambio>, IEnumerable<TaxaCambioViewModel>>(_taxaCambioRepository.GetAll());
            return View(taxaCambioViewModel);
        }

        //
        // GET: /TaxaCambio/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TaxaCambio/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TaxaCambio/Create
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
        // GET: /TaxaCambio/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TaxaCambio/Edit/5
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
        // GET: /TaxaCambio/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TaxaCambio/Delete/5
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
