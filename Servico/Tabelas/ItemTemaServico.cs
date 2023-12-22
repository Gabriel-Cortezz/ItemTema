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
        public IQueryable<ItemTema> ObterItemTemasClassificadosPorNome()
        {
            return itemTemaDAL.ObterItemTemasClassificadosPorNome();
        }
    }
}
