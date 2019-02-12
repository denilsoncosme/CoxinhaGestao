using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoxinhaGestao.Model
{
    public class Funcionario
    { 
        public TipoFuncionario TipoFuncionario { get; set; }
        public string Nome { get; set; }
        public int DiaSalario { get; set; }
        public DateTime Aniversario { get; set; }


        public Funcionario(string nome , TipoFuncionario tipoFuncionario, int diaSalario, DateTime aniversario)
        {
            this.Nome = nome;
            this.TipoFuncionario = tipoFuncionario;
            this.DiaSalario = diaSalario;
            this.Aniversario = aniversario;
        }
    }
}
