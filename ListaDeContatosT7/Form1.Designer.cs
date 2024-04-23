namespace ListaDeContatosT7
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.TextBoxNome = new System.Windows.Forms.TextBox();
            this.TextBoxSobrenome = new System.Windows.Forms.TextBox();
            this.TextBoxTelefone = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(340, 12);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(242, 316);
            this.ListBox.TabIndex = 4;
            // 
            // TextBoxNome
            // 
            this.TextBoxNome.Location = new System.Drawing.Point(48, 53);
            this.TextBoxNome.Name = "TextBoxNome";
            this.TextBoxNome.Size = new System.Drawing.Size(201, 20);
            this.TextBoxNome.TabIndex = 5;
            // 
            // TextBoxSobrenome
            // 
            this.TextBoxSobrenome.Location = new System.Drawing.Point(48, 101);
            this.TextBoxSobrenome.Name = "TextBoxSobrenome";
            this.TextBoxSobrenome.Size = new System.Drawing.Size(201, 20);
            this.TextBoxSobrenome.TabIndex = 6;
            // 
            // TextBoxTelefone
            // 
            this.TextBoxTelefone.Location = new System.Drawing.Point(48, 148);
            this.TextBoxTelefone.Name = "TextBoxTelefone";
            this.TextBoxTelefone.Size = new System.Drawing.Size(201, 20);
            this.TextBoxTelefone.TabIndex = 7;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(34, 221);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(227, 134);
            this.button.TabIndex = 8;
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 402);
            this.Controls.Add(this.button);
            this.Controls.Add(this.TextBoxTelefone);
            this.Controls.Add(this.TextBoxSobrenome);
            this.Controls.Add(this.TextBoxNome);
            this.Controls.Add(this.ListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.TextBox TextBoxNome;
        private System.Windows.Forms.TextBox TextBoxSobrenome;
        private System.Windows.Forms.TextBox TextBoxTelefone;
        private System.Windows.Forms.Button button;
    }
}

