namespace conversorMoedas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txb123 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDolar = new System.Windows.Forms.TextBox();
            this.texte = new System.Windows.Forms.Label();
            this.txbCota = new System.Windows.Forms.TextBox();
            this.lblReais = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Moedas";
            // 
            // txb123
            // 
            this.txb123.AutoSize = true;
            this.txb123.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb123.Location = new System.Drawing.Point(102, 122);
            this.txb123.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.txb123.Name = "txb123";
            this.txb123.Size = new System.Drawing.Size(76, 20);
            this.txb123.TabIndex = 1;
            this.txb123.Text = "Cotação";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(618, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 3;
            // 
            // txbDolar
            // 
            this.txbDolar.Location = new System.Drawing.Point(515, 167);
            this.txbDolar.Margin = new System.Windows.Forms.Padding(5);
            this.txbDolar.Name = "txbDolar";
            this.txbDolar.Size = new System.Drawing.Size(197, 26);
            this.txbDolar.TabIndex = 4;
            this.txbDolar.Text = "\r\n";
            this.txbDolar.Leave += new System.EventHandler(this.texbDolar_Leave);
            // 
            // texte
            // 
            this.texte.AutoSize = true;
            this.texte.Location = new System.Drawing.Point(511, 122);
            this.texte.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.texte.Name = "texte";
            this.texte.Size = new System.Drawing.Size(128, 20);
            this.texte.TabIndex = 5;
            this.texte.Text = "Valor em Dolar";
            this.texte.Click += new System.EventHandler(this.label3_Click);
            // 
            // txbCota
            // 
            this.txbCota.Location = new System.Drawing.Point(81, 167);
            this.txbCota.Name = "txbCota";
            this.txbCota.Size = new System.Drawing.Size(171, 26);
            this.txbCota.TabIndex = 6;
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Location = new System.Drawing.Point(308, 316);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(133, 20);
            this.lblReais.TabIndex = 7;
            this.lblReais.Text = "Valor Em Reais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 478);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblReais);
            this.Controls.Add(this.txbCota);
            this.Controls.Add(this.texte);
            this.Controls.Add(this.txbDolar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb123);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txb123;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDolar;
        private System.Windows.Forms.Label texte;
        private System.Windows.Forms.TextBox txbCota;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Label label3;
    }
}

