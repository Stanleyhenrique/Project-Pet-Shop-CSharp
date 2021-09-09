
namespace ProjectPetShop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.PanelRodapé = new System.Windows.Forms.Panel();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnRacas = new System.Windows.Forms.Button();
            this.BtnAnimais = new System.Windows.Forms.Button();
            this.BtnServicos = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.BtnAgendamentos = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.Controls.Add(this.BtnIniciar);
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 64);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnIniciar.BackgroundImage")));
            this.BtnIniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnIniciar.FlatAppearance.BorderSize = 0;
            this.BtnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIniciar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciar.Location = new System.Drawing.Point(763, 12);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(46, 36);
            this.BtnIniciar.TabIndex = 2;
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnMinimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.BackgroundImage")));
            this.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMinimizar.Location = new System.Drawing.Point(815, 12);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(46, 36);
            this.BtnMinimizar.TabIndex = 1;
            this.BtnMinimizar.UseVisualStyleBackColor = true;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BtnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSair.BackgroundImage")));
            this.BtnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(867, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(46, 36);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.button6_Click);
            // 
            // PanelRodapé
            // 
            this.PanelRodapé.BackColor = System.Drawing.Color.SlateGray;
            this.PanelRodapé.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelRodapé.Location = new System.Drawing.Point(0, 418);
            this.PanelRodapé.Name = "PanelRodapé";
            this.PanelRodapé.Size = new System.Drawing.Size(916, 54);
            this.PanelRodapé.TabIndex = 3;
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.PanelLateral.Controls.Add(this.panel2);
            this.PanelLateral.Controls.Add(this.BtnRacas);
            this.PanelLateral.Controls.Add(this.BtnAnimais);
            this.PanelLateral.Controls.Add(this.BtnServicos);
            this.PanelLateral.Controls.Add(this.BtnClientes);
            this.PanelLateral.Controls.Add(this.BtnInicio);
            this.PanelLateral.Controls.Add(this.BtnAgendamentos);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Location = new System.Drawing.Point(0, 64);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(200, 354);
            this.PanelLateral.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(22, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 35);
            this.panel2.TabIndex = 0;
            // 
            // BtnRacas
            // 
            this.BtnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRacas.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnRacas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRacas.Location = new System.Drawing.Point(41, 211);
            this.BtnRacas.Name = "BtnRacas";
            this.BtnRacas.Size = new System.Drawing.Size(153, 35);
            this.BtnRacas.TabIndex = 7;
            this.BtnRacas.Text = "Raças";
            this.BtnRacas.UseVisualStyleBackColor = true;
            this.BtnRacas.Click += new System.EventHandler(this.BtnRacas_Click);
            // 
            // BtnAnimais
            // 
            this.BtnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnimais.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnAnimais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAnimais.Location = new System.Drawing.Point(41, 170);
            this.BtnAnimais.Name = "BtnAnimais";
            this.BtnAnimais.Size = new System.Drawing.Size(153, 35);
            this.BtnAnimais.TabIndex = 6;
            this.BtnAnimais.Text = "Animais";
            this.BtnAnimais.UseVisualStyleBackColor = true;
            this.BtnAnimais.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnServicos
            // 
            this.BtnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnServicos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnServicos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnServicos.Location = new System.Drawing.Point(41, 129);
            this.BtnServicos.Name = "BtnServicos";
            this.BtnServicos.Size = new System.Drawing.Size(153, 35);
            this.BtnServicos.TabIndex = 2;
            this.BtnServicos.Text = "Serviços";
            this.BtnServicos.UseVisualStyleBackColor = true;
            this.BtnServicos.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.Location = new System.Drawing.Point(41, 88);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(153, 35);
            this.BtnClientes.TabIndex = 0;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnInicio.Location = new System.Drawing.Point(41, 6);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(153, 35);
            this.BtnInicio.TabIndex = 8;
            this.BtnInicio.Text = "Início";
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // BtnAgendamentos
            // 
            this.BtnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgendamentos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgendamentos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAgendamentos.Location = new System.Drawing.Point(41, 47);
            this.BtnAgendamentos.Name = "BtnAgendamentos";
            this.BtnAgendamentos.Size = new System.Drawing.Size(153, 35);
            this.BtnAgendamentos.TabIndex = 1;
            this.BtnAgendamentos.Text = "Agendamentos";
            this.BtnAgendamentos.UseVisualStyleBackColor = true;
            this.BtnAgendamentos.Click += new System.EventHandler(this.button2_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.SystemColors.Desktop;
            this.PanelCentral.BackgroundImage = global::ProjectPetShop.Properties.Resources.Animais;
            this.PanelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(200, 64);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(716, 354);
            this.PanelCentral.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 472);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelRodapé);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelRodapé;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Button BtnRacas;
        private System.Windows.Forms.Button BtnAnimais;
        private System.Windows.Forms.Button BtnServicos;
        private System.Windows.Forms.Button BtnAgendamentos;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Panel panel2;
    }
}

