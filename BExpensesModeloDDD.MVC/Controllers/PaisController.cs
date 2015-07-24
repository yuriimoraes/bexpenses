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
    public class PaisController : Controller
    {
        private readonly IPaisAppService _paisApp;

        public PaisController(IPaisAppService paisApp)
        {
            _paisApp = paisApp;
        }


        //
        // GET: /Pais/
        public ActionResult Index()
        {
            var paisViewModel = Mapper.Map<IEnumerable<Pais>, IEnumerable<PaisViewModel>>(_paisApp.GetAll());
            return View(paisViewModel);
        }

        //
        // GET: /Pais/Details/5
        public ActionResult Details(int id)
        {
            var pais = _paisApp.GetById(id);
            var paisViewModel = Mapper.Map<Pais, PaisViewModel>(pais);
            return View(paisViewModel);
        }

        //
        // GET: /Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Pais/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaisViewModel pais)
        {
            if (ModelState.IsValid)
            {
                var paisDomain = Mapper.Map<PaisViewModel, Pais>(pais);
                _paisApp.Add(paisDomain);
                return RedirectToAction("Index");
            }

            return View(pais);
        }

        //
        // GET: /Pais/Edit/5
        public ActionResult Edit(int id)
        {
            var pais = _paisApp.GetById(id);
            var paisViewModel = Mapper.Map<Pais, PaisViewModel>(pais);
            return View(paisViewModel);
        }

        //
        // POST: /Pais/Edit/5
        [HttpPost]
        public ActionResult Edit(PaisViewModel pais)
        {
            if (ModelState.IsValid)
            {
                var paisDomain = Mapper.Map<PaisViewModel, Pais>(pais);
                _paisApp.Update(paisDomain);
                return RedirectToAction("Index");
            }
            return View(pais);
        }

        //
        // GET: /Pais/Delete/5
        public ActionResult Delete(int id)
        {
            var pais = _paisApp.GetById(id);
            var paisViewModel = Mapper.Map<Pais, PaisViewModel>(pais);

            return View(paisViewModel);
        }

        //
        // POST: /Pais/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var pais = _paisApp.GetById(id);
            _paisApp.Remove(pais);

            return RedirectToAction("Index");

        }
    }
}
