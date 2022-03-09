using Marzo9.modelo;
using Marzo9.srv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marzo9.formularios
{
    public partial class FormularioModificarProducto : Form
    {
        // propiedad
        public Producto Prod { set; get; }
        // campo
        private ProductoUI productoUI = new ProductoUI();
        private ProductoSrv productoSrv = new ProductoSrv();


        public FormularioModificarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = productoUI.Factory(txtNum, txtNombre, txtPrecio, txtStock);
            productoSrv.Actualizar(producto);
        }

        private void FormularioModificarProducto_Load(object sender, EventArgs e)
        {
            productoUI.CargarFormulario(Prod, txtNum, txtNombre, txtPrecio, txtStock);
        }
    }
}
