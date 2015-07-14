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
    public class MoedaController : Controller
    {
        private readonly IMoedaAppService _moedaApp;

        public MoedaController(IMoedaAppService moedaApp)
        {
            _moedaApp = moedaApp;
        }

        //
        // GET: /Moeda/
        public ActionResult Index()
        {
            var moedaViewModel = Mapper.Map<IEnumerable<Moeda>, IEnumerable<MoedaViewModel>>(_moedaApp.GetAll());
            return View(moedaViewModel);
        }

        //
        // GET: /Moeda/Details/5
        public ActionResult Details(int id)
        {
            var moeda = _moedaApp.GetById(id);
            var moedaViewModel = Mapper.Map<Moeda, MoedaViewModel>(moeda);
            return View(moedaViewModel);
        }

        //
        // GET: /Moeda/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Moeda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MoedaViewModel moeda)
        {
            if (ModelState.IsValid)
            {
                var moedaDomain = Mapper.Map<MoedaViewModel, Moeda>(moeda);
                _moedaApp.Add(moedaDomain);
                return RedirectToAction("Index");
            }

            return View(moeda);
        }

        //
        // GET: /Moeda/Edit/5
        public ActionResult Edit(int id)
        {
            var moeda = _moedaApp.GetById(id);
            var moedaViewModel = Mapper.Map<Moeda, MoedaViewModel>(moeda);
            return View(moedaViewModel);
        }

        //
        // POST: /Moeda/Edit/5
        [HttpPost]
        public ActionResult Edit(MoedaViewModel moeda)
        {
            if (ModelState.IsValid)
            {
                var moedaDomain = Mapper.Map<MoedaViewModel, Moeda>(moeda);
                _moedaApp.Update(moedaDomain);
                return RedirectToAction("Index");
            }
            return View(moeda);
        }

        //
        // GET: /Moeda/Delete/5
        public ActionResult Delete(int id)
        {
            var moeda = _moedaApp.GetById(id);
            var moedaViewModel = Mapper.Map<Moeda, MoedaViewModel>(moeda);

            return View(moedaViewModel);
        }

        //
        // POST: /Moeda/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var moeda = _moedaApp.GetById(id);
            _moedaApp.Remove(moeda);

            return RedirectToAction("Index");

        }
    }
}
