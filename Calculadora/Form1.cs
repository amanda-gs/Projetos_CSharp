using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double valor = 0;
        string operacao = "";
        bool botao_pressionado = false;
        public Calculadora()
        {
            InitializeComponent();
            tb_resultado.SelectionStart = 0;
         
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if ((tb_resultado.Text == "0")||(botao_pressionado))
            {
                tb_resultado.Clear();
            }
            botao_pressionado = false;
            Button b = (Button)sender;  
            tb_resultado.Text += b.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tb_resultado.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operacao = b.Text;
            valor = Double.Parse(tb_resultado.Text);
            botao_pressionado=true;
            equacao.Text = valor + " " + operacao;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operacao)
            {
                case "+":
                    tb_resultado.Text = (valor + Double.Parse(tb_resultado.Text)).ToString();
                    break;
                case "/":
                    tb_resultado.Text = (valor / Double.Parse(tb_resultado.Text)).ToString();
                    break;
                case "-":
                    tb_resultado.Text = (valor - Double.Parse(tb_resultado.Text)).ToString();
                    break;
                case "*":
                    tb_resultado.Text = (valor * Double.Parse(tb_resultado.Text)).ToString();
                    break;
                default:
                    break;
            }
            botao_pressionado = false;
            equacao.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tb_resultado.Text = "0";
            valor = 0;
        }

        private void tb_resultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
