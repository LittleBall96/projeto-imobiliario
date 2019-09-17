namespace CM_Imobiliaria
{
    partial class FrmClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClientes));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtListarClientes = new System.Windows.Forms.TextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSair.Location = new System.Drawing.Point(736, 397);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(152, 47);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnInserir.Location = new System.Drawing.Point(736, 170);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(152, 47);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir Cliente";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAlterar.Location = new System.Drawing.Point(736, 223);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(152, 47);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar Cliente";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExcluir.Location = new System.Drawing.Point(736, 276);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(152, 47);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir Cliente";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(395, 375);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(116, 23);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar Cliente";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtListarClientes
            // 
            this.txtListarClientes.Location = new System.Drawing.Point(13, 377);
            this.txtListarClientes.Name = "txtListarClientes";
            this.txtListarClientes.Size = new System.Drawing.Size(373, 20);
            this.txtListarClientes.TabIndex = 10;
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(98, 70);
            this.mskTelefone.Mask = "(99)00000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(85, 20);
            this.mskTelefone.TabIndex = 65;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 170);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(709, 198);
            this.dgvClientes.TabIndex = 67;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(98, 35);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(288, 20);
            this.txtNome.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Nome:";
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdCliente.Location = new System.Drawing.Point(98, 9);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(55, 23);
            this.lblIdCliente.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 68;
            this.label6.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Id Cliente:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnLimpar.Location = new System.Drawing.Point(736, 55);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(152, 47);
            this.btnLimpar.TabIndex = 70;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblMensagem
            // 
            this.lblMensagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMensagem.Location = new System.Drawing.Point(80, 421);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(431, 23);
            this.lblMensagem.TabIndex = 85;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 84;
            this.label10.Text = "Mensagem:";
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(904, 461);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblIdCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListarClientes);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnSair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmClientes";
            this.Load += new System.EventHandler(this.FrmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtListarClientes;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Label label10;
    }
}