using Marzo9.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Marzo9.srv
{
    public class ProductoSrv
    {
        // campo estatica (singleton), equivalente a una variable global
        public static List<Producto> listadoEstatico = new List<Producto>();

        // con el boton derecho (encima de Producto):
        // Quick actions -> add using.
        // mockup
        public List<Producto> ListarTodo()
        {            
            return new List<Producto>(listadoEstatico); // una lista nueva basado en el singleton.
        }
        public bool Insertar(Producto prod)
        {
            var resultado = true;
            //todo: pendiente.
            listadoEstatico.Add(prod);

            return resultado;
        }
        public bool Actualizar(Producto prod)
        {
            var resultado = true;
            //todo: pendiente.

            return resultado;
        }
    }
}
