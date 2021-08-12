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
    public partial class formCadastro : Form
    {
        public formCadastro()
        {
            InitializeComponent();
        }

        Contato cont = new Contato();
        Controle_contato controle = new Controle_contato();

        private void limpar()
        {
            txtCod.Clear();
            txtNome.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtNome.Focus();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text=="")
            {
                MessageBox.Show("não é permitido cadastro sem um nome!");
            }
            else
            {
                cont.Nome = txtNome.Text;
                cont.Celular = txtCelular.Text;
                cont.Email = txtEmail.Text;
                

                MessageBox.Show(controle.cadastrar(cont));
                limpar();

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            
            cont.Codcontato = Convert.ToInt32(txtCod.Text);
            cont.Nome = txtNome.Text;
            cont.Celular = txtCelular.Text;
            cont.Email = txtEmail.Text;

            MessageBox.Show(controle.alterar(cont));
            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            cont.Codcontato = Convert.ToInt32(txtCod.Text);
            cont.Nome = txtNome.Text;
            cont.Celular = txtCelular.Text;
            cont.Email = txtEmail.Text;

            MessageBox.Show(controle.excluir(cont));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                cont = controle.busca(int.Parse(txtCod.Text));
                if (cont is null)
                {
                    MessageBox.Show("registro não encontrado!");
                    limpar();
                }
                else
                {
                    txtCod.Text = cont.Codcontato.ToString();
                    txtNome.Text = cont.Nome;
                    txtCelular.Text = cont.Celular;
                    txtEmail.Text = cont.Email;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
