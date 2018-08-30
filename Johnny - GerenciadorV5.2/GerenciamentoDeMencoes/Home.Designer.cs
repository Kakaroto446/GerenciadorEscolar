namespace GerenciamentoDeMencoes
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnCadastros = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnRegistraMencao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnRelatorios = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastros
            // 
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.Location = new System.Drawing.Point(240, 64);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Size = new System.Drawing.Size(139, 52);
            this.btnCadastros.TabIndex = 0;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.UseVisualStyleBackColor = true;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(240, 122);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(139, 52);
            this.btnConsultas.TabIndex = 1;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnRegistraMencao
            // 
            this.btnRegistraMencao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistraMencao.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistraMencao.Location = new System.Drawing.Point(240, 180);
            this.btnRegistraMencao.Name = "btnRegistraMencao";
            this.btnRegistraMencao.Size = new System.Drawing.Size(139, 52);
            this.btnRegistraMencao.TabIndex = 2;
            this.btnRegistraMencao.Text = "Registrar";
            this.btnRegistraMencao.UseVisualStyleBackColor = true;
            this.btnRegistraMencao.Click += new System.EventHandler(this.btnRegistraMencao_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(240, 354);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(139, 52);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSobre
            // 
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSobre.Location = new System.Drawing.Point(240, 296);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.Size = new System.Drawing.Size(139, 52);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "Sobre";
            this.btnSobre.UseVisualStyleBackColor = true;
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Tw Cen MT Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.Location = new System.Drawing.Point(240, 238);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Size = new System.Drawing.Size(139, 52);
            this.btnRelatorios.TabIndex = 3;
            this.btnRelatorios.Text = "Relatórios";
            this.btnRelatorios.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(226, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(162, 23);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "School Manager";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 462);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSobre);
            this.Controls.Add(this.btnRelatorios);
            this.Controls.Add(this.btnRegistraMencao);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnCadastros);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastros;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnRegistraMencao;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnRelatorios;
        private System.Windows.Forms.Label lblTitulo;
    }
}