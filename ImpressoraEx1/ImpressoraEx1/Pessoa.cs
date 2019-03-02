using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpressoraEx1
{
    class Pessoa
    {
        //Atributos da Classe

        public String nome;
        public String telefone;
        public String end;

        
        //Método
        public String Imprimir()
            
        {
            String Mensagem = "\nNome :" + this.nome +
                              "\nTelefone :" + this.telefone +
                              "\nEndereço :" + this.end;
            return Mensagem;
        }
    }
}
