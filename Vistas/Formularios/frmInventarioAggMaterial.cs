using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas.Formularios
{
    public partial class frmInventarioAggMaterial : Form
    {
        public frmInventarioAggMaterial()
        {
            InitializeComponent();
        }

        private void frmInventarioAggMaterial_Load(object sender, EventArgs e)
        {
            //AjustarDgvMostrarMaterial();
        }

        private void AjustarDgvMostrarMaterial()
        {
            var height = dgvMaterialAgregado.ColumnHeadersHeight;
            foreach (DataGridViewRow dr in dgvMaterialAgregado.Rows)
            {
                height += dr.Height;
            }
            dgvMaterialAgregado.Height = height;
            

        }
    }
}
