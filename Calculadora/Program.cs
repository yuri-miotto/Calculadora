internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        float n1, n2;
        Console.WriteLine("Digite o primeiro número: ");
        n1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        n2 = float.Parse(Console.ReadLine());
        Console.WriteLine("A soma é igual a: " + (n1 + n2));
        Console.WriteLine("A subtração é igual a: " + (n1 - n2));
        if (n2 == 0)
        {
            Console.WriteLine("Ñão é possível dividir por zero!");
        }
        else
        {
            Console.WriteLine("A divisão é igual a: " + n1 / n2);
        }

        Console.WriteLine("A multiplicação é igual a: " + n1 * n2);
        Console.ReadKey();
    }
}