using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Compras.EmitirListadoCompraProveedor
{
    public class Controlador_EmitirListadoCompraProveedor
    {
        //INSTANCIAS
        private IU_EmitirListadoCompraProveedor _interfazEmitirLCP;
        private IU_EmitirListadoCompraProveedor2 _interfazProveedores;
        private Compra _compra;
        private List<Compra> _listaCompra;
        private List<Compra> _listaCompraPorProveedor;
        private DetalleCompra _detalleCompra;
        private List<DetalleCompra> _listaDetalleCompra;
        private Proveedor _proveedor;
        private List<Proveedor> _proveedores;


        public Controlador_EmitirListadoCompraProveedor(IU_EmitirListadoCompraProveedor interfaz)
        {
            _interfazEmitirLCP = interfaz;
            _compra = new Compra();
            _listaCompra = new List<Compra>();
            _listaCompraPorProveedor = new List<Compra>();
            _detalleCompra = new DetalleCompra();
            _listaDetalleCompra = new List<DetalleCompra>();
            _proveedor = new Proveedor();
            _proveedores=new List<Proveedor>();          
    }        

        //METODOS

        public void buscarOrdenesCompraPendientes()
        {
            _listaCompra = _compra.mostrarDatosColeccionComprasRecibidas();
            foreach (var item in _listaCompra)
            {
                _interfazEmitirLCP.dgv_listaArticulos.Rows.Add(
                    item.CodigoCompra.ToString("000000000"),
                    item.FechaHora.ToShortDateString(),
                    item.ImporteTotal.ToString("$ 0.00"),
                    item.conocerEncargado(item.CodigoEncargadoCompra).Nombre+" "+item.conocerEncargado(item.CodigoEncargadoCompra).Apellido,
                    item.conocerEncargado(item.CodigoEncargadoCompra).Legajo,                    
                    "Consultar"                    
                    );
            }
        }

        public void generarListadoDeCompraPorProveedor(int codigoCompra)
        {
            _listaDetalleCompra=_compra.mostrarDetalleCompra(codigoCompra);

        }

        public void mostrarInterfazProveedores()
        {            
            _interfazProveedores = new IU_EmitirListadoCompraProveedor2(this);
            _interfazProveedores.ListaProveedores = _proveedores;
            _interfazProveedores.ListaDetalleCompra = _listaDetalleCompra;
            _interfazProveedores.Compra = _compra;
            _interfazProveedores.ShowDialog();
        }

        public void ordenDeCompraTomada(int codigoCompra)
        {
            _compra.mostrarDatos(codigoCompra);            
        }

        public void buscarDetalleDeCompra(int codigoCompra)
        {
            _listaDetalleCompra.Clear();
            _listaDetalleCompra=_detalleCompra.mostrarDatosColeccion(codigoCompra);
        }

        public void obtenerProveedores()
        {
            _proveedores.Clear();
            int b = 0;
            foreach (var item in _listaDetalleCompra)
            {
                if (b==0)
                {
                    
                    _proveedores.Add(_proveedor.obtenerDatosProveedor(item.CodigoProveedor));
                    b = 1;
                }
                else
                {                    
                    if (!_proveedores.Exists(x=>x.CodigoProveedor==item.CodigoProveedor))
                    {
                        _proveedores.Add(_proveedor.obtenerDatosProveedor(item.CodigoProveedor));
                    }                    
                }
            }
        }

        public List<DetalleCompra> generarListaDetallePorProveedor(int codigoDeProveedor)
        {
            return _listaDetalleCompra.FindAll(x => x.CodigoProveedor == codigoDeProveedor);
        }
    }
}
