using System;
using System.Globalization;

namespace ConsoleApp1.Testes
{
    public static class quiz_de_perguntas
    {
        public static void Executar()
        {
            int pontuacao = 0;

            Console.WriteLine("Quanto é 5+5?\nEscreva sua resposta abaixo:");
            int resposta_1 = Convert.ToInt32(Console.ReadLine());
            if (resposta_1 == 10)
            {
                Console.WriteLine("Você acertou!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("Quanto é 10-2?\nEscreva sua resposta abaixo:");
            int resposta_2 = Convert.ToInt32(Console.ReadLine());
            if (resposta_2 == 8)
            {
                Console.WriteLine("Você acertou!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("Qual a lingua oficial do Brasil?\nEscreva sua resposta abaixo:");
            string resposta_3 = Console.ReadLine();
            if (resposta_3 == "portugues")
            {
                Console.WriteLine("Você acertou!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("Qual é a capital do brasil?\nEscreva sua resposta abaixo:");
            string resposta_4 = Console.ReadLine();
            if (resposta_4 == "brasilia")
            {
                Console.WriteLine("Você acertou!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }
            Console.WriteLine("Quanto é 12.5 + 2?\nEscreva sua resposta abaixo:");

            float resposta_5 = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (resposta_5 == 14.5f)
            {
                Console.WriteLine("Você acertou!");
                pontuacao++;
            }
            else
            {
                Console.WriteLine("Você errou!");
            }

            Console.WriteLine("O seu total de pontos é:\n" + pontuacao);
        }
    }
}