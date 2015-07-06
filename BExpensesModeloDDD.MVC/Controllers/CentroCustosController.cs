using System.Web.Mvc;
using BExpensesDDD.Domain;
using BExpensesDDD.Infra.Data.Repositories;
using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesModeloDDD.MVC.ViewModels;
using System.Collections.Generic;

namespace BExpensesModeloDDD.MVC.Controllers
{
    public class CentroCustosController : Controller
    {
        private readonly RepositoryCentroCusto _centrosCustosRepository = new RepositoryCentroCusto();
        //  
        // GET: /CentroCustos/
        public ActionResult Index()
        {
            var centroCustoViewModel = Mapper.Map<IEnumerable<CentroCusto>, IEnumerable<CentroCustoViewModel>>(_centrosCustosRepository.GetAll());
            return View(centroCustoViewModel);
        }

        //
        // GET: /CentroCustos/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /CentroCustos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CentroCustoViewModel centrocusto)
        {
            if (ModelState.IsValid)
            {
                var centrocustoDomain = Mapper.Map<CentroCustoViewModel, CentroCusto>(centrocusto);
                _centrosCustosRepository.Add(centrocustoDomain);
                return RedirectToAction("Index");
            }
            return View(centrocusto);
        }

        //
        // POST: /CentroCustos/Create
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
        // GET: /CentroCustos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /CentroCustos/Edit/5
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
        // GET: /CentroCustos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /CentroCustos/Delete/5
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
