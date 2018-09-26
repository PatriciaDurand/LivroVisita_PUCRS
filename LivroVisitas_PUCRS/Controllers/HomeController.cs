using Microsoft.AspNetCore.Mvc;
using LivroVisitas.BLL;
using System.Linq;

namespace LivroVisitas_PUCRS.Controllers
{
    public class HomeController : Controller
    {
        // 
        // GET: /Home/

        public ActionResult Index()
        {
            VisitaFachada fachada = new VisitaFachada();
            var list = fachada.getVisitas();

            return View(list);
        }

    }
}
