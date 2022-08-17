namespace teste_GoogleAPI
{
    partial class Form2
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
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.txSenhaCadastro = new System.Windows.Forms.TextBox();
            this.txLoginCadastro = new System.Windows.Forms.TextBox();
            this.txConfirmaCadastro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(47, 205);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(151, 37);
            this.buttonCadastrar.TabIndex = 5;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // txSenhaCadastro
            // 
            this.txSenhaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenhaCadastro.ForeColor = System.Drawing.Color.Silver;
            this.txSenhaCadastro.Location = new System.Drawing.Point(47, 97);
            this.txSenhaCadastro.Name = "txSenhaCadastro";
            this.txSenhaCadastro.Size = new System.Drawing.Size(151, 26);
            this.txSenhaCadastro.TabIndex = 4;
            this.txSenhaCadastro.Text = "Senha";
            // 
            // txLoginCadastro
            // 
            this.txLoginCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txLoginCadastro.ForeColor = System.Drawing.Color.Silver;
            this.txLoginCadastro.Location = new System.Drawing.Point(47, 51);
            this.txLoginCadastro.Name = "txLoginCadastro";
            this.txLoginCadastro.Size = new System.Drawing.Size(151, 26);
            this.txLoginCadastro.TabIndex = 3;
            this.txLoginCadastro.Text = "Login";
            // 
            // txConfirmaCadastro
            // 
            this.txConfirmaCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmaCadastro.ForeColor = System.Drawing.Color.Silver;
            this.txConfirmaCadastro.Location = new System.Drawing.Point(47, 146);
            this.txConfirmaCadastro.Name = "txConfirmaCadastro";
            this.txConfirmaCadastro.Size = new System.Drawing.Size(151, 26);
            this.txConfirmaCadastro.TabIndex = 6;
            this.txConfirmaCadastro.Text = "Confirmar";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 311);
            this.Controls.Add(this.txConfirmaCadastro);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.txSenhaCadastro);
            this.Controls.Add(this.txLoginCadastro);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.TextBox txSenhaCadastro;
        private System.Windows.Forms.TextBox txLoginCadastro;
        private System.Windows.Forms.TextBox txConfirmaCadastro;
    }
}