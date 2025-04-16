class Program
{
    static void Main()
    {
        
        string senha = "2313";  

        Console.Write("Digite a senha: ");
        string senhaDigitada = Console.ReadLine();  

        if (senhaDigitada == senha)
        {
            Console.WriteLine("Senha correta!");
        }
        else
        {
            Console.WriteLine("Senha incorreta!");
        }
    }
}