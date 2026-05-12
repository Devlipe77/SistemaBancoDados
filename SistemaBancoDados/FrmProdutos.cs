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
    public partial class FrmProdutos : Form
    {
        private ConexaoDB dbInstance = new ConexaoDB();
        public FrmProdutos()
        {
            InitializeComponent();

            try
            {
                DataTable dt = dbInstance.ExecutarConsulta("SELECT ProductName, UnitPrice, UnitsInStock FROM products;");
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pedidos do cliente.\n{ex.Message}");
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //
        }

        private void FrmProdutos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
