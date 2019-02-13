using CoxinhaGestaoSRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestaoSRP.Calculo
{
    public class CalculoExterno : IRegraCalculo
    {

        public int Calcula(Funcionario funcionario)
        {
            if (DateTime.Now.Day >= 10)
            {
                return 100;
            }

            return 0;
        }
    }
}
