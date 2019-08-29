using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public class Conta
    {
        //propriedade get é ler e set é escrever, por si só e um metodo que acessa informação da classe
        public float Saldo { get; set; }
        public int Numero { get; set; }
        /*o menbro campo titular guarda uma referência(seta) para uma instância de Cliente 
        (objeto na	memória).*/
        public Cliente Titular { get; set; }

        //construtor
        public Conta()
        {
            Titular = new Cliente();
        }

        //Comportamento da classe / métodos
        public bool Saca(float valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                return true;
            }
            return false;
        }
        public void Deposita(float valor)
        {
            this.Saldo += valor;
        }

        public void Transfere(float valor, Conta destino)
        {
            if (this.Saca(valor))
            {
                destino.Deposita(valor);
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
