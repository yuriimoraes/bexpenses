using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AutoMapper;
using BExpensesDDD.Application.Interface;
using BExpensesDDD.Domain.Entities;
using BExpensesModeloDDD.MVC.ViewModels;

namespace BExpensesModeloDDD.MVC.Controllers
{
    public class AutenticacaoController : Controller
    {

        private readonly IPessoaAppService _pessoaAppService;

        public AutenticacaoController(IPessoaAppService pessoaAppService)
        {
            _pessoaAppService = pessoaAppService;
        }


        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View(new PessoaViewModel());
        }

        [HttpPost]
        public ActionResult Login(PessoaViewModel pessoaViewModel, string returnUrl)
        {
            var pessoa = Mapper.Map<PessoaViewModel, Pessoa>(pessoaViewModel);

            if (ModelState.IsValid)
            {
                Pessoa pessoaValidar = _pessoaAppService.ObterPessoa(pessoa);
                if (pessoaValidar != null)
                {
                    if (!Equals(pessoa.Senha, pessoaValidar.Senha))
                    {
                        //Mensagem de senha invalida
                        ModelState.AddModelError("", "Senha Incorreta!");
                    }
                    else
                    {
                        
                       FormsAuthentication.SetAuthCookie(pessoaValidar.Login,false);

                       if (Url.IsLocalUrl(returnUrl)
                           && returnUrl.Length > 1
                           && returnUrl.StartsWith("/")
                           && !returnUrl.StartsWith("//")
                           && !returnUrl.StartsWith("/\\"))
                       {
                           return Redirect(returnUrl);
                       }
                        return RedirectToAction("Index","Home");
                    }
                }
                else
                {
                    //Mensagem de Pessoa não localizado
                    ModelState.AddModelError("","Pessoa não localizada!");
                }
            }
            return View(new PessoaViewModel());
        }
        public ActionResult Logoff()
        {
            FormsAuthentication.SignOut();
            return Redirect("/Home/Index");
        }
    }
}
