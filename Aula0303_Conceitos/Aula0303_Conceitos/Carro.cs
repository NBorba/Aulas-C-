using System;

namespace Aula0303_Conceitos
{
    class Carro : MeioTransporte, IMotorizado
    {
        public Carro(string nome)
        {
            this.Nome = nome;
        }

        public void Acelerar()
        {
            Console.WriteLine("Carro: acelerando...");
        }

        public void Freiar()
        {
            Console.WriteLine("Carro: freiando...");
        }

        // Possibilita a reescrita de um método já existente na classe mãe
        public override void Parar() {

            // Chama a implementação da classe pai
            base.Parar();

            Console.WriteLine("Carro: parando...");
        }
    }
}
