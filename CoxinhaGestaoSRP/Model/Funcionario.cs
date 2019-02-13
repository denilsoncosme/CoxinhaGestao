using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestaoSRP.Model
{
    public class Funcionario
    { 
        public TipoFuncionario TipoFuncionario { get; set; }
        public string Nome { get; set; }
        public DateTime Aniversario { get; set; }


        public Funcionario(string nome , TipoFuncionario tipoFuncionario, DateTime aniversario)
        {
            this.Nome = nome;
            this.TipoFuncionario = tipoFuncionario;
            this.Aniversario = aniversario;
        }

    }
}
