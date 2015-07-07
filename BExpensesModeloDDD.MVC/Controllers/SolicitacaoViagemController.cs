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
    public class SolicitacaoViagemController : Controller
    {
        private readonly RepositorySolicitacaoViagem _solicitacaoViagemRepository = new RepositorySolicitacaoViagem();
        //
        // GET: /SolicitacaoViagem/
        public ActionResult Index()
        {
            var solicitacaoViagemViewModel = Mapper.Map<IEnumerable<SolicitacaoViagem>, IEnumerable<SolicitacaoViagemViewModel>>(_solicitacaoViagemRepository.GetAll());
            return View(solicitacaoViagemViewModel);
        }

        //
        // GET: /SolicitacaoViagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        // GET: /SolicitacaoViagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /SolicitacaoViagem/Edit/5
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
        // GET: /SolicitacaoViagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /SolicitacaoViagem/Delete/5
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
