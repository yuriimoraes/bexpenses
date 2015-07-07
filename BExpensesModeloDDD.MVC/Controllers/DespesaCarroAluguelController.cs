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
    public class DespesaCarroAluguelController : Controller
    {
        private readonly RepositoryDespesaCarroAluguel _despesaCarroAluguelRepository = new RepositoryDespesaCarroAluguel();
        
        //
        // GET: /DespesaCarroAluguel/
        public ActionResult Index()
        {
            var despesaCarroAluguelViewModel = Mapper.Map<IEnumerable<DespesaCarroAluguel>, IEnumerable<DespesaCarroAluguelViewModel>>(_despesaCarroAluguelRepository.GetAll());
            return View(despesaCarroAluguelViewModel);
        }

        //
        // GET: /DespesaCarroAluguel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /DespesaCarroAluguel/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DespesaCarroAluguel/Create
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
        // GET: /DespesaCarroAluguel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /DespesaCarroAluguel/Edit/5
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
        // GET: /DespesaCarroAluguel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /DespesaCarroAluguel/Delete/5
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
