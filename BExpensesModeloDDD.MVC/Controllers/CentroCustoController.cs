using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BExpensesDDD.Application.Interface;

namespace BExpensesModeloDDD.MVC.Controllers
{
    public class CentroCustoController : Controller
    {
        private readonly ICentroCustoAppService _centroCustoApp;
        public CentroCustoController(ICentroCustoAppService centroCustoApp)
        {
            _centroCustoApp = centroCustoApp;
        }

        //
        // GET: /CentroCusto/
        public ActionResult Index()
        {
            var centroCustoViewModel = Mapper.Map<IEnumerable<CentroCusto>, IEnumerable<CentroCustoViewModel>>(_centroCustoApp.GetAll());
            return View(centroCustoViewModel);
        }

        //
        // GET: /CentroCusto/Details/5
        public ActionResult Details(int id)
        {
            var centroCusto = _centroCustoApp.GetById(id);
            var centroCustoViewModel = Mapper.Map<CentroCusto, CentroCustoViewModel>(centroCusto);
            return View(centroCustoViewModel);
        }

        //
        // GET: /CentroCusto/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CentroCusto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CentroCustoViewModel centrocusto)
        {
            if (ModelState.IsValid) 
            {
                var centrocustoDomain = Mapper.Map<CentroCustoViewModel, CentroCusto>(centrocusto);
                _centroCustoApp.Add(centrocustoDomain);
                return RedirectToAction("Index");
            }

            return View(centrocusto);
        }

        //
        // GET: /CentroCusto/Edit/5
        public ActionResult Edit(int id)
        {
            var centroCusto = _centroCustoApp.GetById(id);
            var centroCustoViewModel = Mapper.Map<CentroCusto, CentroCustoViewModel>(centroCusto);
            return View(centroCustoViewModel);
        }

        //
        // POST: /CentroCusto/Edit/5
        [HttpPost]
        public ActionResult Edit(CentroCustoViewModel centroCusto)
        {
            if (ModelState.IsValid)
            {
                var centroCustoDomain = Mapper.Map<CentroCustoViewModel, CentroCusto>(centroCusto);
                _centroCustoApp.Update(centroCustoDomain);
                return RedirectToAction("Index");
            }
            return View(centroCusto);
        }

        //
        // GET: /CentroCusto/Delete/5
        public ActionResult Delete(int id)
        {
            var centroCusto = _centroCustoApp.GetById(id);
            var centroCustoViewModel = Mapper.Map<CentroCusto, CentroCustoViewModel>(centroCusto);
            
            return View(centroCustoViewModel);
        }

        //
        // POST: /CentroCusto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
          
            var centroCusto = _centroCustoApp.GetById(id);
            _centroCustoApp.Remove(centroCusto);
    
            return RedirectToAction("Index");
           
        }
    }
}
