using CoxinhaGestaoSRP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestaoSRP.Calculo
{
    public class CalculoEfetivo : IRegraCalculo
    {
        public int Calcula(Funcionario funcionario)
        {
            bool mesAnivers = funcionario.Aniversario.Month == DateTime.Now.Month;
            if (DateTime.Now.Day >= 5)
            {
                if (mesAnivers)
                    return 150;
                return 100;
            }

            return 0;
        }
    }
}
