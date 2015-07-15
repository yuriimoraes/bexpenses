using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Infra.Data.Repositories;
using BExpensesModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BExpensesDDD.Domain.Interfaces.Services;

namespace BExpensesModeloDDD.MVC.Controllers
{
    public class DespesaOutroController : Controller
    {
        private readonly IDespesaOutroService _despesaOutroApp;

        public DespesaOutroController(IDespesaOutroService despesaOutroApp)
        {
            _despesaOutroApp = despesaOutroApp;
        }

        //
        // GET: /DespesaOutro/
        public ActionResult Index()
        {
            var despesaOutroViewModel = Mapper.Map<IEnumerable<DespesaOutro>, IEnumerable<DespesaOutroViewModel>>(_despesaOutroApp.GetAll());
            return View(despesaOutroViewModel);
        }

        //
        // GET: /DespesaOutro/Details/5
        public ActionResult Details(int id)
        {

            var despesaOutro = _despesaOutroApp.GetByID(id);
            var despesaOutroViewModel = Mapper.Map<DespesaOutro, DespesaOutroViewModel>(despesaOutro);
            return View(despesaOutroViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaOutroViewModel despesaOutro)
        {
            if (ModelState.IsValid)
            {
                var despesaOutroDomain = Mapper.Map<DespesaOutroViewModel, DespesaOutro>(despesaOutro);
                _despesaOutroApp.Add(despesaOutroDomain);
                return RedirectToAction("Index");
            }

            return View(despesaOutro);
        }

        //
        // GET: /DespesaOutro/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaOutro = _despesaOutroApp.GetByID(id);
            var despesaOutroViewModel = Mapper.Map<DespesaOutro, DespesaOutroViewModel>(despesaOutro);
            return View(despesaOutroViewModel);
        }

        //
        // POST: /DespesaOutro/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaOutroViewModel despesaOutro)
        {
            if (ModelState.IsValid)
            {
                var despesaOutroDomain = Mapper.Map<DespesaOutroViewModel, DespesaOutro>(despesaOutro);
                _despesaOutroApp.Update(despesaOutroDomain);
                return RedirectToAction("Index");
            }
            return View(despesaOutro);
        }

        //
        // GET: /DespesaOutro/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaOutro = _despesaOutroApp.GetByID(id);
            var despesaOutroViewModel = Mapper.Map<DespesaOutro, DespesaOutroViewModel>(despesaOutro);

            return View(despesaOutroViewModel);
        }

        //
        // POST: /DespesaOutro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaOutro = _despesaOutroApp.GetByID(id);
            _despesaOutroApp.Remove(despesaOutro);

            return RedirectToAction("Index");

        }
    }
}
