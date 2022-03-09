using Marzo9.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marzo9.srv
{
    [ExcludeFromCodeCoverage]
    public class ProductoUI
    {
        public Producto Factory(TextBox txtnum,TextBox txtNombre,TextBox txtPrecio,TextBox txtStock)
        {
            var resultado = new Producto();
            resultado.Num = int.Parse(txtnum.Text);
            resultado.Nombre = txtNombre.Text;
            resultado.Precio = int.Parse(txtPrecio.Text);
            resultado.Stock = int.Parse(txtStock.Text);
            return resultado;
        }
        public void CargarFormulario(Producto prod,
            TextBox txtnum,
            TextBox txtNombre,
            TextBox txtPrecio,
            TextBox txtStock)
        {
            txtnum.Text = prod.Num.ToString();
            txtNombre.Text = prod.Nombre;
            txtPrecio.Text = prod.Precio.ToString();
            txtStock.Text = prod.Stock.ToString();
        }

    }
}
