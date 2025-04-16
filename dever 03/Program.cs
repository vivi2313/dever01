class Program
{
    static void Main()
    {
        Console.WriteLine("Digite sua idade:");

        string entrada = Console.ReadLine();

       
        bool numero = true;

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