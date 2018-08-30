namespace GerenciamentoDeMencoes
{
    partial class Consultas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadDisc = new System.Windows.Forms.Button();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Você deseja consultar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Consultas";
            // 
            // btnCadDisc
            // 
            this.btnCadDisc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadDisc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadDisc.Location = new System.Drawing.Point(242, 235);
            this.btnCadDisc.Name = "btnCadDisc";
            this.btnCadDisc.Size = new System.Drawing.Size(139, 52);
            this.btnCadDisc.TabIndex = 7;
            this.btnCadDisc.Text = "Disciplina";
            this.btnCadDisc.UseVisualStyleBackColor = true;
            this.btnCadDisc.Click += new System.EventHandler(this.btnCadDisc_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadAluno.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadAluno.Location = new System.Drawing.Point(242, 177);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(139, 52);
            this.btnCadAluno.TabIndex = 6;
            this.btnCadAluno.Text = "Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadDisc);
            this.Controls.Add(this.btnCadAluno);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadDisc;
        private System.Windows.Forms.Button btnCadAluno;
    }
}