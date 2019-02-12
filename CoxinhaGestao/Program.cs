using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoxinhaGestao.Model;

namespace CoxinhaGestao
{
    class Program
    {
        static void Main(string[] args)
        {

            CalculoCoxinha calculoCoxinha = new CalculoCoxinha();

            Funcionario funcionario = new Funcionario("Nathalia", new CLT(), 5, new DateTime(1994,02,03));

            Console.WriteLine(funcionario.Nome + " - " + calculoCoxinha.GetCoxinha(funcionario));

            funcionario = new Funcionario("Leonardo", new Estagiario(), 5, new DateTime(1999, 10, 22));

            Console.WriteLine(funcionario.Nome + " - " + calculoCoxinha.GetCoxinha(funcionario));

            funcionario = new Funcionario("Lúcio", new CLT(), 10, new DateTime(1992, 09, 01));


            Console.WriteLine(funcionario.Nome + " - " + calculoCoxinha.GetCoxinha(funcionario));

            Console.ReadKey();

        }
    }
}
