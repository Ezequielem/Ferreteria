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

        public Controlador_RegistrarProveedor()
        {
            Proveedor = new Proveedor();           
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

        public void nombreBancoSeleccionado(int banco)
        {
            Proveedor.Banco.mostrarDatos(banco);
            Proveedor.IdBanco = Proveedor.Banco.CodigoBanco;
        }

        public void cuentaCorrienteIngresada(string cc)
        {
            Proveedor.NroCuentaCorriente = cc;
        }

        public void tipoTelefono1Ingresado(int tipoTel)
        {
            Proveedor.IdTipoTelefonoUno = tipoTel;
        }

        public void numeroTelefono1Ingresado(string telefono)
        {
            Proveedor.NumeroDeTelefonoUno = telefono;
        }

        public void tipoTelefono2Ingresado(int tipoTel)
        {
            Proveedor.IdTipoTelefonoDos = tipoTel;
        }

        public void numeroTelefono2Ingresado(string telefono)
        {
            Proveedor.NumeroDeTelefonoDos = telefono;
        }

        public void localidadSeleccionada(int localidad)
        {
            Proveedor.Localidad.mostrarDatos(localidad);
            Proveedor.IdLocalidad = Proveedor.Localidad.CodigoLocalidad;
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
           return  Proveedor.Banco.mostrarDatos();
        }

        public List<TipoTelefono> mostrarDatosTiposTelefonos()
        {
            return Proveedor.TipoTelefono.mostrarDatos();
        }

        public List<Provincia> mostrarDatosProvincias()
        {
            return Proveedor.Localidad.Departamento.Provincia.mostrarDatos();
        }

        public List<Departamento> mostrarDatosDepartamento(int codigoProvincia)
        {
            return Proveedor.Localidad.Departamento.Provincia.conocerDepartamento(codigoProvincia);
        }

        public List<Localidad> mostrarDatosLocalidad(int codigoDepto)
        {
            return Proveedor.Localidad.Departamento.conocerLocalidad(codigoDepto);
        }

        public void crear()
        {
            buscarUltimoProveedor();
            Proveedor.crear(Proveedor);
        }       
    }
}
