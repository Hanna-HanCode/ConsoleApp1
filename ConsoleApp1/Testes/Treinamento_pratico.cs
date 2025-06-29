using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Testes
{
    internal class Treinamento_pratico
    {
        public static void Executar()
        {
            Console.WriteLine("Digite qual tabuada você quer ver:");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
    }
}
