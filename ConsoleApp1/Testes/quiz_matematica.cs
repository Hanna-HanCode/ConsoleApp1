using System;

namespace ConsoleApp1.Testes
{
    public static class quiz_matematica
    {
        public static void Executar()
        {
            Console.WriteLine("Quanto é 2+2?");
            int numero_1 = Convert.ToInt32(Console.ReadLine());
            int pergunta_1 = 4;

            if (numero_1 == pergunta_1)
            {
                Console.WriteLine("Você acertou");
            }
            else
            {
                Console.WriteLine("Você errou");
            }
            Console.WriteLine("Quanto é 5+5?");
            int numero_2 = Convert.ToInt32(Console.ReadLine());
            int pergunta_2 = 10;

            if (numero_2 == pergunta_2)
            {
                Console.WriteLine("Você acertou");
            }
            else
            {
                Console.WriteLine("Você errou");
            }
            int pontos = 0;
            if (numero_1 == pergunta_1)
            {
                pontos++;
            }
            if (numero_2 == pergunta_2)
            {
                pontos++;
            }
            Console.WriteLine($"Você fez {pontos} ponto(s)");
        }
    }
}
