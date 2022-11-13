class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de números:");
        string Input = Console.ReadLine().TrimEnd();
        decimal[] InputInt = Input.Split(",").Select(decimal.Parse).ToArray();

        BuscarLucroMaximo(InputInt);
    }

    public static void BuscarLucroMaximo(decimal[] input)
    {
        int tamanhoInput = input.Length;
        decimal menor = input[0];
        decimal maior = 0;
        decimal lucroMax = 0;
        int diaCompra = 0;
        int diaVenda = 0;
        for (int i = 0; i < tamanhoInput - 1; i++)
        {
            if (menor > input[i])
            {
                menor = input[i];
                diaCompra = i + 1;
            }
            else if (input[i] - menor > lucroMax)
            {
                diaVenda = i + 1;
                maior = input[i];
                lucroMax = input[i] - menor;

            }
        }
        if (lucroMax != 0)
            Console.WriteLine($"{lucroMax} (Comprou no dia {diaCompra} (preço igual a {menor}) e vendeu no dia {diaVenda} (preço igual a {maior}), lucro foi de {maior}-{menor}={lucroMax}");
        else
            Console.WriteLine($"(Nesse caso nenhuma transação deve ser feita, lucro máximo igual a {lucroMax})");
    }
}