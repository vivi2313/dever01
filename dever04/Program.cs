class Program
{
    static void Main()
    {
        
        Console.Write("Digite uma letra: ");
        char letra = Console.ReadKey().KeyChar; 

        Console.WriteLine(); 

        
        if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u' ||
            letra == 'A' || letra == 'E' || letra == 'I' || letra == 'O' || letra == 'U')
        {
            Console.WriteLine("A letra digitada é uma vogal.");
        }
        else
        {
            Console.WriteLine("A letra digitada não é uma vogal.");
        }
    }
}
