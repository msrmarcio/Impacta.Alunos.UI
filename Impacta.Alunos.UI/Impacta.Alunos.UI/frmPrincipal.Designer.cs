namespace Impacta.Alunos.UI
{
    partial class frmPrincipal
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssNomeUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercíciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório4Cap1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório5Cap1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orientaçãoAObjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hERANÇAPOLIMORFISMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.laboratório7Cap1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroVeiculoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.laboratório8Cap1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeClientesArqDelimitadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssNomeUsuario,
            this.tssUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 426);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(733, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssNomeUsuario
            // 
            this.tssNomeUsuario.Name = "tssNomeUsuario";
            this.tssNomeUsuario.Size = new System.Drawing.Size(50, 17);
            this.tssNomeUsuario.Text = "Usuário: ";
            // 
            // tssUsuario
            // 
            this.tssUsuario.Name = "tssUsuario";
            this.tssUsuario.Size = new System.Drawing.Size(89, 17);
            this.tssUsuario.Text = "<Nome Usuario>";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.exercíciosToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(733, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // exercíciosToolStripMenuItem
            // 
            this.exercíciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.laboratório4Cap1ToolStripMenuItem,
            this.laboratório5Cap1ToolStripMenuItem,
            this.orientaçãoAObjetosToolStripMenuItem,
            this.laboratório7Cap1ToolStripMenuItem,
            this.laboratório8Cap1ToolStripMenuItem});
            this.exercíciosToolStripMenuItem.Name = "exercíciosToolStripMenuItem";
            this.exercíciosToolStripMenuItem.Size = new System.Drawing.Size(66, 19);
            this.exercíciosToolStripMenuItem.Text = "Exercícios";
            // 
            // laboratório4Cap1ToolStripMenuItem
            // 
            this.laboratório4Cap1ToolStripMenuItem.Name = "laboratório4Cap1ToolStripMenuItem";
            this.laboratório4Cap1ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.laboratório4Cap1ToolStripMenuItem.Text = "Laboratório 4 Cap. 1";
            this.laboratório4Cap1ToolStripMenuItem.Click += new System.EventHandler(this.laboratório4Cap1ToolStripMenuItem_Click);
            // 
            // laboratório5Cap1ToolStripMenuItem
            // 
            this.laboratório5Cap1ToolStripMenuItem.Name = "laboratório5Cap1ToolStripMenuItem";
            this.laboratório5Cap1ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.laboratório5Cap1ToolStripMenuItem.Text = "Laboratório 5 Cap. 1 - Calculadora";
            this.laboratório5Cap1ToolStripMenuItem.Click += new System.EventHandler(this.laboratório5Cap1ToolStripMenuItem_Click);
            // 
            // orientaçãoAObjetosToolStripMenuItem
            // 
            this.orientaçãoAObjetosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hERANÇAPOLIMORFISMOToolStripMenuItem});
            this.orientaçãoAObjetosToolStripMenuItem.Name = "orientaçãoAObjetosToolStripMenuItem";
            this.orientaçãoAObjetosToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.orientaçãoAObjetosToolStripMenuItem.Text = "Orientação a Objetos ";
            // 
            // hERANÇAPOLIMORFISMOToolStripMenuItem
            // 
            this.hERANÇAPOLIMORFISMOToolStripMenuItem.Name = "hERANÇAPOLIMORFISMOToolStripMenuItem";
            this.hERANÇAPOLIMORFISMOToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.hERANÇAPOLIMORFISMOToolStripMenuItem.Text = "HERANÇA / POLIMORFISMO";
            this.hERANÇAPOLIMORFISMOToolStripMenuItem.Click += new System.EventHandler(this.hERANÇAPOLIMORFISMOToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(47, 19);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(299, 391);
            this.lblDataHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(96, 20);
            this.lblDataHora.TabIndex = 3;
            this.lblDataHora.Text = "Data e Hora";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // laboratório7Cap1ToolStripMenuItem
            // 
            this.laboratório7Cap1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroVeiculoToolStripMenuItem});
            this.laboratório7Cap1ToolStripMenuItem.Name = "laboratório7Cap1ToolStripMenuItem";
            this.laboratório7Cap1ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.laboratório7Cap1ToolStripMenuItem.Text = "Laboratório 7 Cap 1 ";
            // 
            // cadastroVeiculoToolStripMenuItem
            // 
            this.cadastroVeiculoToolStripMenuItem.Name = "cadastroVeiculoToolStripMenuItem";
            this.cadastroVeiculoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastroVeiculoToolStripMenuItem.Text = "Cadastro Veiculo";
            this.cadastroVeiculoToolStripMenuItem.Click += new System.EventHandler(this.cadastroVeiculoToolStripMenuItem_Click);
            // 
            // laboratório8Cap1ToolStripMenuItem
            // 
            this.laboratório8Cap1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDeClientesArqDelimitadosToolStripMenuItem});
            this.laboratório8Cap1ToolStripMenuItem.Name = "laboratório8Cap1ToolStripMenuItem";
            this.laboratório8Cap1ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.laboratório8Cap1ToolStripMenuItem.Text = "Laboratório 8 Cap 1";
            // 
            // listaDeClientesArqDelimitadosToolStripMenuItem
            // 
            this.listaDeClientesArqDelimitadosToolStripMenuItem.Name = "listaDeClientesArqDelimitadosToolStripMenuItem";
            this.listaDeClientesArqDelimitadosToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.listaDeClientesArqDelimitadosToolStripMenuItem.Text = "Lista de Clientes - Arq. Delimitados";
            this.listaDeClientesArqDelimitadosToolStripMenuItem.Click += new System.EventHandler(this.listaDeClientesArqDelimitadosToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 448);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmPrincipal";
            this.Text = "Impacta Tecnologia - Gestão de Alunos";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssNomeUsuario;
        private System.Windows.Forms.ToolStripStatusLabel tssUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercíciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.Label lblDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem laboratório4Cap1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório5Cap1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orientaçãoAObjetosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hERANÇAPOLIMORFISMOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório7Cap1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroVeiculoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem laboratório8Cap1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeClientesArqDelimitadosToolStripMenuItem;
    }
}