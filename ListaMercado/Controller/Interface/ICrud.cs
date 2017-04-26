using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Interface
{
    interface ICrud <T>
    {
        void AdicionarItem(T objeto);
        void RemoverItem(T objeto);
        ICollection<T> RetornarTodos();
    }
}
