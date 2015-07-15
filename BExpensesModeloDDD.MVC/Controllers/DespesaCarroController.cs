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
    public class DespesaCarroController : Controller
    {
        private readonly IDespesaCarroAppService _despesaCarroApp;

        public DespesaCarroController(IDespesaCarroAppService despesaCarroApp)
        {
            _despesaCarroApp = despesaCarroApp;
        }

        //
        // GET: /DespesaCarro/
        public ActionResult Index()
        {
            var despesaCarroViewModel = Mapper.Map<IEnumerable<DespesaCarro>, IEnumerable<DespesaCarroViewModel>>(_despesaCarroApp.GetAll());
            return View(despesaCarroViewModel);
        }

        //
        // GET: /DespesaCarro/Details/5
        public ActionResult Details(int id)
        {
            var despesaCarro = _despesaCarroApp.GetById(id);
            var despesaCarroViewModel = Mapper.Map<DespesaCarro, DespesaCarroViewModel>(despesaCarro);
            return View(despesaCarroViewModel);
        }

        //
        // GET: /DespesaCarro/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaCarro/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaCarroViewModel despesaCarro)
        {
            if (ModelState.IsValid)
            {
                var despesaCarroDomain = Mapper.Map<DespesaCarroViewModel, DespesaCarro>(despesaCarro);
                _despesaCarroApp.Add(despesaCarroDomain);
                return RedirectToAction("Index");
            }

            return View(despesaCarro);
        }

        //
        // GET: /DespesaCarro/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaCarro = _despesaCarroApp.GetById(id);
            var despesaCarroViewModel = Mapper.Map<DespesaCarro, DespesaCarroViewModel>(despesaCarro);
            return View(despesaCarroViewModel);
        }

        //
        // POST: /DespesaCarro/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaCarroViewModel despesaCarro)
        {
            if (ModelState.IsValid)
            {
                var despesaCarroDomain = Mapper.Map<DespesaCarroViewModel, DespesaCarro>(despesaCarro);
                _despesaCarroApp.Update(despesaCarroDomain);
                return RedirectToAction("Index");
            }
            return View(despesaCarro);
        }

        //
        // GET: /DespesaCarro/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaCarro = _despesaCarroApp.GetById(id);
            var despesaCarroViewModel = Mapper.Map<DespesaCarro, DespesaCarroViewModel>(despesaCarro);

            return View(despesaCarroViewModel);
        }

        //
        // POST: /DespesaCarro/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaCarro = _despesaCarroApp.GetById(id);
            _despesaCarroApp.Remove(despesaCarro);

            return RedirectToAction("Index");

        }
    }
}
