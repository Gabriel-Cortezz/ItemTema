using Modelo.Tabelas;
using Persistencia.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Dal.Tabelas
{
    public class ItemTemaDAL
    {
        private EFContext context;

        public ItemTemaDAL()
        {
            this.context = new EFContext();
        }

        public List<ItemTema> TodosOsItensTemas()
        {
            return context.itemTemas.OrderBy(c => c.nome).ToList();
        }

        public ItemTema ItemTemaPorID(long? id)
        {
            return context.itemTemas.FirstOrDefault(i => i.ItemTemaId == id);
        }

        public void AdicionarItemTema(ItemTema itemTema)
        {
            context.itemTemas.Add(itemTema);
            context.SaveChanges();
        }

        public void AtualizarItemTema(ItemTema itemTema)
        {
            context.Entry(itemTema).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletarItemTema(long? id)
        {
            ItemTema itemTema = context.itemTemas.Find(id);
            context.itemTemas.Remove(itemTema);
            context.SaveChanges();
        }
    }
}
