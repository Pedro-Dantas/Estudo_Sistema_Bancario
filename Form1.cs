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
            Cliente clientePedro = new Cliente();
            //contaPedro.Titular = clientePedro; o construtor na classe Conta resolve essa linha
            contaPedro.Titular.Nome = "Pedro Dantas";
            contaPedro.Saldo = 1000;    
            contaPedro.Deposita(300.0f);
            contaPedro.Saca(110.10f);
            MessageBox.Show(contaPedro.Titular.Nome +" tem um saldo de: "+ contaPedro.Saldo); 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
