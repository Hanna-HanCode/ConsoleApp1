using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Testes
{
    public class Treinamento_Array1
    {
        public static void Executar()
        {
            int[] numeros = new int[5];
            Array.Sort(numeros);
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Digite um número:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Qual número você quer procurar?");
            int procurarNumero = Convert.ToInt32(Console.ReadLine());
            if (numeros.Contains(procurarNumero))
            {
                Console.WriteLine($"O número {procurarNumero} foi encontrado no array.");
                Console.WriteLine("Este número está na posição: " + Array.IndexOf(numeros, procurarNumero));
            }
            else
            {
                Console.WriteLine($"O número {procurarNumero} não foi encontrado no array.");
            }
        }
    }
}
