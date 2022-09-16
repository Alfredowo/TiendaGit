using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConectarBd;
using EntidadesTiendaGit;

namespace AccesoDatosTiendaGit
{
    public class aProductos
    {
        Base b = new Base("localhost", "root", "", "tiendagit", 3306);
        public void Borrar(Productos Entidad)
        {
            b.Comando(string.Format("delete from producto where id = {0}",
                Entidad.Id));
        }

        public void Guardar(Productos Entidad)
        {
            b.Comando(string.Format("CALL insertarproductos({0}, '{1}', '{2}', {3});",
                Entidad.Id, Entidad.Nombre, Entidad.Descripcion, Entidad.Precio));
        }

        public DataSet Mostrar()
        {
            return b.Obtener
                (string.Format("SELECT * FROM producto"), "producto");
        }
    }
}
