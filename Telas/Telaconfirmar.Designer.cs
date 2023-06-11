namespace Inscricao_e_Matricula.Telas
{
    partial class Telaconfirmar
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_confirmar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Inscricao_e_Matricula.Properties.Resources._;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(712, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Inscricao_e_Matricula.Properties.Resources.Ellipse_9;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 133);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 136);
            this.label1.MaximumSize = new System.Drawing.Size(500, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 0);
            this.label1.TabIndex = 2;
            this.label1.Text = "Foi enviado um código de confirmação ao seu e-mail para aplicar as alterações";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtcodigo
            // 
            this.txtcodigo.BorderColor = System.Drawing.Color.DarkOrange;
            this.txtcodigo.BorderRadius = 15;
            this.txtcodigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcodigo.DefaultText = "";
            this.txtcodigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcodigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcodigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.DisabledState.Parent = this.txtcodigo;
            this.txtcodigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcodigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtcodigo.FocusedState.Parent = this.txtcodigo;
            this.txtcodigo.FocusedState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.txtcodigo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.ForeColor = System.Drawing.Color.Black;
            this.txtcodigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcodigo.HoverState.Parent = this.txtcodigo;
            this.txtcodigo.Location = new System.Drawing.Point(126, 197);
            this.txtcodigo.Modified = true;
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.PasswordChar = '\0';
            this.txtcodigo.PlaceholderText = "Insira o código";
            this.txtcodigo.SelectedText = "";
            this.txtcodigo.ShadowDecoration.Parent = this.txtcodigo;
            this.txtcodigo.Size = new System.Drawing.Size(472, 48);
            this.txtcodigo.TabIndex = 3;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Foi enviado um código de confirmação ao seu e-mail para aplicar as alterações";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BorderRadius = 15;
            this.btn_confirmar.CheckedState.Parent = this.btn_confirmar;
            this.btn_confirmar.CustomImages.Parent = this.btn_confirmar;
            this.btn_confirmar.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_confirmar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.HoverState.Parent = this.btn_confirmar;
            this.btn_confirmar.Location = new System.Drawing.Point(164, 278);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.ShadowDecoration.Parent = this.btn_confirmar;
            this.btn_confirmar.Size = new System.Drawing.Size(180, 45);
            this.btn_confirmar.TabIndex = 6;
            this.btn_confirmar.Text = "Confirmar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BorderColor = System.Drawing.Color.DarkOrange;
            this.btn_cancelar.BorderRadius = 15;
            this.btn_cancelar.BorderThickness = 1;
            this.btn_cancelar.CheckedState.Parent = this.btn_cancelar;
            this.btn_cancelar.CustomImages.Parent = this.btn_cancelar;
            this.btn_cancelar.FillColor = System.Drawing.Color.White;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Black;
            this.btn_cancelar.HoverState.Parent = this.btn_cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(374, 278);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.ShadowDecoration.Parent = this.btn_cancelar;
            this.btn_cancelar.Size = new System.Drawing.Size(180, 45);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Telaconfirmar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 362);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Telaconfirmar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telaconfirmar";
            this.Load += new System.EventHandler(this.Telaconfirmar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtcodigo;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_confirmar;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}