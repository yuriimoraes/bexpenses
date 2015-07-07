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
    public class DespesaTransporteController : Controller
    {
        private readonly RepositoryDespesaTransporte _despesaTransporteRepository = new RepositoryDespesaTransporte();
        //
        // GET: /DespesaTransporte/
        public ActionResult Index()
        {
            var despesaTransporteViewModel = Mapper.Map<IEnumerable<DespesaTransporte>, IEnumerable<DespesaTransporteViewModel>>(_despesaTransporteRepository.GetAll());
            return View(despesaTransporteViewModel);
        }

        //
        // GET: /DespesaTransporte/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DespesaTransporte/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaTransporte/Create
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
        // GET: /DespesaTransporte/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaTransporte/Edit/5
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
        // GET: /DespesaTransporte/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaTransporte/Delete/5
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
