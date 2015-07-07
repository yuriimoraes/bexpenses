using AutoMapper;
using BExpensesDDD.Domain.Entities;
using BExpensesDDD.Infra.Data.Repositories;
using BExpensesModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BExpensesModeloDDD.MVC.Controllers
{
    public class RespostaSolicitacaoController : Controller
    {
        private readonly RepositoryRespostaSolicitacao _respostaSolicitacaoRepository = new RepositoryRespostaSolicitacao();
        //
        // GET: /RespostaSolicitacao/
        public ActionResult Index()
        {
            var respostaSolicitacaoViewModel = Mapper.Map<IEnumerable<RespostaSolicitacao>, IEnumerable<RespostaSolicitacaoViewModel>>(_respostaSolicitacaoRepository.GetAll());
            return View(respostaSolicitacaoViewModel);
        }

        //
        // GET: /RespostaSolicitacao/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RespostaSolicitacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /RespostaSolicitacao/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /RespostaSolicitacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /RespostaSolicitacao/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
