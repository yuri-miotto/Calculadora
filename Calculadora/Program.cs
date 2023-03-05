using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double num1, num2;
        int opcao = 0;

        void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("3 - Multiplicar");
            Console.WriteLine("4 - Dividir");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {             

                case 1:
                    Somar();
                    Console.ReadLine();
                    break;

                case 2:
                    Subtrair();
                    Console.ReadLine();
                    break;

                case 3:
                    Multiplicar();
                    Console.ReadLine();
                    break;

                case 4:
                    Dividir();
                    Console.ReadLine();
                    break;

                case 5:
                    Console.WriteLine("Até logo!");
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;
            }
        }

        Console.WriteLine("Informe o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        while (opcao != 5)
        {
            Menu();
        }

        void Somar()
        {
            double resultado = num1 + num2;
            Console.WriteLine("A soma dos números é igual a: " + resultado);
        }

        void Subtrair()
        {
            double resultado = num1 - num2;
            Console.WriteLine("A subtração dos números é igual a: " + resultado);
        }

        void Multiplicar()
        {
            double resultado = num1 * num2;
            Console.WriteLine("A multiplicação dos números é igual a: " + resultado);
        }

        void Dividir()
        {
            if (num2 == 0)
            {
                Console.WriteLine("Não é possível dividir por zero!");
            }
            else
            {
                double resultado = num1 / num2;
                Console.WriteLine("A divisão dos números é igual a: " + resultado);
            }
        }
    }
}