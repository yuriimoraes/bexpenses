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
    public class TipoDespesaCarroController : Controller
    {
        private readonly ITipoDespesaCarroAppService _tipoDespesaCarroApp;//

        public TipoDespesaCarroController(ITipoDespesaCarroAppService tipoDespesaCarroApp)
        {
            _tipoDespesaCarroApp = tipoDespesaCarroApp;
        }


        // GET: /TipoDespesaCarro/
        public ActionResult Index()
        {
            var tipoDespesaCarroViewModel = Mapper.Map<IEnumerable<TipoDespesaCarro>, IEnumerable<TipoDespesaCarroViewModel>>(_tipoDespesaCarroApp.GetAll());
            return View(tipoDespesaCarroViewModel);
        }

        //
        // GET: /TipoDespesaCarro/Details/5
        public ActionResult Details(int id)
        {
            var tipoDespesaCarro = _tipoDespesaCarroApp.GetById(id);
            var tipoDespesaCarroViewModel = Mapper.Map<TipoDespesaCarro, TipoDespesaCarroViewModel>(tipoDespesaCarro);
            return View(tipoDespesaCarroViewModel);
        }

        //
        // GET: /TipoDespesaCarro/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoDespesaCarro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoDespesaCarroViewModel tipoDespesaCarro)
        {
            if (ModelState.IsValid)
            {
                var tipoDespesaCarroDomain = Mapper.Map<TipoDespesaCarroViewModel, TipoDespesaCarro>(tipoDespesaCarro);
                _tipoDespesaCarroApp.Add(tipoDespesaCarroDomain);
                return RedirectToAction("Index");
            }

            return View(tipoDespesaCarro);
        }

        //
        // GET: /TipoDespesaCarro/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoDespesaCarro = _tipoDespesaCarroApp.GetById(id);
            var tipoDespesaCarroViewModel = Mapper.Map<TipoDespesaCarro, TipoDespesaCarroViewModel>(tipoDespesaCarro);
            return View(tipoDespesaCarroViewModel);
        }

        //
        // POST: /TipoDespesaCarro/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoDespesaCarroViewModel tipoDespesaCarro)
        {
            if (ModelState.IsValid)
            {
                var tipoDespesaCarroDomain = Mapper.Map<TipoDespesaCarroViewModel, TipoDespesaCarro>(tipoDespesaCarro);
                _tipoDespesaCarroApp.Update(tipoDespesaCarroDomain);
                return RedirectToAction("Index");
            }
            return View(tipoDespesaCarro);
        }

        //
        // GET: /TipoDespesaCarro/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoDespesaCarro = _tipoDespesaCarroApp.GetById(id);
            var tipoDespesaCarroViewModel = Mapper.Map<TipoDespesaCarro, TipoDespesaCarroViewModel>(tipoDespesaCarro);

            return View(tipoDespesaCarroViewModel);
        }

        //
        // POST: /TipoDespesaCarro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var tipoDespesaCarro = _tipoDespesaCarroApp.GetById(id);
            _tipoDespesaCarroApp.Remove(tipoDespesaCarro);

            return RedirectToAction("Index");

        }
    }
}
