/**
 * IEnumerableTest.cs
 * Created by: Jadson Almeida [jadson.sistemas@gmail.com]
 * Created on: 06/10/2021 (dd/mm/yy)
 */
using System;
using System.Linq;
using System.Collections.Generic;

/// <summary>
/// How use <see cref="IEnumerable{T}"/>
/// </summary>
public class IEnumerableTest
{
    /// <summary>
    /// The <see cref="IEnumerable{T}"/> makes "recipe" but not execute immediately. 
    /// The recipe will runs only when used in a loop or when you get a value
    /// So the Marcos will printed because the "recipe" runs when nomes[0] are setted.
    /// </summary>
    private void TesteIEnumerable()
    {
        var nomes = new List<string> { "Luis", "João", "Ricardo", "Alexandre" };
        IEnumerable<string> nomesContenhamLetraO = nomes.Where(x => x.Contains("o"));
        nomes[0] = "Marcos";
        Console.WriteLine("----TesteIEnumerable----");
        foreach (var nome in nomesContenhamLetraO)
        {
            Console.WriteLine(nome);
        }
    }

    /// <summary>
    /// The <see cref="List{T}"/> will run the "recipe" immediately
    /// </summary>
    private void TesteList()
    {
        var nomes = new List<string> { "Luis", "João", "Ricardo", "Alexandre" };
        List<string> nomesContenhamLetraO = nomes.Where(x => x.Contains("o")).ToList();
        nomes[0] = "Marcos";
        Console.WriteLine("----TesteList----");
        foreach (var nome in nomesContenhamLetraO)
        {
            Console.WriteLine(nome);
        }
    }
    
    static void Main(String[] args)
    {
        IEnumerableTest test = new IEnumerableTest();
        test.TesteList();
        test.TesteIEnumerable();
    }
}
