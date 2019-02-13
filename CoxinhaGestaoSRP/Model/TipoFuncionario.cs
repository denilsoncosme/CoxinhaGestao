using CoxinhaGestaoSRP.Calculo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestaoSRP.Model
{
    public abstract class TipoFuncionario
    {
        public IRegraCalculo RegraCalculo { get; set; }

        public TipoFuncionario(IRegraCalculo regraCalculo)
        {
            this.RegraCalculo = regraCalculo;
        }

 
    }
}
