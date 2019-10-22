using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace DepartamentoPessoal
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; private set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return (Salario - Imposto);
        }

        public void AlmentoDeSalario(double salario)
        {
            if (Salario == default) Salario = salario;
            else Salario = Salario + (Salario * salario / 100.0);
        }
        public override string ToString()
        {
            return Nome
                + ", R$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
