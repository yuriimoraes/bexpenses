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
    public class ParametrosSistemaController : Controller
    {
        private readonly IParametrosSistemaAppService _parametrosSistemaApp;

        public ParametrosSistemaController(IParametrosSistemaAppService parametrosSistemaApp)
        {
            _parametrosSistemaApp = parametrosSistemaApp;
        }

        //
        // GET: /ParametrosSistema/
        public ActionResult Index()
        {
            var parametrosSistemaViewModel = Mapper.Map<IEnumerable<ParametrosSistema>, IEnumerable<ParametrosSistemaViewModel>>(_parametrosSistemaApp.GetAll());
            return View(parametrosSistemaViewModel);
        }

        //
        // GET: /ParametrosSistema/Details/5
        public ActionResult Details(int id)
        {
            var parametrosSistema = _parametrosSistemaApp.GetById(id);
            var parametrosSistemaViewModel = Mapper.Map<ParametrosSistema, ParametrosSistemaViewModel>(parametrosSistema);
            return View(parametrosSistemaViewModel);
        }

        //
        // GET: /ParametrosSistema/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ParametrosSistema/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ParametrosSistemaViewModel parametrosSistema)
        {
            if (ModelState.IsValid)
            {
                var parametrosSistemaDomain = Mapper.Map<ParametrosSistemaViewModel, ParametrosSistema>(centrocusto);
                _parametrosSistemaApp.Add(parametrosSistemaDomain);
                return RedirectToAction("Index");
            }

            return View(parametrosSistema);
        }


        //
        // GET: /ParametrosSistema/Edit/5
        public ActionResult Edit(int id)
        {
            var parametrosSistema = _parametrosSistemaApp.GetById(id);
            var parametrosSistemaViewModel = Mapper.Map<ParametrosSistema, ParametrosSistemaViewModel>(parametrosSistema);
            return View(parametrosSistemaViewModel);
        }

        //
        // POST: /ParametrosSistema/Edit/5
        [HttpPost]
        public ActionResult Edit(ParametrosSistemaViewModel parametrosSistema)
        {
            if (ModelState.IsValid)
            {
                var parametrosSistemaDomain = Mapper.Map<ParametrosSistemaViewModel, ParametrosSistema>(parametrosSistema);
                _parametrosSistemaApp.Update(parametrosSistemaDomain);
                return RedirectToAction("Index");
            }
            return View(parametrosSistema);
        }

        //
        // GET: /ParametrosSistema/Delete/5
        public ActionResult Delete(int id)
        {
            var parametrosSistema = _parametrosSistemaApp.GetById(id);
            var parametrosSistemaViewModel = Mapper.Map<ParametrosSistema, ParametrosSistemaViewModel>(parametrosSistema);

            return View(parametrosSistemaViewModel);
        }

        //
        // POST: /ParametrosSistema/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var parametrosSistema = _parametrosSistemaApp.GetById(id);
            _parametrosSistemaApp.Remove(parametrosSistema);

            return RedirectToAction("Index");

        }
    }
}
