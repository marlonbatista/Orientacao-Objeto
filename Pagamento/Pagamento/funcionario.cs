using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pagamento
{
    class funcionario
    {
        //Declaração de Atributos
        public String Nome;
        public Char Sexo;
        public int nrodependentes;
        public double salariobase;
        public double salariofamilia;



        //Métodos
        public void calcularsalariofamilia()
        {
            this.salariofamilia = this.salariobase * 0.05 * this.nrodependentes;
            
        }
    }
}
