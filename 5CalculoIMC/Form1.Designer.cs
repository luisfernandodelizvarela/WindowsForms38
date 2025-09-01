namespace _5CalculoIMC
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
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblClassificacao = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPeso
            // 
<<<<<<< HEAD
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(18, 19);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(457, 46);
            this.lblPeso.TabIndex = 0;
            this.lblPeso.Text = "Informe o seu peso: (Kg)";
=======
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o seu peso: (Kg)";
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            // 
            // lblAltura
            // 
<<<<<<< HEAD
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(18, 153);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(453, 46);
            this.lblAltura.TabIndex = 1;
            this.lblAltura.Text = "Informe a sua altura: (m)";
=======
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(309, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe a sua altura: (m)";
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            // 
            // txtPeso
            // 
<<<<<<< HEAD
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(22, 84);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(797, 53);
            this.txtPeso.TabIndex = 2;
=======
            this.txtBoxPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPeso.Location = new System.Drawing.Point(15, 55);
            this.txtBoxPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPeso.Name = "txtBoxPeso";
            this.txtBoxPeso.Size = new System.Drawing.Size(533, 38);
            this.txtBoxPeso.TabIndex = 2;
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            // 
            // txtAltura
            // 
<<<<<<< HEAD
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(22, 220);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(797, 53);
            this.txtAltura.TabIndex = 3;
=======
            this.txtBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAltura.Location = new System.Drawing.Point(15, 143);
            this.txtBoxAltura.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxAltura.Name = "txtBoxAltura";
            this.txtBoxAltura.Size = new System.Drawing.Size(533, 38);
            this.txtBoxAltura.TabIndex = 3;
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(15, 268);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(531, 72);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular o IMC";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblResultado.Location = new System.Drawing.Point(120, 323);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(200, 46);
=======
            this.lblResultado.Location = new System.Drawing.Point(73, 210);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(137, 31);
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // lblClassificacao
            // 
            this.lblClassificacao.AutoSize = true;
            this.lblClassificacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.lblClassificacao.Location = new System.Drawing.Point(474, 323);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(258, 46);
=======
            this.lblClassificacao.Location = new System.Drawing.Point(323, 210);
            this.lblClassificacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassificacao.Name = "lblClassificacao";
            this.lblClassificacao.Size = new System.Drawing.Size(176, 31);
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            this.lblClassificacao.TabIndex = 6;
            this.lblClassificacao.Text = "Classificação";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(435, 359);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(111, 56);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
<<<<<<< HEAD
            this.btnLimpar.Location = new System.Drawing.Point(353, 552);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(276, 86);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR CAMPOS";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.button1_Click);
=======
            this.btnLimpar.Location = new System.Drawing.Point(235, 359);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(184, 56);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "LIMPAR CAMPOS";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(850, 663);
=======
            this.ClientSize = new System.Drawing.Size(567, 431);
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblClassificacao);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
<<<<<<< HEAD
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
=======
            this.Controls.Add(this.txtBoxAltura);
            this.Controls.Add(this.txtBoxPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
>>>>>>> 96e798d8c847f91ee1d4bb41f4e1d8aacbfbf35c
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblClassificacao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
    }
}

