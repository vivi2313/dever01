class Program
{
    static void Main()
    {
        // Solicita ao usuário para digitar um número
        Console.WriteLine("Digite um número:");

        // Lê a entrada do usuário
        string entrada = Console.ReadLine();

        // Converte a entrada para inteiro
        int numero = Convert.ToInt32(entrada);

        // Verifica se o número é par ou ímpar
        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par.");
        }
        else
        {
            Console.WriteLine("O número é ímpar.");
        }
    }
}