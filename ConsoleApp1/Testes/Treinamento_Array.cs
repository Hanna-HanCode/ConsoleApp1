using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Testes
{
     
        public class Treinamento_Array
        {
            public static void Executar()
            {
                {
                    int[] numeros = new int[5];
                    int soma = 0;

                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("Digite um número:");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        soma += numeros[i];
                    }

                    Array.Sort(numeros);

                    Console.WriteLine("A soma dos números é: " + soma);

                    Console.WriteLine("O maior número é: " + numeros[numeros.Length - 1]);
                    Console.WriteLine("O menor número é: " + numeros[0]);
                }
            }
        }
}
