using CoxinhaGestao.Model;
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
            if (funcionario.TipoFuncionario is CLT)
            {
                return CaiuSalEfetivo(funcionario);
            }
            else if (funcionario.TipoFuncionario is Estagiario)
            {
                return CaiuSalExperiencia(funcionario);
            }
            else if (funcionario.TipoFuncionario is Consultor)
            {
                return CaiuSalExterno(funcionario);
            }
            
            return -1;
        }

        private int CaiuSalEfetivo(Funcionario funcionario)
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

        private int CaiuSalExperiencia(Funcionario funcionario)
        {
            if (DateTime.Now.Day >= 5)
            {
                return 50;
            }

            return 0;
        }


        private int CaiuSalExterno(Funcionario funcionario)
        {
            if (DateTime.Now.Day >= 10)
            {
                return 100;
            }

            return 0;
        }

    }
}
