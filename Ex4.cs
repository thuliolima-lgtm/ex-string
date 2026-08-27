using System;

class Ex4
{
    static void Main()
{
        string resposta = "SIM";
        string normalizada = resposta.ToLower();

        Console.WriteLine(normalizada);

        if (normalizada == "sim")
         Console.WriteLine("Resposta confirmada");



    }
}