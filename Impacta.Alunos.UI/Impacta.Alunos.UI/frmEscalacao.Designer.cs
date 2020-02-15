namespace Impacta.Alunos.UI
{
    partial class frmEscalacao
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstNomeJogadores = new System.Windows.Forms.ListBox();
            this.nupQtdeJogadores = new System.Windows.Forms.NumericUpDown();
            this.lblQtdeJogadores = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnTranferir = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lstEscalados = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQtdeJogadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(314, 39);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(333, 21);
            this.txtNome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar Nome Jogador";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(18, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 83);
            this.panel1.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(246, 33);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(221, 18);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ESCALAÇÃO DE JOGADORES";
            // 
            // lstNomeJogadores
            // 
            this.lstNomeJogadores.FormattingEnabled = true;
            this.lstNomeJogadores.ItemHeight = 18;
            this.lstNomeJogadores.Location = new System.Drawing.Point(18, 193);
            this.lstNomeJogadores.Name = "lstNomeJogadores";
            this.lstNomeJogadores.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstNomeJogadores.Size = new System.Drawing.Size(208, 382);
            this.lstNomeJogadores.TabIndex = 4;
            // 
            // nupQtdeJogadores
            // 
            this.nupQtdeJogadores.Location = new System.Drawing.Point(45, 39);
            this.nupQtdeJogadores.Name = "nupQtdeJogadores";
            this.nupQtdeJogadores.Size = new System.Drawing.Size(120, 21);
            this.nupQtdeJogadores.TabIndex = 5;
            // 
            // lblQtdeJogadores
            // 
            this.lblQtdeJogadores.AutoSize = true;
            this.lblQtdeJogadores.Location = new System.Drawing.Point(42, 17);
            this.lblQtdeJogadores.Name = "lblQtdeJogadores";
            this.lblQtdeJogadores.Size = new System.Drawing.Size(114, 15);
            this.lblQtdeJogadores.TabIndex = 6;
            this.lblQtdeJogadores.Text = "Qtde. de Jogadores";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(530, 554);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(148, 18);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "www.impacta.com.br";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncluir);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblQtdeJogadores);
            this.groupBox1.Controls.Add(this.nupQtdeJogadores);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 79);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerenciamento";
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.Image = global::Impacta.Alunos.UI.Properties.Resources.iconfinder_cross_delete_remove_close_5402366;
            this.btnFechar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFechar.Location = new System.Drawing.Point(566, 507);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(106, 43);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnIncluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluir.Image = global::Impacta.Alunos.UI.Properties.Resources.iconfinder_profle_10550001;
            this.btnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncluir.Location = new System.Drawing.Point(186, 17);
            this.btnIncluir.Margin = new System.Windows.Forms.Padding(4);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(106, 43);
            this.btnIncluir.TabIndex = 0;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnTranferir
            // 
            this.btnTranferir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnTranferir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTranferir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTranferir.Image = global::Impacta.Alunos.UI.Properties.Resources.iconfinder_profle_10550001;
            this.btnTranferir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTranferir.Location = new System.Drawing.Point(233, 295);
            this.btnTranferir.Margin = new System.Windows.Forms.Padding(4);
            this.btnTranferir.Name = "btnTranferir";
            this.btnTranferir.Size = new System.Drawing.Size(138, 43);
            this.btnTranferir.TabIndex = 7;
            this.btnTranferir.Text = "&Transferir >>";
            this.btnTranferir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTranferir.UseVisualStyleBackColor = true;
            this.btnTranferir.Click += new System.EventHandler(this.btnTranferir_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnRemover.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Image = global::Impacta.Alunos.UI.Properties.Resources.iconfinder_profle_10550001;
            this.btnRemover.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemover.Location = new System.Drawing.Point(233, 244);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(138, 43);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // lstEscalados
            // 
            this.lstEscalados.FormattingEnabled = true;
            this.lstEscalados.ItemHeight = 18;
            this.lstEscalados.Location = new System.Drawing.Point(378, 193);
            this.lstEscalados.Name = "lstEscalados";
            this.lstEscalados.Size = new System.Drawing.Size(208, 256);
            this.lstEscalados.TabIndex = 10;
            // 
            // frmEscalacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 581);
            this.Controls.Add(this.lstEscalados);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnTranferir);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lstNomeJogadores);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmEscalacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEscalacao";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupQtdeJogadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstNomeJogadores;
        private System.Windows.Forms.NumericUpDown nupQtdeJogadores;
        private System.Windows.Forms.Label lblQtdeJogadores;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnTranferir;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.ListBox lstEscalados;
    }
}