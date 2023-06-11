namespace Inscricao_e_Matricula.Telas
{
    partial class Primeira_conta
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
            this.btncriar_conta = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnome = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsenha_1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtsenha_2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkpass = new Guna.UI.WinForms.GunaCheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncriar_conta
            // 
            this.btncriar_conta.BackColor = System.Drawing.Color.Transparent;
            this.btncriar_conta.BorderRadius = 15;
            this.btncriar_conta.CheckedState.Parent = this.btncriar_conta;
            this.btncriar_conta.CustomImages.Parent = this.btncriar_conta;
            this.btncriar_conta.FillColor = System.Drawing.Color.White;
            this.btncriar_conta.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btncriar_conta.ForeColor = System.Drawing.Color.DarkOrange;
            this.btncriar_conta.HoverState.Parent = this.btncriar_conta;
            this.btncriar_conta.Location = new System.Drawing.Point(476, 407);
            this.btncriar_conta.Name = "btncriar_conta";
            this.btncriar_conta.ShadowDecoration.Parent = this.btncriar_conta;
            this.btncriar_conta.Size = new System.Drawing.Size(308, 51);
            this.btncriar_conta.TabIndex = 8;
            this.btncriar_conta.Text = "CRIAR CONTA";
            this.btncriar_conta.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(420, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 53);
            this.label1.TabIndex = 6;
            this.label1.Text = "CRIAR CONTA MASTER";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnome
            // 
            this.txtnome.BorderRadius = 15;
            this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome.DefaultText = "";
            this.txtnome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.DisabledState.Parent = this.txtnome;
            this.txtnome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtnome.FocusedState.Parent = this.txtnome;
            this.txtnome.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome.HoverState.Parent = this.txtnome;
            this.txtnome.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.user_1;
            this.txtnome.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtnome.Location = new System.Drawing.Point(476, 139);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PlaceholderText = "Informe o seu nome";
            this.txtnome.SelectedText = "";
            this.txtnome.ShadowDecoration.Parent = this.txtnome;
            this.txtnome.Size = new System.Drawing.Size(308, 51);
            this.txtnome.TabIndex = 5;
            this.txtnome.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtsenha_1
            // 
            this.txtsenha_1.BorderRadius = 15;
            this.txtsenha_1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha_1.DefaultText = "";
            this.txtsenha_1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsenha_1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsenha_1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha_1.DisabledState.Parent = this.txtsenha_1;
            this.txtsenha_1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha_1.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtsenha_1.FocusedState.Parent = this.txtsenha_1;
            this.txtsenha_1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha_1.HoverState.Parent = this.txtsenha_1;
            this.txtsenha_1.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.padlock_1;
            this.txtsenha_1.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtsenha_1.Location = new System.Drawing.Point(476, 217);
            this.txtsenha_1.Name = "txtsenha_1";
            this.txtsenha_1.PasswordChar = '*';
            this.txtsenha_1.PlaceholderText = "Insira uma senha";
            this.txtsenha_1.SelectedText = "";
            this.txtsenha_1.ShadowDecoration.Parent = this.txtsenha_1;
            this.txtsenha_1.Size = new System.Drawing.Size(308, 51);
            this.txtsenha_1.TabIndex = 7;
            this.txtsenha_1.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 606);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Inscricao_e_Matricula.Properties.Resources._1684060439009;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 205);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtsenha_2
            // 
            this.txtsenha_2.BorderRadius = 15;
            this.txtsenha_2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha_2.DefaultText = "";
            this.txtsenha_2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsenha_2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsenha_2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha_2.DisabledState.Parent = this.txtsenha_2;
            this.txtsenha_2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha_2.FocusedState.BorderColor = System.Drawing.Color.Transparent;
            this.txtsenha_2.FocusedState.Parent = this.txtsenha_2;
            this.txtsenha_2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha_2.HoverState.Parent = this.txtsenha_2;
            this.txtsenha_2.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.padlock_1;
            this.txtsenha_2.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtsenha_2.Location = new System.Drawing.Point(475, 295);
            this.txtsenha_2.Name = "txtsenha_2";
            this.txtsenha_2.PasswordChar = '*';
            this.txtsenha_2.PlaceholderText = "Confirme sua senha";
            this.txtsenha_2.SelectedText = "";
            this.txtsenha_2.ShadowDecoration.Parent = this.txtsenha_2;
            this.txtsenha_2.Size = new System.Drawing.Size(308, 51);
            this.txtsenha_2.TabIndex = 10;
            this.txtsenha_2.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(489, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nome de usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(489, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(422, 516);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Todos os direitos reservados ao IPIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(489, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Confirmar senha";
            // 
            // checkpass
            // 
            this.checkpass.BaseColor = System.Drawing.Color.Gainsboro;
            this.checkpass.CheckedOffColor = System.Drawing.Color.Transparent;
            this.checkpass.CheckedOnColor = System.Drawing.Color.White;
            this.checkpass.FillColor = System.Drawing.Color.DarkOrange;
            this.checkpass.ForeColor = System.Drawing.Color.Black;
            this.checkpass.Location = new System.Drawing.Point(656, 346);
            this.checkpass.Name = "checkpass";
            this.checkpass.Radius = 3;
            this.checkpass.Size = new System.Drawing.Size(127, 20);
            this.checkpass.TabIndex = 15;
            this.checkpass.Text = "Ver palavras-passe";
            this.checkpass.CheckedChanged += new System.EventHandler(this.checkpass_CheckedChanged);
            // 
            // Primeira_conta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(838, 544);
            this.Controls.Add(this.checkpass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsenha_2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btncriar_conta);
            this.Controls.Add(this.txtsenha_1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Primeira_conta";
            this.Text = "Primeira_conta";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtnome;
        private Guna.UI2.WinForms.Guna2Button btncriar_conta;
        private Guna.UI2.WinForms.Guna2TextBox txtsenha_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtsenha_2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaCheckBox checkpass;
    }
}