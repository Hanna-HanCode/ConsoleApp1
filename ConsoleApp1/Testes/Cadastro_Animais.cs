using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Testes
{

    //Classe abstrata
    abstract class Animal
    {
        public string Nome;
        public int Idade;

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public abstract string EmitirSom();

        public virtual string ExibirInfo()
        {
            return $"Nome: {Nome}, Idade: {Idade}";

        }
    }
        class Cachorro : Animal {
            public Cachorro(string nome, int idade) : base(nome, idade) { }

            public override string EmitirSom()
            {
                return "Au au!";
            }
            public override string ExibirInfo()
            {
                return base.ExibirInfo() + "\nEsse animal é um cachorro.";
            }
        }
        class Gato : Animal
        {
            public Gato(string nome, int idade) : base(nome, idade) { }

            public override string EmitirSom()
            {
                return "Miau!";
            }
            public override string ExibirInfo()
            {
                return base.ExibirInfo() + "\nEsse animal é um gato.";
            }
        }
    internal class Cadastro_Animais
    {
        public static void Executar()
        {
            Cachorro cachorro = new Cachorro("Rex", 2);
            Gato gato = new Gato("Clébinho", 5);

            Console.WriteLine(cachorro.ExibirInfo());
            Console.WriteLine(cachorro.EmitirSom());
            Console.WriteLine();
            Console.WriteLine(gato.ExibirInfo());
            Console.WriteLine(gato.EmitirSom());
        }
    }
}
