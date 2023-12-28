using Persistencia.Dal.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aluguel_de_tema.Controllers
{
    public class ItemTemaController : Controller
    {
        private ItemTemaServico itemTemaServico = new ItemTemaServico();
        // GET: ItemTema
        public ActionResult Index()
        {
            var items = itemTemaDAL.TodosOsItensTemas();
            return View(items);
        }

    }
}