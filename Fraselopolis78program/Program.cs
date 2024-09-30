using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<string> frases = new HashSet<string>();
        string frase;

        Console.WriteLine("Introduce frases (deja la línea vacía para terminar):");

        while (true)
        {
            frase = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(frase))
            {
                break; // Termina si la entrada es vacía
            }

            // Verifica si la frase ya fue introducida
            if (frases.Contains(frase))
            {
                Console.WriteLine("Esta frase ya fue introducida anteriormente.");
            }
            else
            {
                Console.WriteLine("Frase nueva registrada.");
                frases.Add(frase); // Agrega la nueva frase al conjunto
            }
        }

        Console.WriteLine("Fin del programa.");
    }
}
