using Persistencia.Dal.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Servico.Tabelas;
using System.Net;
using Modelo.Tabelas;

namespace Aluguel_de_tema.Controllers
{
    public class ItemTemaController : Controller
    {
        private ItemTemaServico ItemTemaServico = new ItemTemaServico();
        // GET: ItemTema
        public ActionResult Index()
        {
            var items = ItemTemaServico.TodosOsItensTemas();
            return View(items);
        }
        // GET: ItemTemas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemTema item = ItemTemaServico.ItemTemaPorID(id);

            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: ItemTemas/Create
        public ActionResult Create()
        {
            ViewBag.TemaId = new SelectList(ItemTemaServico.TodosOsItensTemas().OrderBy(b => b.nome));
            return View();
        }

        // POST: ItemTemas/Create
        [HttpPost]
        public ActionResult Create(ItemTema item)
        {
            try
            {
                ItemTemaServico.AdicionarItemTema(item);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(item);
            }
        }

        // GET: ItemTemas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemTema item = ItemTemaServico.ItemTemaPorID(id);

            if (item == null)
            {
                return HttpNotFound();
            }

            ViewBag.TemaId = new SelectList(ItemTemaServico.TodosOsItensTemas().OrderBy(b => b.nome));
            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(ItemTema item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ItemTemaServico.AtualizarItemTema(item);
                    return RedirectToAction("Index");
                }
                return View(item);
            }
            catch
            {
                return View(item);
            }
        }

        // GET: ItemTemas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ItemTema item = ItemTemaServico.ItemTemaPorID(id);

            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: ItemTemas/Delete/5
        [HttpPost]
        public ActionResult Delete(long id)
        {
            try
            {
                ItemTemaServico.DeletarItemTema(id);
                TempData["Message"] = "O Item foi excluido com sucesso!!";
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}