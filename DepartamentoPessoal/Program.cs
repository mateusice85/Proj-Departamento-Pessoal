using System;
using System.Globalization;

namespace DepartamentoPessoal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Funcionario p = new Funcionario();
                Console.WriteLine("Digite os dados do Funcionario");
                Console.Write("Nome: ");
                p.Nome = Console.ReadLine();
                Console.Write("Salário Bruto: ");
                p.AlmentoDeSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                Console.Write("Imposto: ");
                p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine();
                Console.WriteLine("Funcionário: " + p);

                Console.WriteLine();
                Console.Write("Deseja almentar o salario: ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "SIM")
                {
                    Console.WriteLine();
                    Console.Write("Quantos % deseja aumentar: ");
                    p.AlmentoDeSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));
                }   

                Console.WriteLine();
                Console.WriteLine("Funcionário: " + p);

            }
            catch (Exception ex)
            {
                Console.WriteLine("O valor digitado não é válido, tente novamente !");
            }

            Console.WriteLine();
            Console.WriteLine("FIM !!!");

        }
    }
}
