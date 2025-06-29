using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Testes
{
    internal class Treinamento_pratico1
    {
        public static void Executar()
        {
            Console.WriteLine("Digite 3 notas que você tirou:");
            int [] notas = new int[3];
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine($"Digite a nota {i + 1}:");
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }
            int soma = 0;
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }
            double media = soma / (double)notas.Length;
            media = Math.Round(media, 2); // Arredondar a média para 2 casas decimais
            Console.WriteLine($"A média das notas é: {media}");
            if (media >= 7)
            {
                Console.WriteLine("Você foi aprovado!");
            }
            else if (media >= 5)
            {
                Console.WriteLine("Você está de recuperação.");
            }
            else
            {
                Console.WriteLine("Você foi reprovado.");
            }
        }   
    }
}
