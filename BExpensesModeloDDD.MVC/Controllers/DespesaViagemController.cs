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
    public class DespesaViagemController : Controller
    {
        private readonly RepositoryDespesaViagem _despesaViagemRepository = new RepositoryDespesaViagem();
        //
        // GET: /DespesaViagem/
        public ActionResult Index()
        {
            var despesaViagemViewModel = Mapper.Map<IEnumerable<DespesaViagem>, IEnumerable<DespesaViagemViewModel>>(_despesaViagemRepository.GetAll());
            return View(despesaViagemViewModel);
        }

        //
        // GET: /DespesaViagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DespesaViagem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaViagem/Create
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
        // GET: /DespesaViagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaViagem/Edit/5
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
        // GET: /DespesaViagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaViagem/Delete/5
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
