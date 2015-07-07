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
    public class SolicitacaoReembolsoController : Controller
    {
        private readonly RepositorySolicitacaoReembolso _solicitacaoReembolsoRepository = new RepositorySolicitacaoReembolso();
        //
        // GET: /SolicitacaoReembolso/
        public ActionResult Index()
        {
            var solicitacaoReembolsoViewModel = Mapper.Map<IEnumerable<SolicitacaoReembolso>, IEnumerable<SolicitacaoReembolsoViewModel>>(_solicitacaoReembolsoRepository.GetAll());
            return View(solicitacaoReembolsoViewModel);
        }

        //
        // GET: /SolicitacaoReembolso/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        // GET: /SolicitacaoReembolso/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SolicitacaoReembolso/Edit/5
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
        // GET: /SolicitacaoReembolso/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SolicitacaoReembolso/Delete/5
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
