using CoxinhaGestaoSRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestao
{
    public class CalculoCoxinha
    {
        public int GetCoxinha(Funcionario funcionario)
        {
            return funcionario.TipoFuncionario.RegraCalculo.Calcula(funcionario);
        }


    }
}
