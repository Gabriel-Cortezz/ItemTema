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
        private EFContext context = new EFContext();

        public IQueryable<ItemTema> ObterItemTemasClassificadosPorNome()
        {
            return context.itemTemas.OrderBy(b => b.nome);
        }

        public ItemTema ObterItemTemaPorId(long id)
        {
            return context.itemTemas.Where(p => p.ItemTemaId == id).Include(f => f.ItemTemaId).First();
        }

        public void GravarProduto(ItemTema itemTema)
        {
            if (itemTema.ItemTemaId == null)
            {
                context.itemTemas.Add(itemTema);
            }
            else
            {
                context.Entry(itemTema).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
        public ItemTema EliminarProdutoPorId(long id)
        {
            ItemTema itemTema = ObterItemTemaPorId(id);
            context.itemTemas.Remove(itemTema);
            context.SaveChanges();
            return itemTema;
        }
    }
}
