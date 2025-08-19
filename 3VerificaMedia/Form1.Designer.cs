namespace _3VerificaMedia
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPrimeiraNota = new System.Windows.Forms.TextBox();
            this.txtBoxSegundaNota = new System.Windows.Forms.TextBox();
            this.btnVerificaAprov = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe a primeira nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe a segunda nota:";
            // 
            // txtBoxPrimeiraNota
            // 
            this.txtBoxPrimeiraNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPrimeiraNota.Location = new System.Drawing.Point(35, 61);
            this.txtBoxPrimeiraNota.Name = "txtBoxPrimeiraNota";
            this.txtBoxPrimeiraNota.Size = new System.Drawing.Size(445, 53);
            this.txtBoxPrimeiraNota.TabIndex = 2;
            // 
            // txtBoxSegundaNota
            // 
            this.txtBoxSegundaNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSegundaNota.Location = new System.Drawing.Point(35, 186);
            this.txtBoxSegundaNota.Name = "txtBoxSegundaNota";
            this.txtBoxSegundaNota.Size = new System.Drawing.Size(445, 53);
            this.txtBoxSegundaNota.TabIndex = 3;
            // 
            // btnVerificaAprov
            // 
            this.btnVerificaAprov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnVerificaAprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificaAprov.Location = new System.Drawing.Point(35, 266);
            this.btnVerificaAprov.Name = "btnVerificaAprov";
            this.btnVerificaAprov.Size = new System.Drawing.Size(445, 94);
            this.btnVerificaAprov.TabIndex = 4;
            this.btnVerificaAprov.Text = "Verifica aprovação";
            this.btnVerificaAprov.UseVisualStyleBackColor = false;
            this.btnVerificaAprov.Click += new System.EventHandler(this.btnVerificaAprov_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(522, 411);
            this.Controls.Add(this.btnVerificaAprov);
            this.Controls.Add(this.txtBoxSegundaNota);
            this.Controls.Add(this.txtBoxPrimeiraNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPrimeiraNota;
        private System.Windows.Forms.TextBox txtBoxSegundaNota;
        private System.Windows.Forms.Button btnVerificaAprov;
    }
}

