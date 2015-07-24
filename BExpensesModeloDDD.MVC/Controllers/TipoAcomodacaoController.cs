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
    public class TipoAcomodacaoController : Controller
    {
        private readonly ITipoAcomodacaoAppService _tipoAcomodacaoApp;

        public TipoAcomodacaoController(ITipoAcomodacaoAppService tipoAcomodacaoApp)
        {
            _tipoAcomodacaoApp = tipoAcomodacaoApp;
        }

        //
        // GET: /TipoAcomodacao/
        public ActionResult Index()
        {
            var tipoAcomodacaoViewModel = Mapper.Map<IEnumerable<TipoAcomodacao>, IEnumerable<TipoAcomodacaoViewModel>>(_tipoAcomodacaoApp.GetAll());
            return View(tipoAcomodacaoViewModel);
        }

        //
        // GET: /TipoAcomodacao/Details/5
        public ActionResult Details(int id)
        {
            var tipoAcomodacao = _tipoAcomodacaoApp.GetById(id);
            var tipoAcomodacaoViewModel = Mapper.Map<TipoAcomodacao, TipoAcomodacaoViewModel>(tipoAcomodacao);
            return View(tipoAcomodacaoViewModel);
        }

        //
        // GET: /TipoAcomodacao/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoAcomodacao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoAcomodacaoViewModel tipoAcomodacao)
        {
            if (ModelState.IsValid)
            {
                var tipoAcomodacaoDomain = Mapper.Map<TipoAcomodacaoViewModel, TipoAcomodacao>(tipoAcomodacao);
                _tipoAcomodacaoApp.Add(tipoAcomodacaoDomain);
                return RedirectToAction("Index");
            }

            return View(tipoAcomodacao);
        }

        //
        // GET: /TipoAcomodacao/Edit/5
        public ActionResult Edit(int id)
        {
            var tipoAcomodacao = _tipoAcomodacaoApp.GetById(id);
            var tipoAcomodacaoViewModel = Mapper.Map<TipoAcomodacao, TipoAcomodacaoViewModel>(tipoAcomodacao);
            return View(tipoAcomodacaoViewModel);
        }

        //
        // POST: /TipoAcomodacao/Edit/5
        [HttpPost]
        public ActionResult Edit(TipoAcomodacaoViewModel tipoAcomodacao)
        {
            if (ModelState.IsValid)
            {
                var tipoAcomodacaoDomain = Mapper.Map<TipoAcomodacaoViewModel, TipoAcomodacao>(tipoAcomodacao);
                _tipoAcomodacaoApp.Update(tipoAcomodacaoDomain);
                return RedirectToAction("Index");
            }
            return View(tipoAcomodacao);
        }

        //
        // GET: /TipoAcomodacao/Delete/5
        public ActionResult Delete(int id)
        {
            var tipoAcomodacao = _tipoAcomodacaoApp.GetById(id);
            var tipoAcomodacaoViewModel = Mapper.Map<TipoAcomodacao, TipoAcomodacaoViewModel>(tipoAcomodacao);

            return View(tipoAcomodacaoViewModel);
        }

        //
        // POST: /TipoAcomodacao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var centroCusto = _tipoAcomodacaoApp.GetById(id);
            _tipoAcomodacaoApp.Remove(centroCusto);

            return RedirectToAction("Index");

        }
    }
}
