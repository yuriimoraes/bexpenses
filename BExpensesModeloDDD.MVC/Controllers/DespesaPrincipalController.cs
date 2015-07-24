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
    public class DespesaPrincipalController : Controller
    {
        private readonly IDespesaPrincipalAppService _despesaPrincipalApp;

        public DespesaPrincipalController(IDespesaPrincipalAppService despesaPrincipalApp)
        {
            _despesaPrincipalApp = despesaPrincipalApp;
        }

        //
        // GET: /DespesaPrincipal/
        public ActionResult Index()
        {
            var despesaPrincipalViewModel = Mapper.Map<IEnumerable<DespesaPrincipal>, IEnumerable<DespesaPrincipalViewModel>>(_despesaPrincipalApp.GetAll());
            return View(despesaPrincipalViewModel);
        }

        //
        // GET: /DespesaPrincipal/Details/5
        public ActionResult Details(int id)
        {
            var despesaPrincipal = _despesaPrincipalApp.GetById(id);
            var despesaPrincipalViewModel = Mapper.Map<DespesaPrincipal, DespesaPrincipalViewModel>(despesaPrincipal);
            return View(despesaPrincipalViewModel);
        }

        //
        // GET: /DespesaPrincipal/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaPrincipal/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaPrincipalViewModel despesaPrincipal)
        {
            if (ModelState.IsValid)
            {
                var despesaPrincipalDomain = Mapper.Map<DespesaPrincipalViewModel, DespesaPrincipal>(despesaPrincipal);
                _despesaPrincipalApp.Add(despesaPrincipalDomain);
                return RedirectToAction("Index");
            }

            return View(despesaPrincipal);
        }

        //
        // GET: /DespesaPrincipal/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaPrincipal = _despesaPrincipalApp.GetById(id);
            var despesaPrincipalViewModel = Mapper.Map<DespesaPrincipal, DespesaPrincipalViewModel>(despesaPrincipal);
            return View(despesaPrincipalViewModel);
        }

        //
        // POST: /DespesaPrincipal/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaPrincipalViewModel despesaPrincipal)
        {
            if (ModelState.IsValid)
            {
                var despesaPrincipalDomain = Mapper.Map<DespesaPrincipalViewModel, DespesaPrincipal>(despesaPrincipal);
                _despesaPrincipalApp.Update(despesaPrincipalDomain);
                return RedirectToAction("Index");
            }
            return View(despesaPrincipal);
        }

        //
        // GET: /DespesaPrincipal/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaPrincipal = _despesaPrincipalApp.GetById(id);
            var despesaPrincipalViewModel = Mapper.Map<DespesaPrincipal, DespesaPrincipalViewModel>(despesaPrincipal);

            return View(despesaPrincipalViewModel);
        }

        //
        // POST: /DespesaPrincipal/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaPrincipal = _despesaPrincipalApp.GetById(id);
            _despesaPrincipalApp.Remove(despesaPrincipal);

            return RedirectToAction("Index");

        }
    }
}
