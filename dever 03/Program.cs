class Program
{
    static void Main()
    {
        // Solicita ao usuário para digitar sua idade
        Console.WriteLine("Digite sua idade:");

        // Lê a entrada do usuário como string
        string entrada = Console.ReadLine();

        // Ver se a entrada é um número válido
        bool numero = true;

        // Ver se a entrada é composta apenas por números
        foreach (char c in entrada)
        {
            if (!Char.IsDigit(c))
            {
                numero = false;
                break;
            }
        }

       
        if (numero)
        {
            int idade = Convert.ToInt32(entrada);

            // Ver se a pessoa pode votar (idade maior ou igual a 16 anos)
            if (idade >= 16)
            {
                Console.WriteLine("Vc pode votar.");
            }
            else
            {
                Console.WriteLine("Vc n pode votar.");
            }
        }
        
    }
}