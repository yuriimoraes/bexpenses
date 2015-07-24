using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Infra.Data.Repositories;
using BExpensesModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BExpensesDDD.Application.Interface;

namespace BExpensesModeloDDD.MVC.Controllers
{
    [Authorize]
    public class TaxaCambioController : Controller
    {
        private readonly ITaxaCambioAppService _taxaCambioApp;

        public TaxaCambioController(ITaxaCambioAppService taxaCambioApp)
        {
            _taxaCambioApp = taxaCambioApp;
        }

        //
        // GET: /TaxaCambio/
        public ActionResult Index()
        {
            var taxaCambioViewModel = Mapper.Map<IEnumerable<TaxaCambio>, IEnumerable<TaxaCambioViewModel>>(_taxaCambioApp.GetAll());
            return View(taxaCambioViewModel);
        }

        //
        // GET: /TaxaCambio/Details/5
        public ActionResult Details(int id)
        {
            var taxaCambio = _taxaCambioApp.GetById(id);
            var taxaCambioViewModel = Mapper.Map<TaxaCambio, TaxaCambioViewModel>(taxaCambio);
            return View(taxaCambioViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaxaCambioViewModel taxaCambio)
        {
            if (ModelState.IsValid)
            {
                var taxaCambioDomain = Mapper.Map<TaxaCambioViewModel, TaxaCambio>(taxaCambio);
                _taxaCambioApp.Add(taxaCambioDomain);
                return RedirectToAction("Index");
            }

            return View(taxaCambio);
        }

        //
        // GET: /TaxaCambio/Edit/5
        public ActionResult Edit(int id)
        {
            var taxaCambio = _taxaCambioApp.GetById(id);
            var taxaCambioViewModel = Mapper.Map<TaxaCambio, TaxaCambioViewModel>(taxaCambio);
            return View(taxaCambioViewModel);
        }

        //
        // POST: /TaxaCambio/Edit/5
        [HttpPost]
        public ActionResult Edit(TaxaCambioViewModel taxaCambio)
        {
            if (ModelState.IsValid)
            {
                var taxaCambioDomain = Mapper.Map<TaxaCambioViewModel, TaxaCambio>(taxaCambio);
                _taxaCambioApp.Update(taxaCambioDomain);
                return RedirectToAction("Index");
            }
            return View(taxaCambio);
        }

        //
        // GET: /TaxaCambio/Delete/5
        public ActionResult Delete(int id)
        {
            var taxaCambio = _taxaCambioApp.GetById(id);
            var taxaCambioViewModel = Mapper.Map<TaxaCambio, TaxaCambioViewModel>(taxaCambio);

            return View(taxaCambioViewModel);
        }

        //
        // POST: /TaxaCambio/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var taxaCambio = _taxaCambioApp.GetById(id);
            _taxaCambioApp.Remove(taxaCambio);

            return RedirectToAction("Index");

        }
    }
}
