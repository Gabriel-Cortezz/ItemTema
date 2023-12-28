using Modelo.Tabelas;
using Persistencia.Dal.Tabelas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servico.Tabelas
{
    public class ItemTemaServico
    {
        private ItemTemaDAL itemTemaDAL = new ItemTemaDAL();

        public ItemTemaServico()
        {
            this.itemTemaDAL = new ItemTemaDAL();
        }

        public List<ItemTema> TodosOsItensTemas()
        {
            return itemTemaDAL.TodosOsItensTemas();
        }

        public ItemTema ItemTemaPorID(long? id)
        {
            return itemTemaDAL.ItemTemaPorID(id);
        }

        public void AdicionarItemTema(ItemTema item)
        {
            itemTemaDAL.AdicionarItemTema(item);
        }

        public void AtualizarItemTema(ItemTema item)
        {
            itemTemaDAL.AtualizarItemTema(item);
        }

        public void DeletarItemTema(long? id)
        {
            itemTemaDAL.DeletarItemTema(id);
        }
    }
}
