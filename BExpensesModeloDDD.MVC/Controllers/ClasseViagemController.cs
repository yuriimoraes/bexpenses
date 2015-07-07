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
    public class ClasseViagemController : Controller
    {
        private readonly RepositoryClasseViagem _classeViagemRepository = new RepositoryClasseViagem();
        //
        // GET: /ClasseViagem/
        public ActionResult Index()
        {
            var classeViagemViewModel = Mapper.Map<IEnumerable<ClasseViagem>, IEnumerable<ClasseViagemViewModel>>(_classeViagemRepository.GetAll());
            return View(classeViagemViewModel);
        }

        //
        // GET: /ClasseViagem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /ClasseViagem/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ClasseViagem/Create
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
        // GET: /ClasseViagem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /ClasseViagem/Edit/5
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
        // GET: /ClasseViagem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /ClasseViagem/Delete/5
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
