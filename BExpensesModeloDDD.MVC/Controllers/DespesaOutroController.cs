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
    public class DespesaOutroController : Controller
    {
        private readonly RepositoryDespesaOutro _despesaOutroRepository = new RepositoryDespesaOutro();
        
        //
        // GET: /DespesaOutro/
        public ActionResult Index()
        {
            var despesaOutroViewModel = Mapper.Map<IEnumerable<DespesaOutro>, IEnumerable<DespesaOutroViewModel>>(_despesaOutroRepository.GetAll());
            return View(despesaOutroViewModel);
        }

        //
        // GET: /DespesaOutro/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DespesaOutro/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaOutro/Create
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
        // GET: /DespesaOutro/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaOutro/Edit/5
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
        // GET: /DespesaOutro/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaOutro/Delete/5
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
