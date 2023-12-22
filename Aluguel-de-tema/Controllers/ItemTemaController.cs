using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aluguel_de_tema.Controllers
{
    public class ItemTemaController : Controller
    {
        private  itemTemaServico itemTemaServico = new itemTemaServico();
        // GET: ItemTema
        public ActionResult Index()
        {
            return View();
        }
    }
}