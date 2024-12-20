using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        //;EX 01:
        /*  
           Considere a função "countWords()" cujo objetivo é realizar a contagem da quantidade de vezes que cada palavra ocorre em uma determinada frase/texto.
            Dada a assinatura da função conforme ilustrado na imagem mais abaixo, descreva o código que seria necessário para que ela funcionasse corretamente.   

           Obs: a assinatura da função foi escrita em Golang, no entanto você é livre para implementar utilizando a linguagem de sua preferência. 
           Por gentileza, nos informe qual foi a linguagem utilizada.

           Exemplo:
            Entrada
            t = "O PismoEmpodera é uma iniciativa Pismo, focada em desenvolvimento e em inclusão.
            PismoEmpodera, resultante de uma parceria entre Pismo e ProsperTech Talents, reforça nossa dedicação em Diversidade & Inclusão."
           */
        string t = "O PismoEmpodera é uma iniciativa Pismo, o focada em desenvolvimento e em inclusão! PismoEmpodera, resultante de uma parceria entre Pismo e ProsperTech Talents, reforça nossa dedicação em Diversidade & Inclusão.";
        //string b = " O rato roeu o queijo do Rei, mas o Rato sabia aonde o queijo estava no quarto sdo rei longe de ratos";
        var result = CountWords(t);

        foreach (var item in result.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key.ToLower()} = {item.Value}");
        }
        //EX 01 ----^

        //;EX 02:
        /* 
        Considere a função "removeWords()" cujo objetivo é remover de um array de strings todos itens cujo tamanho supere o indicado por um dado parâmetro,
        retornando um array apenas com as strings restantes. Dada a assinatura da função conforme ilustrado na imagem mais abaixo,
        escreva o código que seria necessário para que ela funcionasse corretamente.

        Obs: a assinatura da função foi escrita em Golang, no entanto você é livre para implementar utilizando a linguagem de sua preferência. 

        Entrada
        t = ["O", "PismoEmpodera", "é", "uma", "iniciativa", "Pismo", "focada", "em", "desenvolvimento", 
        "e", "em", "inclusão", "PismoEmpodera", "resultante", "de", "uma", "parceria", "entre", "Pismo", "e", "ProsperTech", 
        "Talents", "reforça", "nossa", "dedicação", "em", "Diversidade", "Inclusão"]
        minLength = 3
         */

        string[] x = {
            "O", "PismoEmpodera", "é", "uma", "iniciativa", "Pismo", "focada", "em",
            "desenvolvimento", "e", "em", "inclusão", "PismoEmpodera", "resultante",
            "de", "uma", "parceria", "entre", "Pismo", "e", "ProsperTech", "Talents",
            "reforça", "nossa", "dedicação", "em", "Diversidade", "Inclusão"
        };
        int minLength = 3;

        var result2 = RemoveWords(x, minLength);

        Console.WriteLine($"Resultado: [{string.Join(", ", result2)}]");
        // EX 02 ----^
    }//----------------------

    #region Exercise 01
    public static Dictionary<string, int> CountWords(string t)
    {
        var wordCount = new Dictionary<string, int>();

        var words = t.ToLower().Split(new[] { ' ', ',', '.', '&', ';', ':', '!' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in words)
        {
            if (wordCount.ContainsKey(word))
            {
                wordCount[word]++;
            }
            else
            {
                wordCount[word] = 1;
            }
        }

        return wordCount;
    }
    #endregion

    #region Exercise 02
    static string[] RemoveWords(string[] words, int minLength)
    {
        //  LINQ para filtrar as palavras
        var filteredWords = words.Where(word => word.Length <= minLength).ToArray();

        return filteredWords;
    }
    #endregion Exercise 02---^

}