using System.Globalization;

namespace Atividade3Ds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            // Entrada para o primeiro usuário (Pessoa X)
            Console.WriteLine("Entre com os dados da pessoa X");
            Console.Write("Altura: ");
            x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Sexo (homem/mulher): ");
            x.Sexo = Console.ReadLine();

            // Entrada para o segundo usuário (Pessoa Y)
            Console.WriteLine("Entre com os dados da pessoa Y");
            Console.Write("Altura: ");
            y.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Sexo (homem/mulher): ");
            y.Sexo = Console.ReadLine();

            // Cálculo do peso ideal
            double pesoX = x.PesoIdeal();
            double pesoY = y.PesoIdeal();

            // Exibição dos resultados
            Console.WriteLine($"Peso ideal de X = {pesoX:F2} kg");
            Console.WriteLine($"Peso ideal de Y = {pesoY:F2} kg");

            // Comparação entre os pesos ideais
            if (pesoX > pesoY)
            {
                Console.WriteLine("Maior peso ideal: X");
            }
            else if (pesoY > pesoX)
            {
                Console.WriteLine("Maior peso ideal: Y");
            }
            else
            {
                Console.WriteLine("Os pesos ideais são iguais.");
            }
        }
    }
}
