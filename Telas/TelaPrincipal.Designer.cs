
namespace Inscricao_e_Matricula
{
    partial class TelaPrincipal
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.label4 = new System.Windows.Forms.Label();
            this.lb_Entidade = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.btnspanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.paneljanela = new System.Windows.Forms.Panel();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnconfig = new Guna.UI2.WinForms.Guna2Button();
            this.btnhelp = new Guna.UI2.WinForms.Guna2Button();
            this.btn_ver = new Guna.UI2.WinForms.Guna2Button();
            this.btnadd = new Guna.UI2.WinForms.Guna2Button();
            this.btnhome = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnclose = new Guna.UI2.WinForms.Guna2Button();
            this.Pic_perfil = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnspanel.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(78, 57);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1130, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "_________________________________________________________________________________" +
    "________________________________________________________________________________" +
    "______________________";
            // 
            // lb_Entidade
            // 
            this.lb_Entidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Entidade.AutoSize = true;
            this.guna2Transition1.SetDecoration(this.lb_Entidade, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lb_Entidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.lb_Entidade.Location = new System.Drawing.Point(876, 37);
            this.lb_Entidade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Entidade.Name = "lb_Entidade";
            this.lb_Entidade.Size = new System.Drawing.Size(98, 26);
            this.lb_Entidade.TabIndex = 10;
            this.lb_Entidade.Text = "Entidade";
            this.lb_Entidade.Click += new System.EventHandler(this.lb_Entidade_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.label13, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label13.Location = new System.Drawing.Point(2, 601);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 15);
            this.label13.TabIndex = 11;
            this.label13.Text = "_____________________________";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label13.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.label13.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // btnspanel
            // 
            this.btnspanel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnspanel.Controls.Add(this.panel9);
            this.btnspanel.Controls.Add(this.label1);
            this.btnspanel.Controls.Add(this.btnconfig);
            this.btnspanel.Controls.Add(this.btnhelp);
            this.btnspanel.Controls.Add(this.btn_ver);
            this.btnspanel.Controls.Add(this.btnadd);
            this.btnspanel.Controls.Add(this.label13);
            this.btnspanel.Controls.Add(this.btnhome);
            this.guna2Transition1.SetDecoration(this.btnspanel, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnspanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnspanel.Location = new System.Drawing.Point(0, 0);
            this.btnspanel.Name = "btnspanel";
            this.btnspanel.ShadowDecoration.Parent = this.btnspanel;
            this.btnspanel.Size = new System.Drawing.Size(74, 699);
            this.btnspanel.TabIndex = 15;
            this.btnspanel.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.btnspanel.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Transition1.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(2, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "_____________________";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 10;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 20;
            this.guna2Elipse7.TargetControl = this;
            // 
            // paneljanela
            // 
            this.paneljanela.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paneljanela.BackColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.paneljanela, Guna.UI2.AnimatorNS.DecorationType.None);
            this.paneljanela.Location = new System.Drawing.Point(74, 73);
            this.paneljanela.Name = "paneljanela";
            this.paneljanela.Size = new System.Drawing.Size(1069, 614);
            this.paneljanela.TabIndex = 23;
            this.paneljanela.Paint += new System.Windows.Forms.PaintEventHandler(this.paneljanela_Paint);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Scale;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.guna2Transition1.DefaultAnimation = animation2;
            this.guna2Transition1.Interval = 1;
            this.guna2Transition1.MaxAnimationTime = 500;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel8.BackgroundImage")));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Controls.Add(this.label14);
            this.guna2Transition1.SetDecoration(this.panel8, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel8.Location = new System.Drawing.Point(815, 39);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(32, 28);
            this.panel8.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Transition1.SetDecoration(this.label14, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label14.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Image = ((System.Drawing.Image)(resources.GetObject("label14.Image")));
            this.label14.Location = new System.Drawing.Point(18, -2);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(13, 17);
            this.label14.TabIndex = 7;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.guna2Transition1.SetDecoration(this.panel9, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel9.Location = new System.Drawing.Point(0, 11);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(74, 49);
            this.panel9.TabIndex = 21;
            // 
            // btnconfig
            // 
            this.btnconfig.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnconfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnconfig.BorderRadius = 10;
            this.btnconfig.CheckedState.Parent = this.btnconfig;
            this.btnconfig.CustomImages.Parent = this.btnconfig;
            this.guna2Transition1.SetDecoration(this.btnconfig, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnconfig.FillColor = System.Drawing.Color.DarkOrange;
            this.btnconfig.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnconfig.ForeColor = System.Drawing.Color.White;
            this.btnconfig.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnconfig.HoverState.Parent = this.btnconfig;
            this.btnconfig.Image = ((System.Drawing.Image)(resources.GetObject("btnconfig.Image")));
            this.btnconfig.ImageSize = new System.Drawing.Size(30, 47);
            this.btnconfig.Location = new System.Drawing.Point(2, 555);
            this.btnconfig.Name = "btnconfig";
            this.btnconfig.PressedColor = System.Drawing.Color.DarkOrange;
            this.btnconfig.ShadowDecoration.Parent = this.btnconfig;
            this.btnconfig.Size = new System.Drawing.Size(70, 48);
            this.btnconfig.TabIndex = 19;
            this.btnconfig.Click += new System.EventHandler(this.btnconfig_Click);
            this.btnconfig.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.btnconfig.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // btnhelp
            // 
            this.btnhelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhelp.BorderRadius = 10;
            this.btnhelp.CheckedState.Parent = this.btnhelp;
            this.btnhelp.CustomImages.Parent = this.btnhelp;
            this.guna2Transition1.SetDecoration(this.btnhelp, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnhelp.FillColor = System.Drawing.Color.DarkOrange;
            this.btnhelp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnhelp.ForeColor = System.Drawing.Color.White;
            this.btnhelp.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnhelp.HoverState.Parent = this.btnhelp;
            this.btnhelp.Image = ((System.Drawing.Image)(resources.GetObject("btnhelp.Image")));
            this.btnhelp.ImageSize = new System.Drawing.Size(30, 47);
            this.btnhelp.Location = new System.Drawing.Point(2, 628);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.PressedColor = System.Drawing.Color.DarkOrange;
            this.btnhelp.ShadowDecoration.Parent = this.btnhelp;
            this.btnhelp.Size = new System.Drawing.Size(70, 48);
            this.btnhelp.TabIndex = 18;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            this.btnhelp.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.btnhelp.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // btn_ver
            // 
            this.btn_ver.Animated = true;
            this.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ver.BorderRadius = 10;
            this.btn_ver.CheckedState.Parent = this.btn_ver;
            this.btn_ver.CustomImages.Parent = this.btn_ver;
            this.guna2Transition1.SetDecoration(this.btn_ver, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btn_ver.FillColor = System.Drawing.Color.DarkOrange;
            this.btn_ver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ver.ForeColor = System.Drawing.Color.White;
            this.btn_ver.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btn_ver.HoverState.Parent = this.btn_ver;
            this.btn_ver.Image = ((System.Drawing.Image)(resources.GetObject("btn_ver.Image")));
            this.btn_ver.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ver.ImageOffset = new System.Drawing.Point(11, 0);
            this.btn_ver.ImageSize = new System.Drawing.Size(30, 47);
            this.btn_ver.Location = new System.Drawing.Point(2, 200);
            this.btn_ver.Name = "btn_ver";
            this.btn_ver.PressedColor = System.Drawing.Color.DarkOrange;
            this.btn_ver.ShadowDecoration.Parent = this.btn_ver;
            this.btn_ver.Size = new System.Drawing.Size(169, 48);
            this.btn_ver.TabIndex = 17;
            this.btn_ver.Text = "Ver";
            this.btn_ver.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_ver.TextOffset = new System.Drawing.Point(25, 0);
            this.btn_ver.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.btn_ver.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // btnadd
            // 
            this.btnadd.Animated = true;
            this.btnadd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnadd.BorderRadius = 10;
            this.btnadd.CheckedState.Parent = this.btnadd;
            this.btnadd.CustomImages.Parent = this.btnadd;
            this.guna2Transition1.SetDecoration(this.btnadd, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnadd.FillColor = System.Drawing.Color.DarkOrange;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.Color.White;
            this.btnadd.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnadd.HoverState.Parent = this.btnadd;
            this.btnadd.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.Image")));
            this.btnadd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnadd.ImageOffset = new System.Drawing.Point(11, 0);
            this.btnadd.ImageSize = new System.Drawing.Size(30, 47);
            this.btnadd.Location = new System.Drawing.Point(2, 280);
            this.btnadd.Name = "btnadd";
            this.btnadd.PressedColor = System.Drawing.Color.DarkOrange;
            this.btnadd.ShadowDecoration.Parent = this.btnadd;
            this.btnadd.Size = new System.Drawing.Size(169, 48);
            this.btnadd.TabIndex = 16;
            this.btnadd.Text = "Operações";
            this.btnadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnadd.TextOffset = new System.Drawing.Point(25, 0);
            this.btnadd.Click += new System.EventHandler(this.guna2Button3_Click);
            this.btnadd.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.btnadd.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // btnhome
            // 
            this.btnhome.Animated = true;
            this.btnhome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnhome.BorderRadius = 10;
            this.btnhome.CheckedState.Parent = this.btnhome;
            this.btnhome.CustomImages.Parent = this.btnhome;
            this.guna2Transition1.SetDecoration(this.btnhome, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnhome.FillColor = System.Drawing.Color.DarkOrange;
            this.btnhome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.ForeColor = System.Drawing.Color.White;
            this.btnhome.HoverState.FillColor = System.Drawing.Color.Orange;
            this.btnhome.HoverState.Parent = this.btnhome;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnhome.ImageOffset = new System.Drawing.Point(11, 0);
            this.btnhome.ImageSize = new System.Drawing.Size(30, 47);
            this.btnhome.Location = new System.Drawing.Point(2, 122);
            this.btnhome.Name = "btnhome";
            this.btnhome.PressedColor = System.Drawing.Color.DarkOrange;
            this.btnhome.ShadowDecoration.Parent = this.btnhome;
            this.btnhome.Size = new System.Drawing.Size(169, 48);
            this.btnhome.TabIndex = 15;
            this.btnhome.Text = "Início";
            this.btnhome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnhome.TextOffset = new System.Drawing.Point(25, 0);
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            this.btnhome.MouseLeave += new System.EventHandler(this.Side_bar_leave);
            this.btnhome.MouseHover += new System.EventHandler(this.Side_bar_hover);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Transition1.SetDecoration(this.guna2Button2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.Location = new System.Drawing.Point(1039, 0);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.PressedColor = System.Drawing.Color.Gainsboro;
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(35, 31);
            this.guna2Button2.TabIndex = 14;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Transition1.SetDecoration(this.guna2Button1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(1074, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Gainsboro;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(35, 31);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnclose
            // 
            this.btnclose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnclose.BackColor = System.Drawing.Color.Transparent;
            this.btnclose.CheckedState.Parent = this.btnclose;
            this.btnclose.CustomImages.Parent = this.btnclose;
            this.guna2Transition1.SetDecoration(this.btnclose, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnclose.FillColor = System.Drawing.Color.Transparent;
            this.btnclose.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.HoverState.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnclose.HoverState.Parent = this.btnclose;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1109, 0);
            this.btnclose.Name = "btnclose";
            this.btnclose.PressedColor = System.Drawing.Color.Gainsboro;
            this.btnclose.ShadowDecoration.Parent = this.btnclose;
            this.btnclose.Size = new System.Drawing.Size(35, 31);
            this.btnclose.TabIndex = 12;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Pic_perfil
            // 
            this.Pic_perfil.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Pic_perfil.BaseColor = System.Drawing.Color.White;
            this.guna2Transition1.SetDecoration(this.Pic_perfil, Guna.UI2.AnimatorNS.DecorationType.None);
            this.Pic_perfil.Image = global::Inscricao_e_Matricula.Properties.Resources._6522516;
            this.Pic_perfil.Location = new System.Drawing.Point(1014, 36);
            this.Pic_perfil.Name = "Pic_perfil";
            this.Pic_perfil.Size = new System.Drawing.Size(35, 33);
            this.Pic_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_perfil.TabIndex = 0;
            this.Pic_perfil.TabStop = false;
            this.Pic_perfil.UseTransfarantBackground = false;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 699);
            this.Controls.Add(this.Pic_perfil);
            this.Controls.Add(this.paneljanela);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.btnspanel);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.lb_Entidade);
            this.Controls.Add(this.label4);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.btnspanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_Entidade;
        private Guna.UI2.WinForms.Guna2Button btnclose;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btnconfig;
        private Guna.UI2.WinForms.Guna2Button btnhelp;
        private Guna.UI2.WinForms.Guna2Button btn_ver;
        private Guna.UI2.WinForms.Guna2Button btnadd;
        private Guna.UI2.WinForms.Guna2Button btnhome;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Panel btnspanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private System.Windows.Forms.Panel paneljanela;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private Guna.UI.WinForms.GunaCirclePictureBox Pic_perfil;
    }
}