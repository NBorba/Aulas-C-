using Model.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IContexto
    {
        void CadastrarCategorias(Contexto contexto);
        void CadastrarProdutos(Contexto contexto);
        void CadastrarMercados(Contexto contexto);
    }
}
