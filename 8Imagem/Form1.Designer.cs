namespace _8Imagem
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
            this.btnFlamengo = new System.Windows.Forms.Button();
            this.btnVasco = new System.Windows.Forms.Button();
            this.pbImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFlamengo
            // 
            this.btnFlamengo.Location = new System.Drawing.Point(216, 27);
            this.btnFlamengo.Name = "btnFlamengo";
            this.btnFlamengo.Size = new System.Drawing.Size(228, 35);
            this.btnFlamengo.TabIndex = 1;
            this.btnFlamengo.Text = "Flamengo";
            this.btnFlamengo.UseVisualStyleBackColor = true;
            this.btnFlamengo.Click += new System.EventHandler(this.btnFlamengo_Click);
            // 
            // btnVasco
            // 
            this.btnVasco.Location = new System.Drawing.Point(216, 89);
            this.btnVasco.Name = "btnVasco";
            this.btnVasco.Size = new System.Drawing.Size(228, 35);
            this.btnVasco.TabIndex = 2;
            this.btnVasco.Text = "Vasco";
            this.btnVasco.UseVisualStyleBackColor = true;
            this.btnVasco.Click += new System.EventHandler(this.btnVasco_Click);
            // 
            // pbImagem
            // 
            this.pbImagem.Image = global::_8Imagem.Properties.Resources.logoVasco;
            this.pbImagem.Location = new System.Drawing.Point(22, 27);
            this.pbImagem.Name = "pbImagem";
            this.pbImagem.Size = new System.Drawing.Size(142, 173);
            this.pbImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagem.TabIndex = 0;
            this.pbImagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 233);
            this.Controls.Add(this.btnVasco);
            this.Controls.Add(this.btnFlamengo);
            this.Controls.Add(this.pbImagem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFlamengo;
        private System.Windows.Forms.Button btnVasco;
        private System.Windows.Forms.PictureBox pbImagem;
    }
}

