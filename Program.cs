using System;

class InversorDeString
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string entrada = Console.ReadLine();

        char[] arrayDeCaracteres = entrada.ToCharArray();
        int esquerda = 0;
        int direita = arrayDeCaracteres.Length - 1;

        while (esquerda < direita)
        {
            char temp = arrayDeCaracteres[esquerda];
            arrayDeCaracteres[esquerda] = arrayDeCaracteres[direita];
            arrayDeCaracteres[direita] = temp;
            esquerda++;
            direita--;
        }

        string invertida = new string(arrayDeCaracteres);

        Console.WriteLine("String invertida: " + invertida);
    }
}