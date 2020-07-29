using System;
using System.Collections.Generic;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            var complemento = new Complemento()
            {
                Id = 1,
                Descricao = "Teclado",
                Valor = 100
            };

            var produto = new Computador(1);
            produto.Descricao = "Dell";
            produto.Valor = 2000;
            produto.Complementos.Add(complemento);

            Console.ReadKey();
        }
    }
}
