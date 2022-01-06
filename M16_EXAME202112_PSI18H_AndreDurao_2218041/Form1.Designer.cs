
namespace M16_EXAME202112_PSI18H_AndreDurao_2218041
{
    partial class Form1
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
            this.btnSubscricao = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSubscricao
            // 
            this.btnSubscricao.Location = new System.Drawing.Point(28, 12);
            this.btnSubscricao.Name = "btnSubscricao";
            this.btnSubscricao.Size = new System.Drawing.Size(93, 40);
            this.btnSubscricao.TabIndex = 0;
            this.btnSubscricao.Text = "Subscrição";
            this.btnSubscricao.UseVisualStyleBackColor = true;
            this.btnSubscricao.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.Location = new System.Drawing.Point(127, 12);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(93, 40);
            this.btnEmprestimo.TabIndex = 1;
            this.btnEmprestimo.Text = "Empréstimo";
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 65);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.btnSubscricao);
            this.Name = "Form1";
            this.Text = "gestão das subscrições e empréstimos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubscricao;
        private System.Windows.Forms.Button btnEmprestimo;
    }
}

