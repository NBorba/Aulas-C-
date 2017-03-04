using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0303_Conceitos
{
    class Barco : MeioTransporte, IMotorizado
    {
        public int QtdPes { get; set; }

        void IMotorizado.Acelerar()
        {
            Console.WriteLine("Barco: acelerando...");
        }

        void IMotorizado.Freiar()
        {
            Console.WriteLine("Barco: Freiando...");
        }
    }
}
