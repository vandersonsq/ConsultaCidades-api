namespace ConsultaCidades
{
    partial class telaMenu
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
            this.btCodigoIbge = new System.Windows.Forms.Button();
            this.txtCodigoIbge = new System.Windows.Forms.TextBox();
            this.lbCidade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCodigoIbge
            // 
            this.btCodigoIbge.Location = new System.Drawing.Point(162, 96);
            this.btCodigoIbge.Name = "btCodigoIbge";
            this.btCodigoIbge.Size = new System.Drawing.Size(134, 33);
            this.btCodigoIbge.TabIndex = 0;
            this.btCodigoIbge.Text = "buscar";
            this.btCodigoIbge.UseVisualStyleBackColor = true;
            this.btCodigoIbge.Click += new System.EventHandler(this.btCodigoIbge_Click);
            // 
            // txtCodigoIbge
            // 
            this.txtCodigoIbge.Location = new System.Drawing.Point(162, 70);
            this.txtCodigoIbge.Name = "txtCodigoIbge";
            this.txtCodigoIbge.Size = new System.Drawing.Size(134, 20);
            this.txtCodigoIbge.TabIndex = 1;
            // 
            // lbCidade
            // 
            this.lbCidade.AutoSize = true;
            this.lbCidade.Location = new System.Drawing.Point(189, 189);
            this.lbCidade.Name = "lbCidade";
            this.lbCidade.Size = new System.Drawing.Size(21, 13);
            this.lbCidade.TabIndex = 2;
            this.lbCidade.Text = "UF";
            this.lbCidade.Click += new System.EventHandler(this.lbCidade_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "CIDADE";
            // 
            // telaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(477, 292);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbCidade);
            this.Controls.Add(this.txtCodigoIbge);
            this.Controls.Add(this.btCodigoIbge);
            this.Name = "telaMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCodigoIbge;
        private System.Windows.Forms.TextBox txtCodigoIbge;
        private System.Windows.Forms.Label lbCidade;
        private System.Windows.Forms.Label label1;
    }
}

