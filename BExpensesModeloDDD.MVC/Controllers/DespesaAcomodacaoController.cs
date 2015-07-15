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
    public class DespesaAcomodacaoController : Controller
    {
        private readonly IDespesaAcomodacaoAppService _despesaAcomodacaoApp;

        public DespesaAcomodacaoController(IDespesaAcomodacaoAppService despesaAcomodacaoApp)
        {
            _despesaAcomodacaoApp = despesaAcomodacaoApp;
        }

        //
        // GET: /DespesaAcomodacao/
        public ActionResult Index()
        {
            var despesaAcomodacaoViewModel = Mapper.Map<IEnumerable<DespesaAcomodacao>, IEnumerable<DespesaAcomodacaoViewModel>>(_despesaAcomodacaoApp.GetAll());
            return View(despesaAcomodacaoViewModel);
        }

        //
        // GET: /DespesaAcomodacao/Details/5
        public ActionResult Details(int id)
        {
            var despesaAcomodacao = _despesaAcomodacaoApp.GetById(id);
            var despesaAcomodacaoViewModel = Mapper.Map<DespesaAcomodacao, DespesaAcomodacaoViewModel>(despesaAcomodacao);
            return View(despesaAcomodacaoViewModel);
        }

        //
        // GET: /DespesaAcomodacao/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaAcomodacao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(DespesaAcomodacaoViewModel despesaAcomodacao)
        {
            if (ModelState.IsValid)
            {
                var despesaAcomodacaoDomain = Mapper.Map<DespesaAcomodacaoViewModel, DespesaAcomodacao>(despesaAcomodacao);
                _despesaAcomodacaoApp.Add(despesaAcomodacaoDomain);
                return RedirectToAction("Index");
            }

            return View(despesaAcomodacao);
        }

        //
        // GET: /DespesaAcomodacao/Edit/5
        public ActionResult Edit(int id)
        {
            var despesaAcomodacao = _despesaAcomodacaoApp.GetById(id);
            var despesaAcomodacaoViewModel = Mapper.Map<DespesaAcomodacao, DespesaAcomodacaoViewModel>(despesaAcomodacao);
            return View(despesaAcomodacaoViewModel);
        }

        //
        // POST: /DespesaAcomodacao/Edit/5
        [HttpPost]
        public ActionResult Edit(DespesaAcomodacaoViewModel despesaAcomodacao)
        {
            if (ModelState.IsValid)
            {
                var despesaAcomodacaoDomain = Mapper.Map<DespesaAcomodacaoViewModel, DespesaAcomodacao>(despesaAcomodacao);
                _despesaAcomodacaoApp.Update(despesaAcomodacaoDomain);
                return RedirectToAction("Index");
            }
            return View(despesaAcomodacao);
        }

        //
        // GET: /DespesaAcomodacao/Delete/5
        public ActionResult Delete(int id)
        {
            var despesaAcomodacao = _despesaAcomodacaoApp.GetById(id);
            var despesaAcomodacaoViewModel = Mapper.Map<DespesaAcomodacao, DespesaAcomodacaoViewModel>(despesaAcomodacao);

            return View(despesaAcomodacaoViewModel);
        }

        //
        // POST: /DespesaAcomodacao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var despesaAcomodacao = _despesaAcomodacaoApp.GetById(id);
            _despesaAcomodacaoApp.Remove(despesaAcomodacao);

            return RedirectToAction("Index");

        }
    }
}
