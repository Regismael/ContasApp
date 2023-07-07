using Microsoft.AspNetCore.Mvc;

namespace ContasApp.Presentation.Controllers
{
    public class ContasController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    

        public IActionResult Consulta()
        {
        return View();
        }

    public IActionResult Edicao()
        {
        return View();
        }

   }
}
