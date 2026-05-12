using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Banco_de_dados;

namespace SistemaBancoDados
{
    public partial class FrmPedidos : Form
    {
        private ConexaoDB dbInstance = new ConexaoDB();
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNomeFil.Text.Trim() != string.Empty)
            {
                try
                {
                    DataTable dt = dbInstance.ExecutarConsulta($"SELECT * FROM orders WHERE CustomerID = '{txtNomeFil.Text.Trim()}' ");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar pedidos do cliente.\n{ex.Message}");
                }
            }
            else
            {
                try
                {
                    DataTable dt = dbInstance.ExecutarConsulta("SELECT * FROM orders");
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar pedidos do cliente.\n{ex.Message}");
                }
            }
        }

        private void FrmPedidos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar_Click(sender, e);
            } 
            else if (e.KeyCode == Keys.Escape) 
            {
                Close();            
            }
        }
    }
}
