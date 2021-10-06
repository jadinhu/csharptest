/**
 * Override.cs
 * Created by: Jadson Almeida [jadson.sistemas@gmail.com]
 * Created on: 06/10/2021 (dd/mm/yy)
 */
using System;

/// <summary>
/// Shows how use override and polymorphism
/// </summary>
public class Override
{
    /// <summary>
    /// If <see cref="Jogador.Atacar"/> doesn't have virtual keyword, it can't be "overrided"
    /// </summary>
    class Jogador
    {
        public virtual void Atacar()
        {
            Console.WriteLine("Jogador ataca.");
        }
    }

    /// <summary>
    /// Messi use override
    /// </summary>
    class Messi : Jogador
    {
        public override void Atacar()
        {
            base.Atacar();
            Console.WriteLine("É o Messi!");
        }
    }

    /// <summary>
    /// Ronaldo doesn't use override
    /// </summary>
    class Ronaldo : Jogador
    {
        public void Atacar()
        {
            base.Atacar();
            Console.WriteLine("E é o melhor de todos, o Ronaldo!!");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Jogador[] jogadores = new Jogador[] { new Jogador(), new Messi(), new Ronaldo() };
            foreach(var j in jogadores)
            {
                j.Atacar();
            }
        }
    }
}