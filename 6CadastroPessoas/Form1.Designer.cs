namespace _5CadastroPessoas
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
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.listBoxNomes = new System.Windows.Forms.ListBox();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o nome a ser cadastrado:";
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Location = new System.Drawing.Point(12, 62);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(371, 26);
            this.txtBoxNome.TabIndex = 1;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 117);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(371, 73);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // listBoxNomes
            // 
            this.listBoxNomes.FormattingEnabled = true;
            this.listBoxNomes.ItemHeight = 20;
            this.listBoxNomes.Location = new System.Drawing.Point(406, 14);
            this.listBoxNomes.Name = "listBoxNomes";
            this.listBoxNomes.Size = new System.Drawing.Size(348, 424);
            this.listBoxNomes.TabIndex = 3;
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.Location = new System.Drawing.Point(16, 222);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(367, 216);
            this.btnVisualizar.TabIndex = 4;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.listBoxNomes);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox listBoxNomes;
        private System.Windows.Forms.Button btnVisualizar;
    }
}

