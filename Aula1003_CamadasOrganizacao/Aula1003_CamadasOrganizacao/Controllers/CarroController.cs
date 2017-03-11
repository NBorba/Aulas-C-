using Aula1003_CamadasOrganizacao.Models;

namespace Aula1003_CamadasOrganizacao.Controllers
{
    public class CarroController
    {
        public bool SalvarCarro(Carro c)
        {
            if (string.IsNullOrEmpty(c.Nome))
            {
                return false;
            }
            else if (c.Ano <= 0) {
                return false;
            }
            else
            {
                // salvar objeto no banco
                return true;
            }
        }
    }
}
