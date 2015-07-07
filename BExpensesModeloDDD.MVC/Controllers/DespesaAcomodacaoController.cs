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
    public class DespesaAcomodacaoController : Controller
    {
        private readonly RepositoryDespesaAcomodacao _despesaAcomodacaoRepository = new RepositoryDespesaAcomodacao();
        //
        // GET: /DespesaAcomodacao/
        public ActionResult Index()
        {
            var despesaAcomodacaoViewModel = Mapper.Map<IEnumerable<DespesaAcomodacao>, IEnumerable<DespesaAcomodacaoViewModel>>(_despesaAcomodacaoRepository.GetAll());
            return View(despesaAcomodacaoViewModel);
        }

        //
        // GET: /DespesaAcomodacao/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        // GET: /DespesaAcomodacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaAcomodacao/Edit/5
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
        // GET: /DespesaAcomodacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaAcomodacao/Delete/5
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
