using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoxinhaGestaoSRP.Calculo;

namespace CoxinhaGestaoSRP.Model
{
    public class Estagiario : TipoFuncionario
    {
        public Estagiario(IRegraCalculo regraCalculo) : base(regraCalculo)
        {
        }
    }
}
