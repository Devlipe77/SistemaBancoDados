using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBancoDados
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();            
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            using (var Frm = new FrmClientes())
            {
                Frm.ShowDialog();
            };
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            using (var Frm = new FrmPedidos())
            {
                Frm.ShowDialog();
            };
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            using (var Frm = new FrmProdutos())
            {
                Frm.ShowDialog();
            };
        }
    }
}
