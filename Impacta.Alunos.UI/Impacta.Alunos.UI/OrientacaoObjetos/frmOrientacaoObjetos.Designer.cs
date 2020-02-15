namespace Impacta.Alunos.UI
{
    partial class frmOrientacaoObjetos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeCarro = new System.Windows.Forms.TextBox();
            this.txtNomeAviao = new System.Windows.Forms.TextBox();
            this.txtNomeCaminhao = new System.Windows.Forms.TextBox();
            this.btnCarro = new System.Windows.Forms.Button();
            this.lstVeiculos = new System.Windows.Forms.ListBox();
            this.btnAviao = new System.Windows.Forms.Button();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exemplo Orientação a Objetos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Carro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome do Avião";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nome do Caminhão";
            // 
            // txtNomeCarro
            // 
            this.txtNomeCarro.Location = new System.Drawing.Point(209, 99);
            this.txtNomeCarro.Name = "txtNomeCarro";
            this.txtNomeCarro.Size = new System.Drawing.Size(195, 29);
            this.txtNomeCarro.TabIndex = 4;
            // 
            // txtNomeAviao
            // 
            this.txtNomeAviao.Location = new System.Drawing.Point(209, 151);
            this.txtNomeAviao.Name = "txtNomeAviao";
            this.txtNomeAviao.Size = new System.Drawing.Size(195, 29);
            this.txtNomeAviao.TabIndex = 5;
            // 
            // txtNomeCaminhao
            // 
            this.txtNomeCaminhao.Location = new System.Drawing.Point(209, 204);
            this.txtNomeCaminhao.Name = "txtNomeCaminhao";
            this.txtNomeCaminhao.Size = new System.Drawing.Size(195, 29);
            this.txtNomeCaminhao.TabIndex = 6;
            // 
            // btnCarro
            // 
            this.btnCarro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCarro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCarro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarro.Location = new System.Drawing.Point(423, 91);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(113, 37);
            this.btnCarro.TabIndex = 7;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // lstVeiculos
            // 
            this.lstVeiculos.FormattingEnabled = true;
            this.lstVeiculos.ItemHeight = 24;
            this.lstVeiculos.Location = new System.Drawing.Point(19, 294);
            this.lstVeiculos.Name = "lstVeiculos";
            this.lstVeiculos.Size = new System.Drawing.Size(517, 148);
            this.lstVeiculos.TabIndex = 8;
            // 
            // btnAviao
            // 
            this.btnAviao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAviao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAviao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAviao.Location = new System.Drawing.Point(423, 143);
            this.btnAviao.Name = "btnAviao";
            this.btnAviao.Size = new System.Drawing.Size(113, 37);
            this.btnAviao.TabIndex = 9;
            this.btnAviao.Text = "Avião";
            this.btnAviao.UseVisualStyleBackColor = true;
            this.btnAviao.Click += new System.EventHandler(this.btnAviao_Click);
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCaminhao.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCaminhao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaminhao.Location = new System.Drawing.Point(423, 196);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(113, 37);
            this.btnCaminhao.TabIndex = 10;
            this.btnCaminhao.Text = "Caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = true;
            // 
            // frmOrientacaoObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 454);
            this.Controls.Add(this.btnCaminhao);
            this.Controls.Add(this.btnAviao);
            this.Controls.Add(this.lstVeiculos);
            this.Controls.Add(this.btnCarro);
            this.Controls.Add(this.txtNomeCaminhao);
            this.Controls.Add(this.txtNomeAviao);
            this.Controls.Add(this.txtNomeCarro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmOrientacaoObjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrientacaoObjetos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeCarro;
        private System.Windows.Forms.TextBox txtNomeAviao;
        private System.Windows.Forms.TextBox txtNomeCaminhao;
        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.ListBox lstVeiculos;
        private System.Windows.Forms.Button btnAviao;
        private System.Windows.Forms.Button btnCaminhao;
    }
}