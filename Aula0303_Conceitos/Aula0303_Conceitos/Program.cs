using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Aula0303_Conceitos.Util;

namespace Aula0303_Conceitos
{
    class Program
    {
        static void Main(string[] args)
        {
           TipoMeioTransporte tipo = (Util.TipoMeioTransporte)Menu();

            switch (tipo)
            {
                case Util.TipoMeioTransporte.Carro:
                    Carro C = new Carro("Fusca");
                    C.Ano = 1978;
                    C.Capacidade = 4;
                    C.Acelerar();
                    C.Freiar();
                    C.Parar();
                    break;
                case Util.TipoMeioTransporte.Bicicleta:
                    Bicicleta B = new Bicicleta();
                    B.Nome = "Caloi";
                    B.Ano = 2016;
                    B.Capacidade = 1;
                    B.QtdMarcha = 21;
                    B.Parar();
                    break;
                case Util.TipoMeioTransporte.Barco:
                    Barco Ba = new Barco();
                    Ba.Ano = 1979;
                    Ba.Nome = "Titanic";
                    Ba.QtdPes = 50;
                    Ba.Capacidade = 2000;
                    ((IMotorizado)Ba).Acelerar();
                    ((IMotorizado)Ba).Freiar();
                    Ba.Parar();
                    break;
                default:
                    Console.WriteLine("Este item não existe! Toque em qualquer tecla para fechar o programa!");
                    break;
            }

            Console.ReadKey();
                      
        }
    }
}
