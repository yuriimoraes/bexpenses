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
    public class SolicitacaoReembolsoController : Controller
    {
        private readonly ISolicitacaoReembolsoAppService _solicitacaoReembolsoApp;

        public SolicitacaoReembolsoController(ISolicitacaoReembolsoAppService solicitacaoReembolsoApp)
        {
            _solicitacaoReembolsoApp = solicitacaoReembolsoApp;
        }

        //
        // GET: /SolicitacaoReembolso/
        public ActionResult Index()
        {
            var solicitacaoReembolsoViewModel = Mapper.Map<IEnumerable<SolicitacaoReembolso>, IEnumerable<SolicitacaoReembolsoViewModel>>(_solicitacaoReembolsoApp.GetAll());
            return View(solicitacaoReembolsoViewModel);
        }

        //
        // GET: /SolicitacaoReembolso/Details/5
        public ActionResult Details(int id)
        {
            var solicitacaoReembolso = _solicitacaoReembolsoApp.GetById(id);
            var solicitacaoReembolsoViewModel = Mapper.Map<SolicitacaoReembolso, SolicitacaoReembolsoViewModel>(solicitacaoReembolso);
            return View(solicitacaoReembolsoViewModel);
        }

        //
        // GET: /SolicitacaoReembolso/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SolicitacaoReembolso/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(SolicitacaoReembolsoViewModel solicitacaoReembolso)
        {
            if (ModelState.IsValid)
            {
                var solicitacaoReembolsoDomain = Mapper.Map<SolicitacaoReembolsoViewModel, SolicitacaoReembolso>(solicitacaoReembolso);
                _solicitacaoReembolsoApp.Add(solicitacaoReembolsoDomain);
                return RedirectToAction("Index");
            }

            return View(solicitacaoReembolso);
        }

        //
        // GET: /SolicitacaoReembolso/Edit/5
        public ActionResult Edit(int id)
        {
            var solicitacaoReembolso = _solicitacaoReembolsoApp.GetById(id);
            var solicitacaoReembolsoViewModel = Mapper.Map<SolicitacaoReembolso, SolicitacaoReembolsoViewModel>(solicitacaoReembolso);
            return View(solicitacaoReembolsoViewModel);
        }

        //
        // POST: /SolicitacaoReembolso/Edit/5
        [HttpPost]
        public ActionResult Edit(SolicitacaoReembolsoViewModel solicitacaoReembolso)
        {
            if (ModelState.IsValid)
            {
                var solicitacaoReembolsoDomain = Mapper.Map<SolicitacaoReembolsoViewModel, SolicitacaoReembolso>(solicitacaoReembolso);
                _solicitacaoReembolsoApp.Update(solicitacaoReembolsoDomain);
                return RedirectToAction("Index");
            }
            return View(solicitacaoReembolso);
        }

        //
        // GET: /SolicitacaoReembolso/Delete/5
        public ActionResult Delete(int id)
        {
            var solicitacaoReembolso = _solicitacaoReembolsoApp.GetById(id);
            var solicitacaoReembolsoViewModel = Mapper.Map<SolicitacaoReembolso, SolicitacaoReembolsoViewModel>(solicitacaoReembolso);

            return View(solicitacaoReembolsoViewModel);
        }

        //
        // POST: /SolicitacaoReembolso/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var centroCusto = _solicitacaoReembolsoApp.GetById(id);
            _solicitacaoReembolsoApp.Remove(centroCusto);

            return RedirectToAction("Index");

        }
    }
}
