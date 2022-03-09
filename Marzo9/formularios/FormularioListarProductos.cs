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
    public partial class FormularioListarProductos : Form
    {
        // propiedades
        public int Prop1 { set; get; }
        // campo
        private int campo;
        // campo
        private ProductoSrv productoSrv = new ProductoSrv();

        public FormularioListarProductos()
        {
            InitializeComponent();
        }

        private void FormularioListarProductos_Load(object sender, EventArgs e)
        {
            // aqui los elementos visuales ya estan visibles.
           
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = productoSrv.ListarTodo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = productoSrv.ListarTodo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var formulario = new FormularioInsertarProducto();
            // mostrar de manera exclusive.
            formulario.ShowDialog();

            buttonRefresh_Click(null, null);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=2)
            {
                // no hago nada
                return;
            }
            if(e.RowIndex<0)
            {
                // no hago nada
                return;
            }
            var formulario = new FormularioModificarProducto();

            // cast: especificar el tipo de datos
            // dataGridView1.DataSource as List<Producto>
            List<Producto> listado = dataGridView1.DataSource as List<Producto>;

            Producto prodSeleccionado = listado[e.RowIndex];

            formulario.Prod = prodSeleccionado;

            formulario.ShowDialog();

        }

 

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = productoSrv.ListarTodo();
            dataGridView1.Update();
            // refresca la interface visual, no los datos
            dataGridView1.Refresh();
        }
    }
}
