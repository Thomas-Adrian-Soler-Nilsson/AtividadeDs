using System.Globalization;

namespace Atividade2Ds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Funcionario x, y;
            x = new Funcionario();
            y = new Funcionario();

            Console.WriteLine("Digite o nome do primeiro funcionario:");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do primeiro funcionario:");
            x.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome do segundo funcionario:");
            y.Nome = Console.ReadLine();
            Console.WriteLine("Digite o salario do segundo funcionario:");
            y.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           double media = (x.Salario + y.Salario) / 2.0;
            Console.WriteLine($"Salario medio = {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
