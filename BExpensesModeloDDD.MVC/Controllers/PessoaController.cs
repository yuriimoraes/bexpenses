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
    public class PessoaController : Controller
    {
        private readonly IPessoaAppService _pessoaApp;
        private readonly ICentroCustoAppService _centroCustoApp;
        

        public PessoaController(IPessoaAppService pessoaApp, ICentroCustoAppService centroCustoApp, IPessoaAppService aprovador1App, IPessoaAppService aprovador2App)
        {
            _pessoaApp = pessoaApp;
            _centroCustoApp = centroCustoApp;
        }


        //
        // GET: /Pessoa/
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaApp.GetAll());
            return View(pessoaViewModel);
        }

        //
        // GET: /Pessoa/Details/5
        public ActionResult Details(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            return View(pessoaViewModel);
        }

        //
        // GET: /Pessoa/Create
        public ActionResult Create()
        {
            ViewBag.CentroCustoID = new SelectList(_centroCustoApp.GetAll(), "CentroCustoID", "Descricao");
            ViewBag.Aprovador1ID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            ViewBag.Aprovador2ID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            return View();
        }

        //
        // POST: /Pessoa/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaApp.Add(pessoaDomain);
                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        //
        // GET: /Pessoa/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);
            ViewBag.CentroCustoID = new SelectList(_centroCustoApp.GetAll(), "CentroCustoID", "Descricao");
            ViewBag.Aprovador1ID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            ViewBag.Aprovador2ID = new SelectList(_pessoaApp.BuscarAprovadores(), "PessoaID", "Nome");
            return View(pessoaViewModel);
        }

        //
        // POST: /Pessoa/Edit/5
        [HttpPost]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaApp.Update(pessoaDomain);
                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        //
        // GET: /Pessoa/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        //
        // POST: /Pessoa/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var pessoa = _pessoaApp.GetById(id);
            _pessoaApp.Remove(pessoa);

            return RedirectToAction("Index");

        }
    }
}
