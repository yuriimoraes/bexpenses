﻿using AutoMapper;
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
    public class TipoAcomodacaoController : Controller
    {
        private readonly RepositoryTipoAcomodacao _tipoAcomodacaoRepository = new RepositoryTipoAcomodacao();
        //
        // GET: /TipoAcomodacao/
        public ActionResult Index()
        {
            var tipoAcomodacaoViewModel = Mapper.Map<IEnumerable<TipoAcomodacao>, IEnumerable<TipoAcomodacaoViewModel>>(_tipoAcomodacaoRepository.GetAll());
            return View(tipoAcomodacaoViewModel);
        }

        //
        // GET: /TipoAcomodacao/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /TipoAcomodacao/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /TipoAcomodacao/Create
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
        // GET: /TipoAcomodacao/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /TipoAcomodacao/Edit/5
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
        // GET: /TipoAcomodacao/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /TipoAcomodacao/Delete/5
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
