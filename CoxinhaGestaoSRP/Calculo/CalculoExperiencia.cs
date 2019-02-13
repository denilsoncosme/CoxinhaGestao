using CoxinhaGestaoSRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestaoSRP.Calculo
{
    public class CalculoExperiencia : IRegraCalculo
    {


        public int Calcula(Funcionario funcionario)
        {
            if (DateTime.Now.Day >= 5)
            {
                return 50;
            }

            return 0;
        }
    }
}
