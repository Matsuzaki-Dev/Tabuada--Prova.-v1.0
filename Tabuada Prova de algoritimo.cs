using System;

class Program
{
    static void Main()
    {
        // Definindo o número para o qual queremos gerar a tabuada
        int numero = 7;

        // Laço para iterar de 1 a 10 e exibir a tabuada
        for (int i = 1; i <= 10; i++)
        {
            // Calculando o resultado da multiplicação
            int resultado = numero * i;
            
            // Exibindo a multiplicação no formato "numero x i = resultado"
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }
    }
}
