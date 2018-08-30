namespace GerenciamentoDeMencoes
{
    partial class RegistroMencaoAluno
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.lblMencao = new System.Windows.Forms.Label();
            this.cmb_aluno = new System.Windows.Forms.ComboBox();
            this.cmb_disc = new System.Windows.Forms.ComboBox();
            this.cmb_mencao = new System.Windows.Forms.ComboBox();
            this.lblMat = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAluno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(106, 61);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(49, 17);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno:";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.Location = new System.Drawing.Point(109, 110);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(73, 17);
            this.lblDisciplina.TabIndex = 1;
            this.lblDisciplina.Text = "Disciplina:";
            // 
            // lblMencao
            // 
            this.lblMencao.AutoSize = true;
            this.lblMencao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMencao.Location = new System.Drawing.Point(109, 163);
            this.lblMencao.Name = "lblMencao";
            this.lblMencao.Size = new System.Drawing.Size(65, 17);
            this.lblMencao.TabIndex = 2;
            this.lblMencao.Text = "Menção:";
            // 
            // cmb_aluno
            // 
            this.cmb_aluno.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_aluno.FormattingEnabled = true;
            this.cmb_aluno.Location = new System.Drawing.Point(161, 58);
            this.cmb_aluno.Name = "cmb_aluno";
            this.cmb_aluno.Size = new System.Drawing.Size(121, 25);
            this.cmb_aluno.TabIndex = 3;
            // 
            // cmb_disc
            // 
            this.cmb_disc.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_disc.FormattingEnabled = true;
            this.cmb_disc.Location = new System.Drawing.Point(188, 107);
            this.cmb_disc.Name = "cmb_disc";
            this.cmb_disc.Size = new System.Drawing.Size(121, 25);
            this.cmb_disc.TabIndex = 4;
            // 
            // cmb_mencao
            // 
            this.cmb_mencao.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mencao.FormattingEnabled = true;
            this.cmb_mencao.Location = new System.Drawing.Point(180, 160);
            this.cmb_mencao.Name = "cmb_mencao";
            this.cmb_mencao.Size = new System.Drawing.Size(121, 25);
            this.cmb_mencao.TabIndex = 5;
            // 
            // lblMat
            // 
            this.lblMat.AutoSize = true;
            this.lblMat.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMat.Location = new System.Drawing.Point(339, 61);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(0, 17);
            this.lblMat.TabIndex = 6;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(342, 107);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(0, 17);
            this.lblCod.TabIndex = 7;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(435, 143);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(75, 37);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Registrar";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(105, 206);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(423, 217);
            this.dgv.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Registrar menções";
            // 
            // RegistroMencaoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.cmb_mencao);
            this.Controls.Add(this.cmb_disc);
            this.Controls.Add(this.cmb_aluno);
            this.Controls.Add(this.lblMencao);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblAluno);
            this.Name = "RegistroMencaoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.Load += new System.EventHandler(this.RegistroMencaoAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Label lblMencao;
        private System.Windows.Forms.ComboBox cmb_aluno;
        private System.Windows.Forms.ComboBox cmb_disc;
        private System.Windows.Forms.ComboBox cmb_mencao;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
    }
}