namespace SistemaBancoDados
{
    partial class FrmMain
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
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.Tan;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(135, 88);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(279, 43);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.Tan;
            this.btnPedidos.FlatAppearance.BorderSize = 0;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(135, 147);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(279, 43);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.Tan;
            this.btnProdutos.FlatAppearance.BorderSize = 0;
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.Location = new System.Drawing.Point(135, 206);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(279, 43);
            this.btnProdutos.TabIndex = 2;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(553, 345);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnProdutos;
    }
}

