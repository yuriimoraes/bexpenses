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
    public class DespesaCarroAluguelController : Controller
    {
        private readonly IDespesaCarroAluguelAppService _despesaCarroAluguelApp;

        public DespesaCarroAluguelController(IDespesaCarroAluguelAppService despesaCarroAluguelApp)
        {
            _despesaCarroAluguelApp = despesaCarroAluguelApp;
        }

        //
        // GET: /DespesaCarroAluguel/
        public ActionResult Index()
        {
            var despesaCarroAluguelViewModel = Mapper.Map<IEnumerable<DespesaCarroAluguel>, IEnumerable<DespesaCarroAluguelViewModel>>(_despesaCarroAluguelApp.GetAll());
            return View(despesaCarroAluguelViewModel);
        }

        //
        // GET: /DespesaCarroAluguel/Details/5
        public ActionResult Details(int id)
        {
            var despesaCarroAluguel = _despesaCarroAluguelApp.GetById(id);
            var despesaCarroAluguelViewModel = Mapper.Map<DespesaCarroAluguel, DespesaCarroAluguelViewModel>(despesaCarroAluguel);
            return View(despesaCarroAluguelViewModel);
        }

        //
        // GET: /DespesaCarroAluguel/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaCarroAluguel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaCarroAluguelViewModel despesaCarroAluguel)
        {
            if (ModelState.IsValid)
            {
                var despesaCarroAluguelDomain = Mapper.Map<DespesaCarroAluguelViewModel, DespesaCarroAluguel>(despesaCarroAluguel);
                _despesaCarroAluguelApp.Add(despesaCarroAluguelDomain);
                return RedirectToAction("Index");
            }

            return View(despesaCarroAluguel);
        }

        //
        // GET: /DespesaCarroAluguel/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaCarroAluguel = _despesaCarroAluguelApp.GetById(id);
            var despesaCarroAluguelViewModel = Mapper.Map<DespesaCarroAluguel, DespesaCarroAluguelViewModel>(despesaCarroAluguel);
            return View(despesaCarroAluguelViewModel);
        }

        //
        // POST: /DespesaCarroAluguel/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaCarroAluguelViewModel despesaCarroAluguel)
        {
            if (ModelState.IsValid)
            {
                var despesaCarroAluguelDomain = Mapper.Map<DespesaCarroAluguelViewModel, DespesaCarroAluguel>(despesaCarroAluguel);
                _despesaCarroAluguelApp.Update(despesaCarroAluguelDomain);
                return RedirectToAction("Index");
            }
            return View(despesaCarroAluguel);
        }

        //
        // GET: /DespesaCarroAluguel/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaCarroAluguel = _despesaCarroAluguelApp.GetById(id);
            var despesaCarroAluguelViewModel = Mapper.Map<DespesaCarroAluguel, DespesaCarroAluguelViewModel>(despesaCarroAluguel);

            return View(despesaCarroAluguelViewModel);
        }

        //
        // POST: /DespesaCarroAluguel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaCarroAluguel = _despesaCarroAluguelApp.GetById(id);
            _despesaCarroAluguelApp.Remove(despesaCarroAluguel);

            return RedirectToAction("Index");

        }
    }
}
