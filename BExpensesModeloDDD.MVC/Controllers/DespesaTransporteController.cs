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
    public class DespesaTransporteController : Controller
    {
        private readonly IDespesaTransporteAppService _despesaTransporteApp;

        public DespesaTransporteController(IDespesaTransporteAppService despesaTransporteApp)
        {
            _despesaTransporteApp = despesaTransporteApp;
        }

        //
        // GET: /DespesaTransporte/
        public ActionResult Index()
        {
            var despesaTransporteViewModel = Mapper.Map<IEnumerable<DespesaTransporte>, IEnumerable<DespesaTransporteViewModel>>(_despesaTransporteApp.GetAll());
            return View(despesaTransporteViewModel);
        }

        //
        // GET: /DespesaTransporte/Details/5
        public ActionResult Details(int id)
        {
            var despesaTransporte = _despesaTransporteApp.GetById(id);
            var despesaTransporteViewModel = Mapper.Map<DespesaTransporte, DespesaTransporteViewModel>(despesaTransporte);
            return View(despesaTransporteViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaTransporteViewModel despesaTransporte)
        {
            if (ModelState.IsValid)
            {
                var despesaTransporteDomain = Mapper.Map<DespesaTransporteViewModel, DespesaTransporte>(despesaTransporte);
                _despesaTransporteApp.Add(despesaTransporteDomain);
                return RedirectToAction("Index");
            }

            return View(despesaTransporte);
        }

        //
        // GET: /DespesaTransporte/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaTransporte = _despesaTransporteApp.GetById(id);
            var despesaTransporteViewModel = Mapper.Map<DespesaTransporte, DespesaTransporteViewModel>(despesaTransporte);
            return View(despesaTransporteViewModel);
        }

        //
        // POST: /DespesaTransporte/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaTransporteViewModel despesaTransporte)
        {
            if (ModelState.IsValid)
            {
                var despesaTransporteDomain = Mapper.Map<DespesaTransporteViewModel, DespesaTransporte>(despesaTransporte);
                _despesaTransporteApp.Update(despesaTransporteDomain);
                return RedirectToAction("Index");
            }
            return View(despesaTransporte);
        }

        //
        // GET: /DespesaTransporte/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaTransporte = _despesaTransporteApp.GetById(id);
            var despesaTransporteViewModel = Mapper.Map<DespesaTransporte, DespesaTransporteViewModel>(despesaTransporte);

            return View(despesaTransporteViewModel);
        }

        //
        // POST: /DespesaTransporte/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaTransporte = _despesaTransporteApp.GetById(id);
            _despesaTransporteApp.Remove(despesaTransporte);

            return RedirectToAction("Index");

        }
    }
}
