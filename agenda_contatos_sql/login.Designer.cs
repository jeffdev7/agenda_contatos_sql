
namespace agenda_contatos_sql
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.BoxUser = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.BoxSenha = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.mbEntrar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // BoxUser
            // 
            this.BoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxUser.Depth = 0;
            this.BoxUser.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxUser.LeadingIcon = null;
            this.BoxUser.Location = new System.Drawing.Point(125, 140);
            this.BoxUser.MaxLength = 50;
            this.BoxUser.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxUser.Multiline = false;
            this.BoxUser.Name = "BoxUser";
            this.BoxUser.Size = new System.Drawing.Size(210, 50);
            this.BoxUser.TabIndex = 1;
            this.BoxUser.Text = "";
            this.BoxUser.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(197, 96);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(55, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Usuário";
            // 
            // BoxSenha
            // 
            this.BoxSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BoxSenha.Depth = 0;
            this.BoxSenha.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxSenha.LeadingIcon = null;
            this.BoxSenha.Location = new System.Drawing.Point(125, 269);
            this.BoxSenha.MaxLength = 50;
            this.BoxSenha.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxSenha.Multiline = false;
            this.BoxSenha.Name = "BoxSenha";
            this.BoxSenha.Password = true;
            this.BoxSenha.Size = new System.Drawing.Size(210, 50);
            this.BoxSenha.TabIndex = 3;
            this.BoxSenha.Text = "";
            this.BoxSenha.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(197, 216);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Senha";
            // 
            // mbEntrar
            // 
            this.mbEntrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mbEntrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.mbEntrar.Depth = 0;
            this.mbEntrar.HighEmphasis = true;
            this.mbEntrar.Icon = null;
            this.mbEntrar.Location = new System.Drawing.Point(295, 360);
            this.mbEntrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mbEntrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.mbEntrar.Name = "mbEntrar";
            this.mbEntrar.Size = new System.Drawing.Size(77, 36);
            this.mbEntrar.TabIndex = 5;
            this.mbEntrar.Text = "Entrar";
            this.mbEntrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mbEntrar.UseAccentColor = false;
            this.mbEntrar.UseVisualStyleBackColor = true;
            this.mbEntrar.Click += new System.EventHandler(this.mbEntrar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(450, 443);
            this.Controls.Add(this.mbEntrar);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.BoxSenha);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.BoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de Contatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox BoxUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox BoxSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton mbEntrar;
    }
}