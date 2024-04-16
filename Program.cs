using System.Collections.Generic;
using System.Globalization;

namespace GestaoDeSalarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão cadastrados? ");
            int n = int.Parse(Console.ReadLine());
            List<Funcionario> funcs = new List<Funcionario>();
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Funcionário #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcs.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Insira o ID do funcionário que vai ter um aumento no salário: ");
            int idEncontrado = int.Parse(Console.ReadLine());
            Funcionario func = funcs.Find(x => x.Id == idEncontrado);

            if (func != null)
            {
                Console.Write("Insira a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                func.aumentarSalario(porcentagem);
            } else
            {
                Console.WriteLine("Esse ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionários atualizada:");
            foreach (Funcionario emp in funcs)
            {
                Console.WriteLine(emp);
            }

        }
    }
}
