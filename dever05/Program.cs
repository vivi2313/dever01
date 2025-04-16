class Program
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine()); 

        
        if (numero % 3 == 0)
        {
            Console.WriteLine("O número digitado é múltiplo de 3.");
        }
        else
        {
            Console.WriteLine("O número digitado não é múltiplo de 3.");
        }
    }
}