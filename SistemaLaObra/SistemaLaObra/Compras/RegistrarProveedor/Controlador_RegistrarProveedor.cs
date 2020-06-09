using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Compras.RegistrarProveedor
{
    class Controlador_RegistrarProveedor
    {
        public Proveedor Proveedor { get; set; }
        public Banco Banco { get; set; }
        public Provincia Provincia { get; set; }
        public Localidad Localidad { get; set; }
        public Departamento Departamento { get; set; }
        public TipoTelefono TipoTelefono { get; set; }

        public Controlador_RegistrarProveedor()
        {
            Proveedor = new Proveedor();
            Banco = new Banco();
            Provincia = new Provincia();
            Localidad = new Localidad();
            Departamento = new Departamento();
            TipoTelefono = new TipoTelefono();            
        }

        //METODOS

        public void numeroCuitIngresado(string cuit)
        {
            Proveedor.Cuit = cuit;
        }

        public void razonSocialIngresada(string razonSocial)
        {
            Proveedor.RazonSocial = razonSocial;
        }

        public void nombreBancoSeleccionado(string banco)
        {
            Proveedor.Banco = banco;
        }

        public void cuentaCorrienteIngresada(string cc)
        {
            Proveedor.NroCuentaCorriente = cc;
        }

        public void tipoTelefono1Ingresado(string tipoTel)
        {
            Proveedor.TipoTelefonoUno = tipoTel;
        }

        public void numeroTelefono1Ingresado(string telefono)
        {
            Proveedor.NumeroDeTelefonoUno = telefono;
        }

        public void tipoTelefono2Ingresado(string tipoTel)
        {
            Proveedor.TipoTelefonoDos = tipoTel;
        }

        public void numeroTelefono2Ingresado(string telefono)
        {
            Proveedor.NumeroDeTelefonoDos = telefono;
        }

        public void provinciaSeleccionada(string provincia)
        {
            Proveedor.Provincia= provincia;
        }

        public void localidadSeleccionada(string localidad)
        {
            Proveedor.Localidad = localidad;
        }

        public void departamentoSeleccionado(string departamento)
        {
            Proveedor.Departamento = departamento;
        }

        public void barrioSeleccionado(string barrio)
        {
            Proveedor.Barrio = barrio;
        }

        public void calleIngresada(string calle)
        {
            Proveedor.Calle = calle;
        }

        public void numeroDomicilioIngresado(string numeroDomicilio)
        {
            Proveedor.NumeroCasa = numeroDomicilio;
        }

        public void codigoPostalIngresado(string codPostal)
        {
            Proveedor.CodigoPostal = codPostal;
        }

        public void nombreFantasiaTomado(string nombre)
        {
            Proveedor.NombreFantasia = nombre;
        }

        public void nombreContacto1Tomado(string nombreContacto1)
        {
            Proveedor.NombreContactoUno = nombreContacto1;
        }

        public void nombreCargoContacto1Tomado(string nombreCargo1)
        {
            Proveedor.CargoContactoUno = nombreCargo1;
        }

        public void nombreContacto2Tomado(string nombreContacto2)
        {
            Proveedor.NombreContactoDos = nombreContacto2;
        }

        public void nombreCargoContacto2Tomado(string nombreCargo2)
        {
            Proveedor.CargoContactoDos = nombreCargo2;
        }

        public bool verificarExistencia(long cuit)
        {
            if (Proveedor.existe(cuit))
                return true;
            else
                return false;                        
        }

        private void buscarUltimoProveedor()
        {
            int valor = Proveedor.ultimoNroProveedor();
            if (valor != 0)
            {
                Proveedor.CodigoProveedor = (int)valor + 1;
            }
            else
            {
                Proveedor.CodigoProveedor = 1;
            }
        }

        public List<Banco> mostrarDatosBancos()
        {
           return  Banco.mostrarDatos();
        }

        public List<TipoTelefono> mostrarDatosTiposTelefonos()
        {
            TipoTelefono = new TipoTelefono();
            return TipoTelefono.mostrarDatosColeccion();
        }

        public List<Provincia> mostrarDatosProvincias()
        {
            return Provincia.mostrarDatosColeccion();
        }

        public List<Departamento> mostrarDatosDepartamento(int codigoProvincia)
        {
            Provincia = new Provincia();
            return Provincia.conocerDepartamento(codigoProvincia);
        }

        public List<Localidad> mostrarDatosLocalidad(int codigoDepto)
        {
            Departamento = new Departamento();
            return Departamento.conocerLocalidad(codigoDepto);
        }

        public void crear()
        {
            buscarUltimoProveedor();
            Proveedor.crear(Proveedor);
        }       
    }
}
