using System.Globalization;

namespace AtividadeDs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;
            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Digite o nome da primeira pessoa:");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da primeira pessoa:");
            x.Idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome da segunda pessoa:");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite a idade da segunda pessoa:");
            y.Idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(x.Idade > y.Idade){
                Console.WriteLine($"{x.Nome} é mais velho");
            }
            else
            {
                Console.WriteLine($"{y.Nome} é mais velho");
            }

        }
    }
}
