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
    public class DespesaPerDiemController : Controller
    {
        private readonly IDespesaPerDiemAppService _despesaPerDiemApp;

        public DespesaPerDiemController(IDespesaPerDiemAppService despesaPerDiemApp)
        {
            _despesaPerDiemApp = despesaPerDiemApp;
        }

        //
        // GET: /DespesaPerDiem/
        public ActionResult Index()
        {
            var despesaPerDiemViewModel = Mapper.Map<IEnumerable<DespesaPerDiem>, IEnumerable<DespesaPerDiemViewModel>>(_despesaPerDiemApp.GetAll());
            return View(despesaPerDiemViewModel);
        }

        //
        // GET: /DespesaPerDiem/Details/5
        public ActionResult Details(int id)
        {
            var despesaPerDiem = _despesaPerDiemApp.GetById(id);
            var despesaPerDiemViewModel = Mapper.Map<DespesaPerDiem, DespesaPerDiemViewModel>(despesaPerDiem);
            return View(despesaPerDiemViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaPerDiemViewModel despesaPerDiem)
        {
            if (ModelState.IsValid)
            {
                var despesaPerDiemDomain = Mapper.Map<DespesaPerDiemViewModel, DespesaPerDiem>(despesaPerDiem);
                _despesaPerDiemApp.Add(despesaPerDiemDomain);
                return RedirectToAction("Index");
            }

            return View(despesaPerDiem);
        }

        //
        // GET: /DespesaPerDiem/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaPerDiem = _despesaPerDiemApp.GetById(id);
            var despesaPerDiemViewModel = Mapper.Map<DespesaPerDiem, DespesaPerDiemViewModel>(despesaPerDiem);
            return View(despesaPerDiemViewModel);
        }

        //
        // POST: /DespesaPerDiem/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaPerDiemViewModel despesaPerDiem)
        {
            if (ModelState.IsValid)
            {
                var despesaPerDiemDomain = Mapper.Map<DespesaPerDiemViewModel, DespesaPerDiem>(despesaPerDiem);
                _despesaPerDiemApp.Update(despesaPerDiemDomain);
                return RedirectToAction("Index");
            }
            return View(despesaPerDiem);
        }

        //
        // GET: /DespesaPerDiem/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaPerDiem = _despesaPerDiemApp.GetById(id);
            var despesaPerDiemViewModel = Mapper.Map<DespesaPerDiem, DespesaPerDiemViewModel>(despesaPerDiem);

            return View(despesaPerDiemViewModel);
        }

        //
        // POST: /DespesaPerDiem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var centroCusto = _despesaPerDiemApp.GetById(id);
            _despesaPerDiemApp.Remove(centroCusto);

            return RedirectToAction("Index");

        }
    }
}
