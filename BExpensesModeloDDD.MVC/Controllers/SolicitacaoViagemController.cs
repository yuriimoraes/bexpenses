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
    public class SolicitacaoViagemController : Controller
    {
        private readonly ISolicitacaoViagemAppService _solicitacaoViagemApp;
        private readonly IPessoaAppService _pessoaApp;
        private readonly IPaisAppService _paisApp;

        public SolicitacaoViagemController(ISolicitacaoViagemAppService solicitacaoViagemApp, IPessoaAppService pessoaApp, IPaisAppService paisApp)
        {
            _solicitacaoViagemApp = solicitacaoViagemApp;
            _pessoaApp = pessoaApp;
            _paisApp = paisApp;
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
            ViewBag.PessoaRecebeID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            ViewBag.PessoaSolicitanteID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            ViewBag.PaisOrigemID = new SelectList(_paisApp.GetAll(), "PaisID", "NomePais");
            ViewBag.PaisDestinoID = new SelectList(_paisApp.GetAll(), "PaisID", "NomePais");

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
            ViewBag.PessoaRecebeID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            ViewBag.PessoaSolicitanteID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            ViewBag.PaisOrigemID = new SelectList(_paisApp.GetAll(), "PaisID", "NomePais");
            ViewBag.PaisDestinoID = new SelectList(_paisApp.GetAll(), "PaisID", "NomePais");

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
