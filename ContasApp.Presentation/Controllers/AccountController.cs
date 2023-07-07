using ContasApp.Data.Entities;
using ContasApp.Data.Repositories;
using ContasApp.Presentation.Models;
using Microsoft.AspNetCore.Mvc;

namespace ContasApp.Presentation.Controllers
{
    /// <summary>
    /// Classe de controle do Asp.Net MVC
    /// </summary>
    public class AccountController : Controller
    {
        /// <summary>
        /// Método para abrir a página /Account/ Login
        /// </summary>
        public IActionResult Login() 
        {

            return View();
        }
        [HttpPost]
        public IActionResult Login(AccountLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //consultando o usuario no banco de dados atraves do emial e da senha
                    var usuarioRepository = new UsuarioRepository();
                    var usuario = usuarioRepository.GetByEmailAndSenha(model.Email, model.Senha);
                    
                    if(usuario != null)
                    {
                        //redirecionamento para outra paghina
                        //HOME -> Controller, Index -> View (Home/Index)
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        TempData["Mensagem"] = "Acesso negado. Usuário ínvalido!";
                    }

                }
                catch(Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }

            }
            else
            {

            }


            return View();
        }

        /// <summary>
        /// Método para abrir a página /Account/ Register
        /// </summary>
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(AccountRegisterViewModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var usuarioRepository = new UsuarioRepository();
                    if(usuarioRepository.GetByEmail(model.Email) != null)
                    {
                        TempData["Mensagem"] = "O email informado já está cadastrado, por favor tente outro.";

                    }
                    else
                    {
                        var usuario = new Usuario();

                        usuario.Id = Guid.NewGuid();
                        usuario.Nome = model.Nome;
                        usuario.Email = model.Email;
                        usuario.Senha = model.Senha;
                        usuario.DataHoraCriacao = DateTime.Now;


                        usuarioRepository.Add(usuario);

                        TempData["Mensagem"] = "Parabéns, sua conta de usuário foi cadastrada com sucesso!";
                    }


                   
                }
                catch(Exception e)
                {
                    TempData["Mensagem"] = e.Message;
                }
            }

            return View();
        }

        /// <summary>
        /// Método para abrir a página / Account/ ForgotPassword
        /// </summary>
      
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
