class Program
{
    static void Main()
    {
        // Solicita ao usuário para digitar um número
        Console.WriteLine("Digite um número:");

        // Lê a entrada do usuário como string
        string entrada = Console.ReadLine();

        // Tenta converter a entrada diretamente para um número inteiro
        int numero = Convert.ToInt32(entrada);

        // Verifica se o número é positivo
        if (numero > 0)
        {
            Console.WriteLine("O número é positivo.");
        }
        else if (numero < 0)
        {
            Console.WriteLine("O número é negativo.");
        }
        else
        {
            Console.WriteLine("O número é zero.");
        }
    }
}