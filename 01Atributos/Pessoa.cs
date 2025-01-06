using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Atributos
{
    class Pessoa
    {
        public int idade;
        public string nome;

        public void mensagem()
        {
            Console.WriteLine("Olá {0}, tudo bom, sua idade é {1}", nome, idade);
        }

    }
}
