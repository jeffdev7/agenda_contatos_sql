using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace agenda_contatos_sql
{
    public partial class consultas : Form
    {
        Contato cont = new Contato();
        Controle_contato controle = new Controle_contato();



        public consultas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                txtOpcao.Enabled = false;
                btnBuscar.Enabled = false;
                lblopcao.Text = "";
            }
            else
            {
                txtOpcao.Enabled = true;
                lblopcao.Text = "Digite o " + comboBox1.Text;
                txtOpcao.Clear();
                txtOpcao.Focus();
            }
        }



        private void txtOpcao_TextChanged(object sender, EventArgs e)
        {
            if (txtOpcao.Text != "")
            {
                btnBuscar.Enabled = true;
            }
            else
            {
                btnBuscar.Enabled = false;
            }
        }

        private void consultas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    int codigo = Convert.ToInt32(txtOpcao.Text);

                    dataGridView1.DataSource = controle.pesquisaCodigo(codigo);
                }

                catch
                {
                    MessageBox.Show("Digite um valor inteiro para código!", "Erro!",MessageBoxButtons.OK, MessageBoxIcon.Error );
                    txtOpcao.Clear();
                    txtOpcao.Focus();
                }

            } //Usamos o "else if" caso a primeira condição não seja atendida.
             //O valor de index do "nome" na dataGrid é 1, caso seja atendida essa condição, acionamos a classe "controle"
             //junto com o método que criamos nela para pesquisar por nome.
            else if (comboBox1.SelectedIndex == 1)
            {
                string nome = txtOpcao.Text;
                dataGridView1.DataSource = controle.pesquisnome(nome);



            }
            else if (comboBox1.SelectedIndex == 2)
            {
                string celular = txtOpcao.Text;
                dataGridView1.DataSource = controle.pesquisaCelular(celular);
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                string email = txtOpcao.Text;
                dataGridView1.DataSource = controle.pesquisaEmail(email);
               
            }
        }       

        private void btnListar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }
    }
    
}
