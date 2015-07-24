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
    public class ClasseViagemController : Controller
    {
        private readonly IClasseViagemAppService _classeViagemApp;

        public ClasseViagemController(IClasseViagemAppService classeViagemApp)
        {
            _classeViagemApp = classeViagemApp;
        }

        //
        // GET: /ClasseViagem/
        public ActionResult Index()
        {
            var classeViagemViewModel = Mapper.Map<IEnumerable<ClasseViagem>, IEnumerable<ClasseViagemViewModel>>(_classeViagemApp.GetAll());
            return View(classeViagemViewModel);
        }

        //
        // GET: /ClasseViagem/Details/5
        public ActionResult Details(int id)
        {
            var classeViagem = _classeViagemApp.GetById(id);
            var classeViagemViewModel = Mapper.Map<ClasseViagem, ClasseViagemViewModel>(classeViagem);
            return View(classeViagemViewModel);
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
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClasseViagemViewModel classeViagem)
        {
            if (ModelState.IsValid)
            {
                var classeViagemDomain = Mapper.Map<ClasseViagemViewModel, ClasseViagem>(classeViagem);
                _classeViagemApp.Add(classeViagemDomain);
                return RedirectToAction("Index");
            }

            return View(classeViagem);
        }

        //
        // GET: /ClasseViagem/Edit/5
        public ActionResult Edit(int id)
        {
            var classeViagem = _classeViagemApp.GetById(id);
            var classeViagemViewModel = Mapper.Map<ClasseViagem, ClasseViagemViewModel>(classeViagem);
            return View(classeViagemViewModel);
        }

        //
        // POST: /ClasseViagem/Edit/5
        [HttpPost]
        public ActionResult Edit(ClasseViagemViewModel classeViagem)
        {
            if (ModelState.IsValid)
            {
                var classeViagemDomain = Mapper.Map<ClasseViagemViewModel, ClasseViagem>(classeViagem);
                _classeViagemApp.Update(classeViagemDomain);
                return RedirectToAction("Index");
            }
            return View(classeViagem);
        }

        //
        // GET: /ClasseViagem/Delete/5
        public ActionResult Delete(int id)
        {
            var classeViagem = _classeViagemApp.GetById(id);
            var classeViagemViewModel = Mapper.Map<ClasseViagem, ClasseViagemViewModel>(classeViagem);

            return View(classeViagemViewModel);
        }

        //
        // POST: /ClasseViagem/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var classeViagem = _classeViagemApp.GetById(id);
            _classeViagemApp.Remove(classeViagem);

            return RedirectToAction("Index");
        }
    }
}
