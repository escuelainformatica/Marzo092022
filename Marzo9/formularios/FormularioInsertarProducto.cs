using Marzo9.modelo;
using Marzo9.srv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marzo9.formularios
{
    [ExcludeFromCodeCoverage]
    public partial class FormularioInsertarProducto : Form
    {
        public FormularioInsertarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductoUI productoUI = new ProductoUI();
            ProductoSrv productoSrv = new ProductoSrv();
            // 1)
            Producto prod = productoUI.Factory(txtNum, txtNombre, txtPrecio, txtStock);
            // 2) 
            productoSrv.Insertar(prod);

            Close(); // cierro el formulario.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductoUI productoUI = new ProductoUI();
            ProductoSrv productoSrv = new ProductoSrv();
            // 1)
            Producto prod = productoUI.Factory(txtNum, txtNombre, txtPrecio, txtStock);
            // 2) 
            productoSrv.Insertar(prod);

            Producto prodVacio = new Producto();
            productoUI.CargarFormulario(prodVacio, txtNum, txtNombre, txtPrecio, txtStock);
        }
    }
}
