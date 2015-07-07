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
    public class DespesaPerDiemController : Controller
    {
        private readonly RepositoryDespesaPerDiem _despesaPerDiemRepository = new RepositoryDespesaPerDiem();
        //
        // GET: /DespesaPerDiem/
        public ActionResult Index()
        {
            var despesaPerDiemViewModel = Mapper.Map<IEnumerable<DespesaPerDiem>, IEnumerable<DespesaPerDiemViewModel>>(_despesaPerDiemRepository.GetAll());
            return View(despesaPerDiemViewModel);
        }

        //
        // GET: /DespesaPerDiem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DespesaPerDiem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaPerDiem/Create
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
        // GET: /DespesaPerDiem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaPerDiem/Edit/5
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
        // GET: /DespesaPerDiem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaPerDiem/Delete/5
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
