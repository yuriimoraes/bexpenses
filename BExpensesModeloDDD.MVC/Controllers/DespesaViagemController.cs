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
    public class DespesaViagemController : Controller
    {
        private readonly IDespesaViagemAppService _despesaViagemApp;

        public DespesaViagemController(IDespesaViagemAppService despesaViagemApp)
        {
            _despesaViagemApp = despesaViagemApp;
        }

        //
        // GET: /DespesaViagem/
        public ActionResult Index()
        {
            var despesaViagemViewModel = Mapper.Map<IEnumerable<DespesaViagem>, IEnumerable<DespesaViagemViewModel>>(_despesaViagemApp.GetAll());
            return View(despesaViagemViewModel);
        }

        //
        // GET: /DespesaViagem/Details/5
        public ActionResult Details(int id)
        {
            var despesaViagem = _despesaViagemApp.GetById(id);
            var despesaViagemViewModel = Mapper.Map<DespesaViagem, DespesaViagemViewModel>(despesaViagem);
            return View(despesaViagemViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaViagemViewModel despesaViagem)
        {
            if (ModelState.IsValid)
            {
                var despesaViagemDomain = Mapper.Map<DespesaViagemViewModel, DespesaViagem>(despesaViagem);
                _despesaViagemApp.Add(despesaViagemDomain);
                return RedirectToAction("Index");
            }

            return View(despesaViagem);
        }

        //
        // GET: /DespesaViagem/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaViagem = _despesaViagemApp.GetById(id);
            var despesaViagemViewModel = Mapper.Map<DespesaViagem, DespesaViagemViewModel>(despesaViagem);
            return View(despesaViagemViewModel);
        }

        //
        // POST: /DespesaViagem/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaViagemViewModel despesaViagem)
        {
            if (ModelState.IsValid)
            {
                var despesaViagemDomain = Mapper.Map<DespesaViagemViewModel, DespesaViagem>(despesaViagem);
                _despesaViagemApp.Update(despesaViagemDomain);
                return RedirectToAction("Index");
            }
            return View(despesaViagem);
        }

        //
        // GET: /DespesaViagem/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaViagem = _despesaViagemApp.GetById(id);
            var despesaViagemViewModel = Mapper.Map<DespesaViagem, DespesaViagemViewModel>(despesaViagem);

            return View(despesaViagemViewModel);
        }

        //
        // POST: /DespesaViagem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaViagem = _despesaViagemApp.GetById(id);
            _despesaViagemApp.Remove(despesaViagem);

            return RedirectToAction("Index");

        }
    }
}
