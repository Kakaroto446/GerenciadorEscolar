namespace GerenciamentoDeMencoes
{
    partial class ConsultaCadDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaCadDisc));
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuant = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o campo:";
            // 
            // cmbCampo
            // 
            this.cmbCampo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "Código",
            "Descrição",
            "Sigla",
            "Série"});
            this.cmbCampo.Location = new System.Drawing.Point(175, 66);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(125, 25);
            this.cmbCampo.TabIndex = 1;
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisar.Location = new System.Drawing.Point(379, 68);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(132, 23);
            this.txt_pesquisar.TabIndex = 2;
            this.txt_pesquisar.TextChanged += new System.EventHandler(this.txt_pesquisar_TextChanged);
            // 
            // dgv_disc
            // 
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.Location = new System.Drawing.Point(33, 120);
            this.dgv_disc.Name = "dgv_disc";
            this.dgv_disc.Size = new System.Drawing.Size(434, 150);
            this.dgv_disc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "pesquise:";
            // 
            // btnQuant
            // 
            this.btnQuant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuant.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuant.Location = new System.Drawing.Point(479, 120);
            this.btnQuant.Name = "btnQuant";
            this.btnQuant.Size = new System.Drawing.Size(101, 63);
            this.btnQuant.TabIndex = 17;
            this.btnQuant.Text = "quantidade de selecionados";
            this.btnQuant.UseVisualStyleBackColor = true;
            this.btnQuant.Click += new System.EventHandler(this.btnQuant_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisualizar.Location = new System.Drawing.Point(479, 229);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(101, 41);
            this.btnVisualizar.TabIndex = 16;
            this.btnVisualizar.Text = "visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = true;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(479, 189);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(101, 34);
            this.btnImprimir.TabIndex = 15;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(321, 23);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Consulta Cadastral de Disciplinas";
            // 
            // ConsultaCadDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 462);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnQuant);
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_disc);
            this.Controls.Add(this.txt_pesquisar);
            this.Controls.Add(this.cmbCampo);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaCadDisc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Manager";
            this.Load += new System.EventHandler(this.ConsultaCadDisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.DataGridView dgv_disc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuant;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lblTitulo;
    }
}