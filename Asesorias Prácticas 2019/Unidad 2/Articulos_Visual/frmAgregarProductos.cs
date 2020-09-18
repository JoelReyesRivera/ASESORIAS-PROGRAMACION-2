using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articulos_Visual
{
    public partial class frmAgregarProductos : Form
    {
        public frmAgregarProductos()
        {
            InitializeComponent();
        }

<<<<<<< HEAD:Asesorias Prácticas 2019/Unidad 2/Articulos_Visual/frmAgregarProductos.cs
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
=======
        private void altaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarProductos agregar = new frmAgregarProductos();
            agregar.Show();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDespliegueProductos frmProductos = new FrmDespliegueProductos();
            frmProductos.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
>>>>>>> master:Prácticas/Unidad 2/Articulos_Visual/FrmMenu.cs
        }
    }
}
