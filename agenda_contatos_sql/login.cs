using MaterialSkin;
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
    
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        Conexao c = new Conexao();
        public login()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Green500, Primary.Green600,
                Primary.Blue500, Accent.Green200,
                TextShade.BLACK
            );
        }

        private void mbEntrar_Click(object sender, EventArgs e)
        {
            

            if (BoxSenha.Text.Length >= 8)
            {
                var form1 = new FormMain();
                form1.Show();
            } 
            else
            {
                MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                BoxSenha.Clear();
                BoxUser.Clear();
                c.desconectar();
            }
        }

       
    }
}
