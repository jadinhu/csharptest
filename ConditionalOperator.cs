using System;
using System.Collections.Generic;

/// <summary>
/// How use conditional operator
/// </summary>
public class Class1
{
    /// <summary>
    /// Generate a random number with 50% chance to prints 0 and 1 or 2 and 3
    /// </summary>
	static void Main(String[] args)
    {
        var rand = new Random();
        var number = rand.NextDouble();
        var condition = number > 0.5;

        int? x = condition ? 12 : null;
        
        Console.WriteLine($"Random Number: {number}. Condition is {condition}. The x is {x}.");

        IEnumerable<int> xs = x is null ? new List<int>() { 0, 1 } : new int[] { 2, 3 };

        foreach (var a in xs)
        {
            Console.WriteLine(a);
        }
    }
}
