using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ManejadorTiendaGit;
using EntidadesTiendaGit;

namespace PresentacionTiendaGit
{
    public partial class frmProductosRegistro : Form
    {
        mProductos manejador;

        public frmProductosRegistro()
        {
            InitializeComponent();
            manejador = new mProductos();
            if (frmProductos.entidad.Id > 0) //actualizar 
            {
                txtNombre.Text = frmProductos.entidad.Nombre.ToString();
                txtPrecio.Text = frmProductos.entidad.Precio.ToString();
                txtDescripcion.Text = frmProductos.entidad.Descripcion.ToString();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtNombre.Text == null)
            {
                MessageBox.Show("esta nulo el conchaesumare", "Error");
            }
            else
            {
                manejador.Guardar(new Productos(
                    frmProductos.entidad.Id,
                    txtNombre.Text,
                    txtDescripcion.Text,
                    int.Parse(txtPrecio.Text)
                    ));
                Close();
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
