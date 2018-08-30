namespace GerenciamentoDeMencoes
{
    partial class CadDisc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSerie = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtSigla = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.txb_pesquisar = new System.Windows.Forms.TextBox();
            this.lbl_pesquisar = new System.Windows.Forms.Label();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_primeiro = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(129, 154);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(100, 26);
            this.txtSerie.TabIndex = 55;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(90, 47);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(0, 20);
            this.lblCod.TabIndex = 54;
            // 
            // btnLimpar
            // 
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(33, 344);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 33);
            this.btnLimpar.TabIndex = 53;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(33, 236);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(90, 30);
            this.btnSalvar.TabIndex = 52;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtSigla
            // 
            this.txtSigla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSigla.Location = new System.Drawing.Point(129, 122);
            this.txtSigla.Name = "txtSigla";
            this.txtSigla.Size = new System.Drawing.Size(100, 26);
            this.txtSigla.TabIndex = 48;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(129, 91);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 26);
            this.txtDesc.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Série: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "Sigla: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "Descrição: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "Código: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cadastro de disciplinas";
            // 
            // btn_novo
            // 
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(515, 198);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(90, 30);
            this.btn_novo.TabIndex = 67;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = true;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click_1);
            // 
            // txb_pesquisar
            // 
            this.txb_pesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_pesquisar.Location = new System.Drawing.Point(398, 469);
            this.txb_pesquisar.Name = "txb_pesquisar";
            this.txb_pesquisar.Size = new System.Drawing.Size(174, 26);
            this.txb_pesquisar.TabIndex = 66;
            this.txb_pesquisar.TextChanged += new System.EventHandler(this.txb_pesquisar_TextChanged);
            // 
            // lbl_pesquisar
            // 
            this.lbl_pesquisar.AutoSize = true;
            this.lbl_pesquisar.BackColor = System.Drawing.Color.Black;
            this.lbl_pesquisar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pesquisar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_pesquisar.Location = new System.Drawing.Point(236, 472);
            this.lbl_pesquisar.Name = "lbl_pesquisar";
            this.lbl_pesquisar.Size = new System.Drawing.Size(156, 20);
            this.lbl_pesquisar.TabIndex = 65;
            this.lbl_pesquisar.Text = "Pesquisar por nome:";
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ultimo.Location = new System.Drawing.Point(419, 198);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(90, 30);
            this.btn_ultimo.TabIndex = 64;
            this.btn_ultimo.Text = "Último";
            this.btn_ultimo.UseVisualStyleBackColor = true;
            this.btn_ultimo.Click += new System.EventHandler(this.btn_ultimo_Click_1);
            // 
            // btn_proximo
            // 
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proximo.Location = new System.Drawing.Point(323, 198);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(90, 30);
            this.btn_proximo.TabIndex = 63;
            this.btn_proximo.Text = "Próximo";
            this.btn_proximo.UseVisualStyleBackColor = true;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click_1);
            // 
            // btn_anterior
            // 
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_anterior.Location = new System.Drawing.Point(227, 198);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(90, 30);
            this.btn_anterior.TabIndex = 62;
            this.btn_anterior.Text = "Anterior";
            this.btn_anterior.UseVisualStyleBackColor = true;
            this.btn_anterior.Click += new System.EventHandler(this.btn_anterior_Click_1);
            // 
            // btn_primeiro
            // 
            this.btn_primeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primeiro.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_primeiro.Location = new System.Drawing.Point(131, 198);
            this.btn_primeiro.Name = "btn_primeiro";
            this.btn_primeiro.Size = new System.Drawing.Size(90, 30);
            this.btn_primeiro.TabIndex = 61;
            this.btn_primeiro.Text = "Primeiro";
            this.btn_primeiro.UseVisualStyleBackColor = true;
            this.btn_primeiro.Click += new System.EventHandler(this.btn_primeiro_Click_1);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_alterar.Location = new System.Drawing.Point(33, 308);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(90, 30);
            this.btn_alterar.TabIndex = 60;
            this.btn_alterar.Text = "Alterar";
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click_1);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.Location = new System.Drawing.Point(33, 272);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(90, 30);
            this.btn_excluir.TabIndex = 59;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click_1);
            // 
            // dgv_disc
            // 
            this.dgv_disc.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.dgv_disc.BackgroundColor = System.Drawing.Color.Gray;
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.GridColor = System.Drawing.Color.IndianRed;
            this.dgv_disc.Location = new System.Drawing.Point(131, 236);
            this.dgv_disc.Name = "dgv_disc";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_disc.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_disc.Size = new System.Drawing.Size(474, 155);
            this.dgv_disc.TabIndex = 58;
            this.dgv_disc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_disc_CellContentClick);
            this.dgv_disc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgv_disc_KeyUp);
            // 
            // CadDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 462);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.txb_pesquisar);
            this.Controls.Add(this.lbl_pesquisar);
            this.Controls.Add(this.btn_ultimo);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_primeiro);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.dgv_disc);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSigla);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadDisc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.Load += new System.EventHandler(this.CadDisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtSerie;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtSigla;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txb_pesquisar;
        private System.Windows.Forms.Label lbl_pesquisar;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_primeiro;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.DataGridView dgv_disc;
    }
}