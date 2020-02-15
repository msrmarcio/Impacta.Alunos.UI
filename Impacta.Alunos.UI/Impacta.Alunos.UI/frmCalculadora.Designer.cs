namespace Impacta.Alunos.UI
{
    partial class frmCalculadora
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
            this.txtTabuada = new System.Windows.Forms.TextBox();
            this.lstTabuada = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTabuada
            // 
            this.txtTabuada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTabuada.Location = new System.Drawing.Point(12, 13);
            this.txtTabuada.Name = "txtTabuada";
            this.txtTabuada.Size = new System.Drawing.Size(253, 20);
            this.txtTabuada.TabIndex = 0;
            this.txtTabuada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTabuada_KeyPress);
            // 
            // lstTabuada
            // 
            this.lstTabuada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTabuada.FormattingEnabled = true;
            this.lstTabuada.Location = new System.Drawing.Point(12, 49);
            this.lstTabuada.Name = "lstTabuada";
            this.lstTabuada.Size = new System.Drawing.Size(253, 264);
            this.lstTabuada.TabIndex = 1;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 379);
            this.Controls.Add(this.lstTabuada);
            this.Controls.Add(this.txtTabuada);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "frmCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCalculadora";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmCalculadora_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTabuada;
        private System.Windows.Forms.ListBox lstTabuada;
    }
}