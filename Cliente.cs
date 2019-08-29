using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Endereco { get; set; }

        public bool Maioridade(int idade)
        {
            if (this.Idade >= 18)
            {
                return true;
            }
            return false;
            //se apresentar acompanhado de responsável legal
        }
    }
}
