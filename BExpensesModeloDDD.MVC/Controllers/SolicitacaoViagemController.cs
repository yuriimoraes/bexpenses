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
    public class SolicitacaoViagemController : Controller
    {
        private readonly ISolicitacaoViagemAppService _solicitacaoViagemApp;

        public SolicitacaoViagemController(ISolicitacaoViagemAppService solicitacaoViagemApp)
        {
            _solicitacaoViagemApp = solicitacaoViagemApp;
        }

        //
        // GET: /SolicitacaoViagem/
        public ActionResult Index()
        {
            var solicitacaoViagemViewModel = Mapper.Map<IEnumerable<SolicitacaoViagem>, IEnumerable<SolicitacaoViagemViewModel>>(_solicitacaoViagemApp.GetAll());
            return View(solicitacaoViagemViewModel);
        }

        //
        // GET: /SolicitacaoViagem/Details/5
        public ActionResult Details(int id)
        {
            var solicitacaoViagem = _solicitacaoViagemApp.GetById(id);
            var solicitacaoViagemViewModel = Mapper.Map<SolicitacaoViagem, SolicitacaoViagemViewModel>(solicitacaoViagem);
            return View(solicitacaoViagemViewModel);
        }
        

        //
        // GET: /SolicitacaoViagem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SolicitacaoViagem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SolicitacaoViagemViewModel solicitacaoViagem)
        {
            if (ModelState.IsValid)
            {
                var solicitacaoViagemDomain = Mapper.Map<SolicitacaoViagemViewModel, SolicitacaoViagem>(solicitacaoViagem);
                _solicitacaoViagemApp.Add(solicitacaoViagemDomain);
                return RedirectToAction("Index");
            }

            return View(solicitacaoViagem);
        }
        //
        // GET: /SolicitacaoViagem/Edit/5
        public ActionResult Edit(int id)
        {
            var solicitacaoViagem = _solicitacaoViagemApp.GetById(id);
            var solicitacaoViagemViewModel = Mapper.Map<SolicitacaoViagem, SolicitacaoViagemViewModel>(solicitacaoViagem);
            return View(solicitacaoViagemViewModel);
        }

        //
        // POST: /SolicitacaoViagem/Edit/5
        [HttpPost]
        public ActionResult Edit(SolicitacaoViagemViewModel solicitacaoViagem)
        {
            if (ModelState.IsValid)
            {
                var solicitacaoViagemDomain = Mapper.Map<SolicitacaoViagemViewModel, SolicitacaoViagem>(solicitacaoViagem);
                _solicitacaoViagemApp.Update(solicitacaoViagemDomain);
                return RedirectToAction("Index");
            }
            return View(solicitacaoViagem);
        }

        //
        // GET: /SolicitacaoViagem/Delete/5
        public ActionResult Delete(int id)
        {
            var solicitacaoViagem = _solicitacaoViagemApp.GetById(id);
            var solicitacaoViagemViewModel = Mapper.Map<SolicitacaoViagem, SolicitacaoViagemViewModel>(solicitacaoViagem);

            return View(solicitacaoViagemViewModel);
        }

        //
        // POST: /SolicitacaoViagem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var solicitacaoViagem = _solicitacaoViagemApp.GetById(id);
            _solicitacaoViagemApp.Remove(solicitacaoViagem);

            return RedirectToAction("Index");

        }
    }
}
