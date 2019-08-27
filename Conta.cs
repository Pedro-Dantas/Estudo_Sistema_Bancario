using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
     
    public class Conta
    {
        //atributos
        public float Saldo { get; set; }
        public int Numero { get; set; }
        public string Titular { get; set; }

        //Comportamento da classe ou métodos
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
