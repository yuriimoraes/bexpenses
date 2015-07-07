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
    public class DespesaPrincipalController : Controller
    {
        private readonly RepositoryDespesaPrincipal _despesaPrincipalRepository = new RepositoryDespesaPrincipal();
        
        //
        // GET: /DespesaPrincipal/
        public ActionResult Index()
        {
            var despesaPrincipalViewModel = Mapper.Map<IEnumerable<DespesaPrincipal>, IEnumerable<DespesaPrincipalViewModel>>(_despesaPrincipalRepository.GetAll());
            return View(despesaPrincipalViewModel);
        }

        //
        // GET: /DespesaPrincipal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DespesaPrincipal/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaPrincipal/Create
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
        // GET: /DespesaPrincipal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaPrincipal/Edit/5
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
        // GET: /DespesaPrincipal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaPrincipal/Delete/5
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
