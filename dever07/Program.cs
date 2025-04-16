class Program
{
    static void Main()
    {
        
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());  

        
        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());  

       
        if (numero1 == numero2)
        {
            Console.WriteLine("Os dois números são iguais.");
        }
        else
        {
            Console.WriteLine("Os dois números são diferentes.");
        }
    }
}