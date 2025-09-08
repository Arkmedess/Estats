namespace Interface_e_sistema_em_C_
{
    partial class Base
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Base));
            Barra_lateral_menu = new Panel();
            pnInicio = new Panel();
            btnInicio = new Button();
            pnSobre = new Panel();
            btnSobre = new Button();
            pnConfig = new Panel();
            btnConfig = new Button();
            MenuFerramentas = new FlowLayoutPanel();
            pnFerramentas = new Panel();
            btnFerramentas = new Button();
            pnEstatPar = new Panel();
            btnEstatPar = new Button();
            pnVAC = new Panel();
            btnVAC = new Button();
            pnSair = new Panel();
            btnSair = new Button();
            EstatsIMG = new PictureBox();
            link1 = new LinkLabel();
            panel6 = new Panel();
            BarraSuperior = new Panel();
            pictureBox1 = new PictureBox();
            BarraDeFuncoes = new ReaLTaiizor.Controls.NightControlBox();
            MenuTransicao = new System.Windows.Forms.Timer(components);
            BarraLateralTransicao = new System.Windows.Forms.Timer(components);
            Barra_lateral_menu.SuspendLayout();
            pnInicio.SuspendLayout();
            pnSobre.SuspendLayout();
            pnConfig.SuspendLayout();
            MenuFerramentas.SuspendLayout();
            pnFerramentas.SuspendLayout();
            pnEstatPar.SuspendLayout();
            pnVAC.SuspendLayout();
            pnSair.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EstatsIMG).BeginInit();
            BarraSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Barra_lateral_menu
            // 
            resources.ApplyResources(Barra_lateral_menu, "Barra_lateral_menu");
            Barra_lateral_menu.BackColor = Color.FromArgb(15, 15, 15);
            Barra_lateral_menu.Controls.Add(pnInicio);
            Barra_lateral_menu.Controls.Add(pnSobre);
            Barra_lateral_menu.Controls.Add(pnConfig);
            Barra_lateral_menu.Controls.Add(MenuFerramentas);
            Barra_lateral_menu.Controls.Add(pnSair);
            Barra_lateral_menu.Name = "Barra_lateral_menu";
            // 
            // pnInicio
            // 
            resources.ApplyResources(pnInicio, "pnInicio");
            pnInicio.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnInicio.Controls.Add(btnInicio);
            pnInicio.Cursor = Cursors.Hand;
            pnInicio.Name = "pnInicio";
            // 
            // btnInicio
            // 
            resources.ApplyResources(btnInicio, "btnInicio");
            btnInicio.BackColor = Color.FromArgb(15, 15, 15);
            btnInicio.ForeColor = Color.White;
            btnInicio.Name = "btnInicio";
            btnInicio.UseVisualStyleBackColor = false;
            btnInicio.MouseClick += BotaoInicio_MouseClick;
            // 
            // pnSobre
            // 
            resources.ApplyResources(pnSobre, "pnSobre");
            pnSobre.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnSobre.Controls.Add(btnSobre);
            pnSobre.Cursor = Cursors.Hand;
            pnSobre.Name = "pnSobre";
            // 
            // btnSobre
            // 
            resources.ApplyResources(btnSobre, "btnSobre");
            btnSobre.BackColor = Color.FromArgb(15, 15, 15);
            btnSobre.ForeColor = Color.White;
            btnSobre.Name = "btnSobre";
            btnSobre.UseVisualStyleBackColor = false;
            btnSobre.Click += BotaoSobre_Click;
            // 
            // pnConfig
            // 
            resources.ApplyResources(pnConfig, "pnConfig");
            pnConfig.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnConfig.Controls.Add(btnConfig);
            pnConfig.Cursor = Cursors.Hand;
            pnConfig.Name = "pnConfig";
            // 
            // btnConfig
            // 
            resources.ApplyResources(btnConfig, "btnConfig");
            btnConfig.BackColor = Color.FromArgb(15, 15, 15);
            btnConfig.ForeColor = Color.White;
            btnConfig.Name = "btnConfig";
            btnConfig.UseVisualStyleBackColor = false;
            btnConfig.Click += BotaoConfiguracoes_Click;
            // 
            // MenuFerramentas
            // 
            resources.ApplyResources(MenuFerramentas, "MenuFerramentas");
            MenuFerramentas.BackColor = Color.FromArgb(15, 15, 15);
            MenuFerramentas.Controls.Add(pnFerramentas);
            MenuFerramentas.Controls.Add(pnEstatPar);
            MenuFerramentas.Controls.Add(pnVAC);
            MenuFerramentas.Name = "MenuFerramentas";
            MenuFerramentas.Click += BotaoFerramentas_Click;
            // 
            // pnFerramentas
            // 
            resources.ApplyResources(pnFerramentas, "pnFerramentas");
            pnFerramentas.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnFerramentas.Controls.Add(btnFerramentas);
            pnFerramentas.Cursor = Cursors.Hand;
            pnFerramentas.Name = "pnFerramentas";
            // 
            // btnFerramentas
            // 
            resources.ApplyResources(btnFerramentas, "btnFerramentas");
            btnFerramentas.BackColor = Color.FromArgb(15, 15, 15);
            btnFerramentas.ForeColor = Color.White;
            btnFerramentas.Name = "btnFerramentas";
            btnFerramentas.UseVisualStyleBackColor = false;
            btnFerramentas.Click += BotaoFerramentas_Click;
            // 
            // pnEstatPar
            // 
            resources.ApplyResources(pnEstatPar, "pnEstatPar");
            pnEstatPar.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnEstatPar.Controls.Add(btnEstatPar);
            pnEstatPar.Cursor = Cursors.Hand;
            pnEstatPar.Name = "pnEstatPar";
            // 
            // btnEstatPar
            // 
            resources.ApplyResources(btnEstatPar, "btnEstatPar");
            btnEstatPar.BackColor = Color.FromArgb(15, 15, 15);
            btnEstatPar.ForeColor = Color.White;
            btnEstatPar.Name = "btnEstatPar";
            btnEstatPar.UseVisualStyleBackColor = false;
            btnEstatPar.Click += BotaoEstatParametrica_Click;
            // 
            // pnVAC
            // 
            resources.ApplyResources(pnVAC, "pnVAC");
            pnVAC.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnVAC.Controls.Add(btnVAC);
            pnVAC.Cursor = Cursors.Hand;
            pnVAC.Name = "pnVAC";
            // 
            // btnVAC
            // 
            resources.ApplyResources(btnVAC, "btnVAC");
            btnVAC.BackColor = Color.FromArgb(15, 15, 15);
            btnVAC.ForeColor = Color.White;
            btnVAC.Name = "btnVAC";
            btnVAC.UseVisualStyleBackColor = false;
            btnVAC.Click += BotaoVAC_Click;
            // 
            // pnSair
            // 
            resources.ApplyResources(pnSair, "pnSair");
            pnSair.BackColor = Color.FromArgb(100, 39, 37, 59);
            pnSair.Controls.Add(btnSair);
            pnSair.Cursor = Cursors.Hand;
            pnSair.Name = "pnSair";
            // 
            // btnSair
            // 
            resources.ApplyResources(btnSair, "btnSair");
            btnSair.BackColor = Color.FromArgb(15, 15, 15);
            btnSair.ForeColor = Color.White;
            btnSair.Name = "btnSair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += BotaoSair_Click;
            // 
            // EstatsIMG
            // 
            resources.ApplyResources(EstatsIMG, "EstatsIMG");
            EstatsIMG.Name = "EstatsIMG";
            EstatsIMG.TabStop = false;
            // 
            // link1
            // 
            resources.ApplyResources(link1, "link1");
            link1.LinkColor = Color.White;
            link1.Name = "link1";
            link1.TabStop = true;
            // 
            // panel6
            // 
            resources.ApplyResources(panel6, "panel6");
            panel6.BackColor = Color.FromArgb(30, 0, 0, 0);
            panel6.Name = "panel6";
            // 
            // BarraSuperior
            // 
            resources.ApplyResources(BarraSuperior, "BarraSuperior");
            BarraSuperior.BackColor = Color.FromArgb(79, 55, 139);
            BarraSuperior.Controls.Add(pictureBox1);
            BarraSuperior.Controls.Add(EstatsIMG);
            BarraSuperior.Controls.Add(BarraDeFuncoes);
            BarraSuperior.Name = "BarraSuperior";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            pictureBox1.Click += Botao_Tres_Barras_Click;
            // 
            // BarraDeFuncoes
            // 
            resources.ApplyResources(BarraDeFuncoes, "BarraDeFuncoes");
            BarraDeFuncoes.BackColor = Color.Transparent;
            BarraDeFuncoes.CloseHoverColor = Color.FromArgb(199, 80, 80);
            BarraDeFuncoes.CloseHoverForeColor = Color.White;
            BarraDeFuncoes.DefaultLocation = true;
            BarraDeFuncoes.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            BarraDeFuncoes.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            BarraDeFuncoes.EnableCloseColor = Color.FromArgb(160, 160, 160);
            BarraDeFuncoes.EnableMaximizeButton = false;
            BarraDeFuncoes.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            BarraDeFuncoes.EnableMinimizeButton = true;
            BarraDeFuncoes.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            BarraDeFuncoes.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            BarraDeFuncoes.MaximizeHoverForeColor = Color.White;
            BarraDeFuncoes.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            BarraDeFuncoes.MinimizeHoverForeColor = Color.White;
            BarraDeFuncoes.Name = "BarraDeFuncoes";
            // 
            // MenuTransicao
            // 
            MenuTransicao.Interval = 4;
            MenuTransicao.Tick += MenuTransicao_Tick;
            // 
            // BarraLateralTransicao
            // 
            BarraLateralTransicao.Interval = 6;
            BarraLateralTransicao.Tick += BarraLateralTransicao_Tick;
            // 
            // Base
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 33, 34);
            ControlBox = false;
            Controls.Add(BarraSuperior);
            Controls.Add(panel6);
            Controls.Add(Barra_lateral_menu);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "Base";
            Load += Base_Load;
            Barra_lateral_menu.ResumeLayout(false);
            pnInicio.ResumeLayout(false);
            pnSobre.ResumeLayout(false);
            pnConfig.ResumeLayout(false);
            MenuFerramentas.ResumeLayout(false);
            pnFerramentas.ResumeLayout(false);
            pnEstatPar.ResumeLayout(false);
            pnVAC.ResumeLayout(false);
            pnSair.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EstatsIMG).EndInit();
            BarraSuperior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel Barra_lateral_menu;
        private PictureBox EstatsIMG;
        private LinkLabel link1;
        private Panel panel6;
        private Panel BarraSuperior;
        private ReaLTaiizor.Controls.NightControlBox BarraDeFuncoes;
        private PictureBox pictureBox1;
        private Panel pnSair;
        private Button btnSair;
        private Panel panel8;
        private Button btnSobre;
        private Panel pnConfig;
        private Button btnConfig;
        private Panel pnFerramentas1;
        private Panel pnInicio;
        private Button btnInicio;
        private FlowLayoutPanel MenuFerramentas1;
        private Panel pnEstatPar;
        private Panel pnVAC;
        private Button btnEstatPar;
        private Panel pnSobre;
        private System.Windows.Forms.Timer MenuTransicao;
        private Button btnFerramentas1;
        private FlowLayoutPanel MenuFerramentas;
        private Panel pnFerramentas;
        private Button btnFerramentas;
        private Button btnEstatParamet;
        private Panel panel9;
        private Button btnVAC;
        private System.Windows.Forms.Timer BarraLateralTransicao;
    }
}
