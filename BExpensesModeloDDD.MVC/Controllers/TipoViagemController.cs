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
    public class TipoViagemController : Controller
    {
        private readonly ITipoViagemAppService _tipoViagemApp;

        public TipoViagemController(ITipoViagemAppService tipoViagemApp)
        {
            _tipoViagemApp = tipoViagemApp;
        }

        //
        // GET: /TipoViagem/
        public ActionResult Index()
        {
            var tipoViagemViewModel = Mapper.Map<IEnumerable<TipoViagem>, IEnumerable<TipoViagemViewModel>>(_tipoViagemApp.GetAll());
            return View(tipoViagemViewModel);
        }

        //
        // GET: /TipoViagem/Details/5
        public ActionResult Details(int id)
        {
            var tipoViagem = _tipoViagemApp.GetById(id);
            var tipoViagemViewModel = Mapper.Map<TipoViagem, TipoViagemViewModel>(tipoViagem);
            return View(tipoViagemViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoViagemViewModel tipoViagem)
        {
            if (ModelState.IsValid)
            {
                var tipoViagemDomain = Mapper.Map<TipoViagemViewModel, TipoViagem>(tipoViagem);
                _tipoViagemApp.Add(tipoViagemDomain);
                return RedirectToAction("Index");
            }

            return View(tipoViagem);
        }

        //
        // GET: /TipoViagem/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoViagem = _tipoViagemApp.GetById(id);
            var tipoViagemViewModel = Mapper.Map<TipoViagem, TipoViagemViewModel>(tipoViagem);
            return View(tipoViagemViewModel);
        }

        //
        // POST: /TipoViagem/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoViagemViewModel tipoViagem)
        {
            if (ModelState.IsValid)
            {
                var tipoViagemDomain = Mapper.Map<TipoViagemViewModel, TipoViagem>(tipoViagem);
                _tipoViagemApp.Update(tipoViagemDomain);
                return RedirectToAction("Index");
            }
            return View(tipoViagem);
        }

        //
        // GET: /TipoViagem/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoViagem = _tipoViagemApp.GetById(id);
            var tipoViagemViewModel = Mapper.Map<TipoViagem, TipoViagemViewModel>(tipoViagem);

            return View(tipoViagemViewModel);
        }

        //
        // POST: /TipoViagem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var tipoViagem = _tipoViagemApp.GetById(id);
            _tipoViagemApp.Remove(tipoViagem);

            return RedirectToAction("Index");

        }
    }
}
