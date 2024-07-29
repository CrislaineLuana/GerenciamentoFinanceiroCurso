using GerenciamentoFinanceiroCurso.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GerenciamentoFinanceiroCurso.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
