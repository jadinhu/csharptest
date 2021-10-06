/**
 * Lambda.cs
 * Created by: Jadson Almeida [jadson.sistemas@gmail.com]
 * Created on: 15/09/2021 (dd/mm/yy)
 * Revised on: 15/09/2021 (dd/mm/yy)
 */
using System;

/// <summary>
/// Classe responsável por testes sobre o uso de Lambda, Action e Func
/// </summary>
public class Lambda
{
    static void Main(string[] args)
    {
        /// <summary>
        /// Action é uma função delegada que pode ou ñ receber parâmetros, mas não possui retorno.
        /// Essa Action imprime um texto com os parâmetros int e string, onde {0:G} é o parâmetro de índice 0 e do tipo Geral.
        /// e o {1:D} é o parâmetro de índice 1 e do tipo Inteiro Decimal
        /// </summary>
        Action<int, string> funcaoSemRetorno = (int idade, string nome) => Console.Write("Meu nome é {0:G} e tenho {1:D} anos.", nome, idade);
        funcaoSemRetorno(35, "Jadson");

        /// <summary>
        /// Atribui um novo comportamento para a Action funcaoSemRetorno. Aqui o Lambda é construído com chaves.
        /// </summary>
        funcaoSemRetorno = (int idade, string nome) =>
        {
            Console.Write("Os dados informados são: \nNome: {0:G}\nIdade: {1:D}", nome, idade);
        };

        Console.Write("\n--------------\nDigite sua idade e seu nome.\n");
        funcaoSemRetorno(int.Parse(Console.ReadLine()), Console.ReadLine());

        /// <summary>
        /// Func é uma função delegada que pode ou não receber parâmetros e sempre tem retorno. 
        /// A assinatura tem sempre um tipo a mais informado, além dos parâmetros, que é justamente o tipo do retorno
        /// Nessa Func os 2 int são os parâmetros um e dois, e string é o retorno dessa Func, que não precisa da keyword return.
        /// </summary>
        Func<int,int, string> quadrado = (x, y) => "X * Y é " + x * y;

        Console.Write("\n-----------\n{0:G}", quadrado(8, 3));
    }
}
