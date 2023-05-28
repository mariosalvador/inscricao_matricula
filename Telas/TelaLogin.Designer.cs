
namespace Inscricao_e_Matricula
{
    partial class TelaLogin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnentrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnmini = new Guna.UI2.WinForms.Guna2Button();
            this.btnrestore_max = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.txtsenha = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnome = new Guna.UI2.WinForms.Guna2TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 538);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = global::Inscricao_e_Matricula.Properties.Resources._1684060439009;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 166);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(425, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(423, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(540, 489);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Todos os direitos reservados ao IPIL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(470, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Senha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(469, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(682, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Esqueceu a senha?";
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.White;
            this.btnentrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnentrar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnentrar.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnentrar.Location = new System.Drawing.Point(474, 354);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(307, 51);
            this.btnentrar.TabIndex = 3;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.btnmini);
            this.panel2.Controls.Add(this.btnrestore_max);
            this.panel2.Controls.Add(this.btnclose);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 31);
            this.panel2.TabIndex = 1;
            // 
            // btnmini
            // 
            this.btnmini.CheckedState.Parent = this.btnmini;
            this.btnmini.CustomImages.Parent = this.btnmini;
            this.btnmini.FillColor = System.Drawing.Color.Transparent;
            this.btnmini.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnmini.ForeColor = System.Drawing.Color.White;
            this.btnmini.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnmini.HoverState.Parent = this.btnmini;
            this.btnmini.Image = global::Inscricao_e_Matricula.Properties.Resources.window_minimize_icon_138009;
            this.btnmini.Location = new System.Drawing.Point(734, 0);
            this.btnmini.Name = "btnmini";
            this.btnmini.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnmini.ShadowDecoration.Parent = this.btnmini;
            this.btnmini.Size = new System.Drawing.Size(35, 31);
            this.btnmini.TabIndex = 11;
            this.btnmini.Click += new System.EventHandler(this.btnmini_Click);
            // 
            // btnrestore_max
            // 
            this.btnrestore_max.CheckedState.Parent = this.btnrestore_max;
            this.btnrestore_max.CustomImages.Parent = this.btnrestore_max;
            this.btnrestore_max.FillColor = System.Drawing.Color.Transparent;
            this.btnrestore_max.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnrestore_max.ForeColor = System.Drawing.Color.White;
            this.btnrestore_max.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnrestore_max.HoverState.Parent = this.btnrestore_max;
            this.btnrestore_max.Image = global::Inscricao_e_Matricula.Properties.Resources.window_restore_icon_137011;
            this.btnrestore_max.Location = new System.Drawing.Point(769, 0);
            this.btnrestore_max.Name = "btnrestore_max";
            this.btnrestore_max.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnrestore_max.ShadowDecoration.Parent = this.btnrestore_max;
            this.btnrestore_max.Size = new System.Drawing.Size(35, 31);
            this.btnrestore_max.TabIndex = 11;
            this.btnrestore_max.Click += new System.EventHandler(this.btnrestore_max_Click);
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
            this.btnclose.Location = new System.Drawing.Point(804, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(35, 31);
            this.btnclose.TabIndex = 11;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // txtsenha
            // 
            this.txtsenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsenha.DefaultText = "";
            this.txtsenha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsenha.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsenha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha.DisabledState.Parent = this.txtsenha;
            this.txtsenha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsenha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsenha.FocusedState.Parent = this.txtsenha;
            this.txtsenha.ForeColor = System.Drawing.Color.Black;
            this.txtsenha.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtsenha.HoverState.Parent = this.txtsenha;
            this.txtsenha.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.padlock_1;
            this.txtsenha.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtsenha.Location = new System.Drawing.Point(474, 239);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.PasswordChar = '*';
            this.txtsenha.PlaceholderText = "Informe a sua senha";
            this.txtsenha.SelectedText = "";
            this.txtsenha.ShadowDecoration.Parent = this.txtsenha;
            this.txtsenha.Size = new System.Drawing.Size(307, 51);
            this.txtsenha.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtsenha.TabIndex = 2;
            this.txtsenha.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // txtnome
            // 
            this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome.DefaultText = "";
            this.txtnome.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.DisabledState.Parent = this.txtnome;
            this.txtnome.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnome.FocusedState.Parent = this.txtnome;
            this.txtnome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.ForeColor = System.Drawing.Color.Black;
            this.txtnome.HoverState.BorderColor = System.Drawing.Color.Silver;
            this.txtnome.HoverState.Parent = this.txtnome;
            this.txtnome.IconLeft = global::Inscricao_e_Matricula.Properties.Resources.user_1;
            this.txtnome.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtnome.Location = new System.Drawing.Point(474, 147);
            this.txtnome.Margin = new System.Windows.Forms.Padding(6);
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.PlaceholderText = "Informe o seu nome";
            this.txtnome.SelectedText = "";
            this.txtnome.ShadowDecoration.Parent = this.txtnome;
            this.txtnome.Size = new System.Drawing.Size(307, 51);
            this.txtnome.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtnome.TabIndex = 1;
            this.txtnome.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(838, 544);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnentrar;
        private Guna.UI2.WinForms.Guna2TextBox txtnome;
        private Guna.UI2.WinForms.Guna2TextBox txtsenha;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnmini;
        private Guna.UI2.WinForms.Guna2Button btnrestore_max;
        private System.Windows.Forms.Timer timer1;
    }
}

