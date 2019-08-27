using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //instanciação da classe conta 
            Conta contaPedro = new Conta();
            contaPedro.Titular = "pedro";
            contaPedro.Numero = 1;
            contaPedro.Saldo = 1000;

            Conta contaEduardo = new Conta();
            contaEduardo.Titular = "eduardo";
            contaEduardo.Numero = 2;
            contaEduardo.Saldo = 500;

            contaPedro.Saldo += 200.0f;
            contaEduardo.Saldo -= 300.0f;

            MessageBox.Show("Pedro = " + contaPedro.Saldo.ToString());
            MessageBox.Show("Eduardo = " + contaEduardo.Saldo.ToString());

            /*contaPedro.Deposita(700.0f);
            MessageBox.Show("A depósito foi de: " + contaPedro.Saldo.ToString());
            contaPedro.Saca(50.0f);
            MessageBox.Show("Saldo" + contaPedro.Saldo.ToString());*/


            /*bool deuCerto = contaPedro.Saca(500.0f);

            if (deuCerto)
            {
                MessageBox.Show("Saque realizado com sucesso: " + contaPedro.Saldo.ToString());
            }
            else
            {
                MessageBox.Show("Saldo insuficiente");
            }*/

        }
    }
}
