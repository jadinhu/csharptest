/**
 * WithoutOverride.cs
 * Created by: Jadson Almeida [jadson.sistemas@gmail.com]
 * Created on: 06/10/2021 (dd/mm/yy)
 */
using System;

/// <summary>
/// Shows how reuse methods without the keyword override
/// </summary>
public class WithoutOverride
{
    class Jogador
    {
        public void Atacar()
        {
            Console.WriteLine("jogador ataca.");
        }
    }

    class Messi : Jogador
    {
        public void Atacar()
        {
            base.Atacar();
            Console.WriteLine("é o messi!");
        }
    }

    public class Test
    {
        public static void Main()
        {
            Jogador j = new Jogador();
            j.Atacar();
            Console.WriteLine("---------");
            Messi m = new Messi();
            m.Atacar();
            Console.WriteLine("---------");
            Jogador mj = new Messi();
            mj.Atacar();
        }
    }
}