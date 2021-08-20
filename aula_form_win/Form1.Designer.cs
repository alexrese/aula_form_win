
namespace aula_form_win
{
    partial class From1
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbParteUm = new System.Windows.Forms.TextBox();
            this.btnExibir = new System.Windows.Forms.Button();
            this.tbParteDois = new System.Windows.Forms.TextBox();
            this.tbResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite alguma coisa:";
            // 
            // tbParteUm
            // 
            this.tbParteUm.Location = new System.Drawing.Point(101, 78);
            this.tbParteUm.Name = "tbParteUm";
            this.tbParteUm.Size = new System.Drawing.Size(100, 20);
            this.tbParteUm.TabIndex = 1;
            // 
            // btnExibir
            // 
            this.btnExibir.Location = new System.Drawing.Point(101, 105);
            this.btnExibir.Name = "btnExibir";
            this.btnExibir.Size = new System.Drawing.Size(75, 23);
            this.btnExibir.TabIndex = 2;
            this.btnExibir.Text = "Exibir";
            this.btnExibir.UseVisualStyleBackColor = true;
            this.btnExibir.Click += new System.EventHandler(this.btnExibir_Click);
            // 
            // tbParteDois
            // 
            this.tbParteDois.Location = new System.Drawing.Point(226, 78);
            this.tbParteDois.Name = "tbParteDois";
            this.tbParteDois.Size = new System.Drawing.Size(100, 20);
            this.tbParteDois.TabIndex = 3;
            // 
            // tbResultado
            // 
            this.tbResultado.Location = new System.Drawing.Point(101, 148);
            this.tbResultado.Name = "tbResultado";
            this.tbResultado.Size = new System.Drawing.Size(310, 20);
            this.tbResultado.TabIndex = 4;
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResultado);
            this.Controls.Add(this.tbParteDois);
            this.Controls.Add(this.btnExibir);
            this.Controls.Add(this.tbParteUm);
            this.Controls.Add(this.label1);
            this.Name = "From1";
            this.Text = "Formulário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbParteUm;
        private System.Windows.Forms.Button btnExibir;
        private System.Windows.Forms.TextBox tbParteDois;
        private System.Windows.Forms.TextBox tbResultado;
    }
}

