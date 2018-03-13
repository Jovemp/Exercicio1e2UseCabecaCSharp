namespace Exericio02
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
            this.button1 = new System.Windows.Forms.Button();
            this.ckAlteraCor = new System.Windows.Forms.CheckBox();
            this.lbRotulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "Altera a cor caso o box estiver checado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ckAlteraCor
            // 
            this.ckAlteraCor.AutoSize = true;
            this.ckAlteraCor.Location = new System.Drawing.Point(190, 37);
            this.ckAlteraCor.Name = "ckAlteraCor";
            this.ckAlteraCor.Size = new System.Drawing.Size(150, 17);
            this.ckAlteraCor.TabIndex = 1;
            this.ckAlteraCor.Text = "Habilita a alteração da cor";
            this.ckAlteraCor.UseVisualStyleBackColor = true;
            // 
            // lbRotulo
            // 
            this.lbRotulo.AutoSize = true;
            this.lbRotulo.BackColor = System.Drawing.Color.Red;
            this.lbRotulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRotulo.Location = new System.Drawing.Point(12, 90);
            this.lbRotulo.Name = "lbRotulo";
            this.lbRotulo.Size = new System.Drawing.Size(335, 20);
            this.lbRotulo.TabIndex = 2;
            this.lbRotulo.Text = "Pressione o botão para alterar minha cor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 127);
            this.Controls.Add(this.lbRotulo);
            this.Controls.Add(this.ckAlteraCor);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Trabalhando com IF e Else";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ckAlteraCor;
        private System.Windows.Forms.Label lbRotulo;
    }
}

