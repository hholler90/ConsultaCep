using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFConsultaCep
{
    public partial class Form2 : Form
    {   public string Endereco
        {
            get {return txtEndereco.Text;}
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            try
            {
                //criando uma variavel do ws dos correios
                var webServise = new WSCorreios.AtendeClienteClient();
                //executando o metodo que consulta o cep
                //parametro:string cep
                var res = webServise.consultaCEP(txtCep.Text);


                txtEndereco.Text = res.end;
                txtBairro.Text = res.bairro;
                txtComplemento.Text = res.complemento2;
                txtCidade.Text = res.cidade;
                txtEstado.Text = res.uf;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO");
            }
        }
    }    
}
