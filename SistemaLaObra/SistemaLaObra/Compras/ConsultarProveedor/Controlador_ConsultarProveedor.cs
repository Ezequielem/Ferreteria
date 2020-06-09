using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Compras.ConsultarProveedor
{
    public class Controlador_ConsultarProveedor
    {
        private IU_ConsultarProveedor _interfazCP;
        public Proveedor Proveedor { get; set; }
        public List<Proveedor> ListaProveedores { get; set; }

        public Controlador_ConsultarProveedor(IU_ConsultarProveedor interfaz)
        {
            _interfazCP = interfaz;
            Proveedor = new Proveedor();
            ListaProveedores = new List<Proveedor>();
        }

        //METODOS

        public void listadoProveedores()
        {
            ListaProveedores = Proveedor.mostrarDatos();
        }
    }
}
