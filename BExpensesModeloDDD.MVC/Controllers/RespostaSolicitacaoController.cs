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
    public class RespostaSolicitacaoController : Controller
    {
        private readonly IRespostaSolicitacaoReembolsoAppService _respostaSolicitacaoApp;

        public RespostaSolicitacaoController(IRespostaSolicitacaoReembolsoAppService respostaSolicitacaoApp)
        {
            _respostaSolicitacaoApp = respostaSolicitacaoApp;
        }

        //
        // GET: /RespostaSolicitacao/
        public ActionResult Index()
        {
            var respostaSolicitacaoViewModel = Mapper.Map<IEnumerable<RespostaSolicitacaoReembolso>, IEnumerable<RespostaSolicitacaoReembolsoViewModel>>(_respostaSolicitacaoApp.GetAll());
            return View(respostaSolicitacaoViewModel);
        }

        //
        // GET: /RespostaSolicitacao/Details/5
        public ActionResult Details(int id)
        {
            var respostaSolicitacao = _respostaSolicitacaoApp.GetById(id);
            var respostaSolicitacaoViewModel = Mapper.Map<RespostaSolicitacaoReembolso, RespostaSolicitacaoReembolsoViewModel>(respostaSolicitacao);
            return View(respostaSolicitacaoViewModel);
        }

        //
        // GET: /RespostaSolicitacao/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /RespostaSolicitacao/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RespostaSolicitacaoReembolsoViewModel respostaSolicitacao)
        {
            if (ModelState.IsValid)
            {
                var respostaSolicitacaoDomain = Mapper.Map<RespostaSolicitacaoReembolsoViewModel, RespostaSolicitacaoReembolso>(respostaSolicitacao);
                _respostaSolicitacaoApp.Add(respostaSolicitacaoDomain);
                return RedirectToAction("Index");
            }

            return View(respostaSolicitacao);
        }

        //
        // GET: /RespostaSolicitacao/Edit/5
        public ActionResult Edit(int id)
        {
            var respostaSolicitacao = _respostaSolicitacaoApp.GetById(id);
            var respostaSolicitacaoViewModel = Mapper.Map<RespostaSolicitacaoReembolso, RespostaSolicitacaoReembolsoViewModel>(respostaSolicitacao);
            return View(respostaSolicitacaoViewModel);
        }

        //
        // POST: /RespostaSolicitacao/Edit/5
        [HttpPost]
        public ActionResult Edit(RespostaSolicitacaoReembolsoViewModel respostaSolicitacao)
        {
            if (ModelState.IsValid)
            {
                var respostaSolicitacaoDomain = Mapper.Map<RespostaSolicitacaoReembolsoViewModel, RespostaSolicitacaoReembolso>(respostaSolicitacao);
                _respostaSolicitacaoApp.Update(respostaSolicitacaoDomain);
                return RedirectToAction("Index");
            }
            return View(respostaSolicitacao);
        }

        //
        // GET: /RespostaSolicitacao/Delete/5
        public ActionResult Delete(int id)
        {
            var respostaSolicitacao = _respostaSolicitacaoApp.GetById(id);
            var respostaSolicitacaoViewModel = Mapper.Map<RespostaSolicitacaoReembolso, RespostaSolicitacaoReembolsoViewModel>(respostaSolicitacao);

            return View(respostaSolicitacaoViewModel);
        }

        //
        // POST: /RespostaSolicitacao/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var respostaSolicitacao = _respostaSolicitacaoApp.GetById(id);
            _respostaSolicitacaoApp.Remove(respostaSolicitacao);

            return RedirectToAction("Index");

        }
    }
}
