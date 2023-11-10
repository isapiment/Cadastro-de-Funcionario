using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_atividade
{
    public partial class CadastroFun : Form
    {
        public CadastroFun()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_nome.Text = "";
            tx_datanas.Text = "";
            tx_cpf.Text = "";
            tx_rg.Text = "";
            tx_email.Text = "";
            tx_estcivil.Text = "";
            tx_funcao.Text = "";
            tx_salario.Text = "";
            tx_tel.Text = "";
            tx_end.Text = "";
            tx_est.Text = "";
            tx_cidade.Text = "";
            tx_bairro.Text = "";
            tx_numero.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario(tx_nome.Text,Convert.ToDateTime( tx_datanas), tx_cpf.Text, tx_rg.Text, tx_email.Text, tx_tel.Text,tx_estcivil.Text, tx_funcao.Text, Convert.ToDouble( tx_salario), tx_est.Text, tx_cidade.Text);
            var resul = Validacao.ValidaCpf(tx_cpf.Text);

            MessageBox.Show(tx_nome.Text);
            MessageBox.Show(tx_datanas.Text);
            MessageBox.Show(resul.ToString());
            MessageBox.Show(tx_rg.Text);
            MessageBox.Show(tx_email.Text);
            MessageBox.Show(tx_tel.Text);
            MessageBox.Show(tx_estcivil.Text);
            MessageBox.Show(tx_funcao.Text);
            MessageBox.Show(tx_salario.Text);
            MessageBox.Show(tx_end.Text);
            MessageBox.Show(tx_bairro.Text);
            MessageBox.Show(tx_numero.Text);
            MessageBox.Show(tx_cidade.Text);
            MessageBox.Show(tx_est.Text);
        }
    }
}
