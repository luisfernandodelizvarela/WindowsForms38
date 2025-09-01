namespace _7TesteRandom
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
            this.lblResNext = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnNextParametro = new System.Windows.Forms.Button();
            this.lblResNextParametro = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.btnGerarIntervalo = new System.Windows.Forms.Button();
            this.lblResValorIF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResNext
            // 
            this.lblResNext.AutoSize = true;
            this.lblResNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResNext.Location = new System.Drawing.Point(294, 102);
            this.lblResNext.Name = "lblResNext";
            this.lblResNext.Size = new System.Drawing.Size(200, 46);
            this.lblResNext.TabIndex = 0;
            this.lblResNext.Text = "Resultado";
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(33, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(721, 70);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next()";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnNextParametro
            // 
            this.btnNextParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextParametro.Location = new System.Drawing.Point(33, 230);
            this.btnNextParametro.Name = "btnNextParametro";
            this.btnNextParametro.Size = new System.Drawing.Size(721, 72);
            this.btnNextParametro.TabIndex = 2;
            this.btnNextParametro.Text = "Next(int valor)";
            this.btnNextParametro.UseVisualStyleBackColor = true;
            this.btnNextParametro.Click += new System.EventHandler(this.btnNextParametro_Click);
            // 
            // lblResNextParametro
            // 
            this.lblResNextParametro.AutoSize = true;
            this.lblResNextParametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResNextParametro.Location = new System.Drawing.Point(314, 337);
            this.lblResNextParametro.Name = "lblResNextParametro";
            this.lblResNextParametro.Size = new System.Drawing.Size(200, 46);
            this.lblResNextParametro.TabIndex = 3;
            this.lblResNextParametro.Text = "Resultado";
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(33, 171);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(721, 53);
            this.txtValor.TabIndex = 4;
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorInicial.Location = new System.Drawing.Point(33, 395);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(358, 53);
            this.txtValorInicial.TabIndex = 5;
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinal.Location = new System.Drawing.Point(417, 395);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(346, 53);
            this.txtValorFinal.TabIndex = 6;
            this.txtValorFinal.TextChanged += new System.EventHandler(this.txtValorFinal_TextChanged);
            // 
            // btnGerarIntervalo
            // 
            this.btnGerarIntervalo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarIntervalo.Location = new System.Drawing.Point(33, 463);
            this.btnGerarIntervalo.Name = "btnGerarIntervalo";
            this.btnGerarIntervalo.Size = new System.Drawing.Size(730, 82);
            this.btnGerarIntervalo.TabIndex = 8;
            this.btnGerarIntervalo.Text = "Next(int valorInicial, int valorFinal)";
            this.btnGerarIntervalo.UseVisualStyleBackColor = true;
            this.btnGerarIntervalo.Click += new System.EventHandler(this.btnGerarIntervalo_Click);
            // 
            // lblResValorIF
            // 
            this.lblResValorIF.AutoSize = true;
            this.lblResValorIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResValorIF.Location = new System.Drawing.Point(294, 575);
            this.lblResValorIF.Name = "lblResValorIF";
            this.lblResValorIF.Size = new System.Drawing.Size(200, 46);
            this.lblResValorIF.TabIndex = 9;
            this.lblResValorIF.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.lblResValorIF);
            this.Controls.Add(this.btnGerarIntervalo);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblResNextParametro);
            this.Controls.Add(this.btnNextParametro);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblResNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResNext;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnNextParametro;
        private System.Windows.Forms.Label lblResNextParametro;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Button btnGerarIntervalo;
        private System.Windows.Forms.Label lblResValorIF;
    }
}

