using Easy_Control.Models;
using Easy_Control.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Easy_Control.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public HomeController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult CriarUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CriarUsuario(UsuarioModel usuario)
        {
             _usuarioRepositorio.Adicionar(usuario);
            return RedirectToAction("Index");
        }
    }
}