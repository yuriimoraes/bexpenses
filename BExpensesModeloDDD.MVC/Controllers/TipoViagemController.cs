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
    public class TipoViagemController : Controller
    {
        private readonly RepositoryTipoViagem _tipoViagemRepository = new RepositoryTipoViagem();
        //
        // GET: /TipoViagem/
        public ActionResult Index()
        {
            var tipoViagemViewModel = Mapper.Map<IEnumerable<TipoViagem>, IEnumerable<TipoViagemViewModel>>(_tipoViagemRepository.GetAll());
            return View(tipoViagemViewModel);
        }

        //
        // GET: /TipoViagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TipoViagem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoViagem/Create
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
        // GET: /TipoViagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TipoViagem/Edit/5
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
        // GET: /TipoViagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TipoViagem/Delete/5
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
