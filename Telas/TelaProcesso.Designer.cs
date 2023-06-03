namespace Inscricao_e_Matricula.Telas
{
    partial class TelaProcesso
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
            this.progress = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.lbval = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progress
            // 
            this.progress.AnimationSpeed = 85;
            this.progress.AutoStart = true;
            this.progress.CircleSize = 1F;
            this.progress.Location = new System.Drawing.Point(118, 23);
            this.progress.Name = "progress";
            this.progress.ProgressColor = System.Drawing.Color.DarkOrange;
            this.progress.Size = new System.Drawing.Size(169, 169);
            this.progress.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 100;
            this.guna2Elipse1.TargetControl = this;
            // 
            // lbval
            // 
            this.lbval.BackColor = System.Drawing.Color.Transparent;
            this.lbval.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbval.ForeColor = System.Drawing.Color.Black;
            this.lbval.Location = new System.Drawing.Point(-1, 200);
            this.lbval.Name = "lbval";
            this.lbval.Size = new System.Drawing.Size(407, 23);
            this.lbval.TabIndex = 1;
            this.lbval.Text = "Validando dados...";
            this.lbval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelaProcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(406, 260);
            this.Controls.Add(this.lbval);
            this.Controls.Add(this.progress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaProcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaProcesso";
            this.Load += new System.EventHandler(this.TelaProcesso_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressIndicator progress;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lbval;
    }
}