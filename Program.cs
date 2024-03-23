using System;

class Program
{
    static void Main()
    {
        // String a ser invertida
        string texto = "Exemplo";

        // Chama a função para inverter a string
        string textoInvertido = InverterString(texto);

        // Imprime a string invertida
        Console.WriteLine("String original: " + texto);
        Console.WriteLine("String invertida: " + textoInvertido);
    }

    // Função para inverter a string
    static string InverterString(string str)
    {
        // Converte a string para um array de caracteres
        char[] caracteres = str.ToCharArray();

        // Obtém o comprimento da string
        int comprimento = str.Length;

        // Percorre metade do array de caracteres
        for (int i = 0; i < comprimento / 2; i++)
        {
            // Troca o caractere na posição i pelo caractere na posição comprimento - 1 - i
            char temp = caracteres[i];
            caracteres[i] = caracteres[comprimento - 1 - i];
            caracteres[comprimento - 1 - i] = temp;
        }

        // Retorna a string invertida
        return new string(caracteres);
    }
}
