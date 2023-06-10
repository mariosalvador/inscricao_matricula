
namespace Inscricao_e_Matricula
{
    partial class Tela_CadastraEntidade
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_funcao_cadastra = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtsenha_cadastra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnome_cadastra = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btncancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 571);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Inscricao_e_Matricula.Properties.Resources._1684060439009;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 232);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "CADASTRAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(481, 128);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 23);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome de Usuário";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(481, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(481, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Função";
            // 
            // cb_funcao_cadastra
            // 
            this.cb_funcao_cadastra.BackColor = System.Drawing.Color.Transparent;
            this.cb_funcao_cadastra.BorderRadius = 10;
            this.cb_funcao_cadastra.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_funcao_cadastra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_funcao_cadastra.FocusedColor = System.Drawing.Color.Empty;
            this.cb_funcao_cadastra.FocusedState.Parent = this.cb_funcao_cadastra;
            this.cb_funcao_cadastra.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.cb_funcao_cadastra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_funcao_cadastra.FormattingEnabled = true;
            this.cb_funcao_cadastra.HoverState.Parent = this.cb_funcao_cadastra;
            this.cb_funcao_cadastra.ItemHeight = 30;
            this.cb_funcao_cadastra.Items.AddRange(new object[] {
            "Validador",
            "Catalogador",
            "Admin"});
            this.cb_funcao_cadastra.ItemsAppearance.Parent = this.cb_funcao_cadastra;
            this.cb_funcao_cadastra.Location = new System.Drawing.Point(475, 250);
            this.cb_funcao_cadastra.Name = "cb_funcao_cadastra";
            this.cb_funcao_cadastra.ShadowDecoration.Parent = this.cb_funcao_cadastra;
            this.cb_funcao_cadastra.Size = new System.Drawing.Size(308, 36);
            this.cb_funcao_cadastra.TabIndex = 2;
            // 
            // txtsenha_cadastra
            // 
            this.txtsenha_cadastra.BorderRadius = 15;
            this.txtsenha_cadastra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha_cadastra.DefaultText = "";
            this.txtsenha_cadastra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsenha_cadastra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsenha_cadastra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha_cadastra.DisabledState.Parent = this.txtsenha_cadastra;
            this.txtsenha_cadastra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha_cadastra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha_cadastra.FocusedState.Parent = this.txtsenha_cadastra;
            this.txtsenha_cadastra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha_cadastra.HoverState.Parent = this.txtsenha_cadastra;
            this.txtsenha_cadastra.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.padlock_1;
            this.txtsenha_cadastra.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtsenha_cadastra.Location = new System.Drawing.Point(475, 336);
            this.txtsenha_cadastra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsenha_cadastra.Name = "txtsenha_cadastra";
            this.txtsenha_cadastra.PasswordChar = '\0';
            this.txtsenha_cadastra.PlaceholderText = "Informe a senha para o Usuário";
            this.txtsenha_cadastra.SelectedText = "";
            this.txtsenha_cadastra.ShadowDecoration.Parent = this.txtsenha_cadastra;
            this.txtsenha_cadastra.Size = new System.Drawing.Size(308, 51);
            this.txtsenha_cadastra.TabIndex = 3;
            this.txtsenha_cadastra.TextOffset = new System.Drawing.Point(10, 0);
            this.txtsenha_cadastra.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // txtnome_cadastra
            // 
            this.txtnome_cadastra.BorderRadius = 15;
            this.txtnome_cadastra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome_cadastra.DefaultText = "";
            this.txtnome_cadastra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnome_cadastra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnome_cadastra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome_cadastra.DisabledState.Parent = this.txtnome_cadastra;
            this.txtnome_cadastra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome_cadastra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome_cadastra.FocusedState.Parent = this.txtnome_cadastra;
            this.txtnome_cadastra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome_cadastra.HoverState.Parent = this.txtnome_cadastra;
            this.txtnome_cadastra.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.user_1;
            this.txtnome_cadastra.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtnome_cadastra.Location = new System.Drawing.Point(475, 151);
            this.txtnome_cadastra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnome_cadastra.Name = "txtnome_cadastra";
            this.txtnome_cadastra.PasswordChar = '\0';
            this.txtnome_cadastra.PlaceholderText = "Informe o Nome de Usuário ";
            this.txtnome_cadastra.SelectedText = "";
            this.txtnome_cadastra.ShadowDecoration.Parent = this.txtnome_cadastra;
            this.txtnome_cadastra.Size = new System.Drawing.Size(308, 51);
            this.txtnome_cadastra.TabIndex = 1;
            this.txtnome_cadastra.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 15;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(475, 436);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(124, 48);
            this.guna2Button1.TabIndex = 4;
            this.guna2Button1.Text = "CRIAR";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BorderRadius = 15;
            this.btncancelar.CheckedState.Parent = this.btncancelar;
            this.btncancelar.CustomImages.Parent = this.btncancelar;
            this.btncancelar.FillColor = System.Drawing.Color.White;
            this.btncancelar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btncancelar.HoverState.Parent = this.btncancelar;
            this.btncancelar.Location = new System.Drawing.Point(659, 436);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.ShadowDecoration.Parent = this.btncancelar;
            this.btncancelar.Size = new System.Drawing.Size(124, 48);
            this.btncancelar.TabIndex = 5;
            this.btncancelar.Text = "CANCELAR";
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnclose
            // 
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Image = global::Inscricao_e_Matricula.Properties.Resources.window_close_icon_135015;
            this.btnclose.Location = new System.Drawing.Point(802, 1);
            this.btnclose.Name = "btnclose";
            this.btnclose.PressedColor = System.Drawing.Color.DarkOrange;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(35, 31);
            this.btnclose.TabIndex = 16;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Tela_CadastraEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(838, 544);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.cb_funcao_cadastra);
            this.Controls.Add(this.txtsenha_cadastra);
            this.Controls.Add(this.txtnome_cadastra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tela_CadastraEntidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela_CadastraEntidade";
            this.Load += new System.EventHandler(this.Tela_CadastraEntidade_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtnome_cadastra;
        private Guna.UI2.WinForms.Guna2TextBox txtsenha_cadastra;
        private Guna.UI2.WinForms.Guna2ComboBox cb_funcao_cadastra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btncancelar;
        private Guna.UI2.WinForms.Guna2Button btnclose;
    }
}