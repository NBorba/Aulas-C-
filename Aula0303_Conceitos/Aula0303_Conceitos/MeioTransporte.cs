using System;

namespace Aula0303_Conceitos
{
    public abstract class MeioTransporte
    {
        public string Nome { get; set; }
        public int Ano { get; set; }
        public int Capacidade { get; set; }


        public virtual void Parar()
        {
            Console.WriteLine("Meio Transporte: Parando...");
        }
    }
}
