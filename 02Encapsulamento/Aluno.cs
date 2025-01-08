using System;

namespace _02Encapsulamento
{
    class Aluno
    {

        private double n1, n2;

        private double media()
        {
            return (n1 + n2) / 2;
        }

        public void mensagem()
        {
            Console.WriteLine("Digite a primeira nota:");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota:");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Sua media foi de: {0}", media());
        }

    }
}
