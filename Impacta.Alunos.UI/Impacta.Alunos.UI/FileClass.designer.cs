namespace Impacta.alunos.UI
{
    partial class FrmCadastroVeiculo
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
            this.GravarBtn = new System.Windows.Forms.Button();
            this.marcaCmbBox = new System.Windows.Forms.ComboBox();
            this.combustivelCmbBox = new System.Windows.Forms.ComboBox();
            this.cambioCmbBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.placaTxtBox = new System.Windows.Forms.TextBox();
            this.modeloTxtBox = new System.Windows.Forms.TextBox();
            this.corTxtBox = new System.Windows.Forms.TextBox();
            this.anoTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.obsevacaoTxtBox = new System.Windows.Forms.TextBox();
            this.toqueLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GravarBtn
            // 
            this.GravarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GravarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.GravarBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.GravarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GravarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GravarBtn.Location = new System.Drawing.Point(427, 41);
            this.GravarBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GravarBtn.Name = "GravarBtn";
            this.GravarBtn.Size = new System.Drawing.Size(451, 84);
            this.GravarBtn.TabIndex = 14;
            this.GravarBtn.Text = "Gravar";
            this.GravarBtn.UseVisualStyleBackColor = false;
            this.GravarBtn.Click += new System.EventHandler(this.GravarBtn_Click);
            // 
            // marcaCmbBox
            // 
            this.marcaCmbBox.AccessibleName = "Marca";
            this.marcaCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.marcaCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.marcaCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.marcaCmbBox.FormattingEnabled = true;
            this.marcaCmbBox.Location = new System.Drawing.Point(309, 41);
            this.marcaCmbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marcaCmbBox.Name = "marcaCmbBox";
            this.marcaCmbBox.Size = new System.Drawing.Size(112, 24);
            this.marcaCmbBox.TabIndex = 9;
            // 
            // combustivelCmbBox
            // 
            this.combustivelCmbBox.AccessibleName = "Combustível";
            this.combustivelCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.combustivelCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combustivelCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combustivelCmbBox.FormattingEnabled = true;
            this.combustivelCmbBox.Location = new System.Drawing.Point(309, 71);
            this.combustivelCmbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combustivelCmbBox.Name = "combustivelCmbBox";
            this.combustivelCmbBox.Size = new System.Drawing.Size(112, 24);
            this.combustivelCmbBox.TabIndex = 11;
            // 
            // cambioCmbBox
            // 
            this.cambioCmbBox.AccessibleName = "Câmbio";
            this.cambioCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cambioCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cambioCmbBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cambioCmbBox.FormattingEnabled = true;
            this.cambioCmbBox.Location = new System.Drawing.Point(309, 101);
            this.cambioCmbBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cambioCmbBox.Name = "cambioCmbBox";
            this.cambioCmbBox.Size = new System.Drawing.Size(112, 24);
            this.cambioCmbBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "&Placa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "&Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "&Cor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "&Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(237, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(195, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "&Combustível:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "&Câmbio:";
            // 
            // placaTxtBox
            // 
            this.placaTxtBox.AccessibleName = "Placa";
            this.placaTxtBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.placaTxtBox.Location = new System.Drawing.Point(88, 41);
            this.placaTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placaTxtBox.MaxLength = 7;
            this.placaTxtBox.Name = "placaTxtBox";
            this.placaTxtBox.Size = new System.Drawing.Size(100, 23);
            this.placaTxtBox.TabIndex = 1;
            this.placaTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // modeloTxtBox
            // 
            this.modeloTxtBox.AccessibleName = "Modelo";
            this.modeloTxtBox.Location = new System.Drawing.Point(88, 70);
            this.modeloTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modeloTxtBox.MaxLength = 30;
            this.modeloTxtBox.Name = "modeloTxtBox";
            this.modeloTxtBox.Size = new System.Drawing.Size(100, 23);
            this.modeloTxtBox.TabIndex = 3;
            // 
            // corTxtBox
            // 
            this.corTxtBox.AccessibleName = "Cor";
            this.corTxtBox.Location = new System.Drawing.Point(88, 98);
            this.corTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.corTxtBox.MaxLength = 30;
            this.corTxtBox.Name = "corTxtBox";
            this.corTxtBox.Size = new System.Drawing.Size(100, 23);
            this.corTxtBox.TabIndex = 5;
            // 
            // anoTxtBox
            // 
            this.anoTxtBox.AccessibleName = "Ano";
            this.anoTxtBox.Location = new System.Drawing.Point(88, 126);
            this.anoTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.anoTxtBox.MaxLength = 4;
            this.anoTxtBox.Name = "anoTxtBox";
            this.anoTxtBox.Size = new System.Drawing.Size(100, 23);
            this.anoTxtBox.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Observação:";
            // 
            // obsevacaoTxtBox
            // 
            this.obsevacaoTxtBox.AccessibleName = "Observação";
            this.obsevacaoTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.obsevacaoTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obsevacaoTxtBox.Location = new System.Drawing.Point(137, 166);
            this.obsevacaoTxtBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obsevacaoTxtBox.MaxLength = 300;
            this.obsevacaoTxtBox.Multiline = true;
            this.obsevacaoTxtBox.Name = "obsevacaoTxtBox";
            this.obsevacaoTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.obsevacaoTxtBox.Size = new System.Drawing.Size(740, 242);
            this.obsevacaoTxtBox.TabIndex = 16;
            this.obsevacaoTxtBox.TextChanged += new System.EventHandler(this.obsevacaoTxtBox_TextChanged);
            // 
            // toqueLbl
            // 
            this.toqueLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toqueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toqueLbl.Location = new System.Drawing.Point(777, 146);
            this.toqueLbl.Name = "toqueLbl";
            this.toqueLbl.Size = new System.Drawing.Size(94, 16);
            this.toqueLbl.TabIndex = 17;
            this.toqueLbl.Text = "Restante:300";
            this.toqueLbl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // FrmCadastroVeiculo
            // 
            this.AcceptButton = this.GravarBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 421);
            this.Controls.Add(this.toqueLbl);
            this.Controls.Add(this.obsevacaoTxtBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.anoTxtBox);
            this.Controls.Add(this.corTxtBox);
            this.Controls.Add(this.modeloTxtBox);
            this.Controls.Add(this.placaTxtBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cambioCmbBox);
            this.Controls.Add(this.combustivelCmbBox);
            this.Controls.Add(this.marcaCmbBox);
            this.Controls.Add(this.GravarBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmCadastroVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impacta Tecnologia - Cadastro veiculos";
            this.Load += new System.EventHandler(this.FrmCadastroVeiculo_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCadastroVeiculo_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GravarBtn;
        private System.Windows.Forms.ComboBox marcaCmbBox;
        private System.Windows.Forms.ComboBox combustivelCmbBox;
        private System.Windows.Forms.ComboBox cambioCmbBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox placaTxtBox;
        private System.Windows.Forms.TextBox modeloTxtBox;
        private System.Windows.Forms.TextBox corTxtBox;
        private System.Windows.Forms.TextBox anoTxtBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox obsevacaoTxtBox;
        private System.Windows.Forms.Label toqueLbl;
    }
}