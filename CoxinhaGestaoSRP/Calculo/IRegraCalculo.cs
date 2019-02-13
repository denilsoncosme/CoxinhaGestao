using CoxinhaGestaoSRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestaoSRP.Calculo
{
    public interface IRegraCalculo
    {
        int Calcula(Funcionario funcionario);
    }
}
