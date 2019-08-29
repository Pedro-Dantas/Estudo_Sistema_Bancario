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
            Cliente clientePedro = new Cliente()
            {
                Nome = "Pedro",
                Idade = 33,
                Rg = "7777777777777"
            };

            contaPedro.Deposita(300.0f);
            contaPedro.Saca(110.10f);
            MessageBox.Show(clientePedro.Nome); 
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
