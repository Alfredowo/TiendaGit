using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTiendaGit
{
    public class Productos
    {
        public Productos(int id, string nombre, string descripcion, int precio)
        {
            Id = id;
            Nombre = nombre;
            Precio = precio;
            Descripcion = descripcion;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public string Descripcion { get; set; }
    }
}
