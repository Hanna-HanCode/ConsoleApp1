using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace ConsoleApp1.Testes
{
    internal class Estruturas_de_repeticao
    {
        public static void Executar()
        {

            //while
            int numero = 0;
            //enquanto o numero for menor que o valor de 10 ele vai apresentar o valor do numero e incrementar mais 1
            while (numero < 10)
            {
                Console.WriteLine(numero);
                numero++;
            }
            //for
            //o for é uma estrutura de repetição que tem 3 partes: inicialização, condição e incremento
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //DO (while)

            //o do while é uma estrutura de repetição que executa o bloco de código pelo menos uma vez antes de verificar a condição
            int numero2 = 0;
            do
            {
                Console.WriteLine(numero2);
                numero2++;
            } while (numero2 < 10);

        }
    }
}
