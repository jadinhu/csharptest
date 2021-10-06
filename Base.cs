/**
 * Base.cs
 * Created by: Jadson Almeida [jadson.sistemas@gmail.com]
 * Created on: 06/10/2021 (dd/mm/yy)
 */
using System;

/// <summary>
/// Shows how use the keyword base
/// </summary>
public class Base
{
    class Jogador
    {
        public Jogador() { }
        public Jogador(string nome)
        {
            Console.WriteLine($"o nome dele é {nome}");
        }
    }

    class Messi : Jogador
    {
        public Messi(string nome)
        {
            Console.WriteLine($"{nome} é o melhor");
        }
    }

    class Ronaldo : Jogador
    {
        public Ronaldo(string nome) : base(nome)
        {
            Console.WriteLine($"e {nome} o melhor de todos!");
        }
    }

    public class Test
    {
        public static void Main()
        {
            new Jogador("Pelé");
            Console.WriteLine("--------");
            new Messi("Messi");
            Console.WriteLine("--------");
            new Ronaldo("Ronaldo");
        }
    }
}