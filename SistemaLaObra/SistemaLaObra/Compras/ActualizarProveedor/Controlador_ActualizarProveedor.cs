using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Compras.ActualizarProveedor
{    
    public class Controlador_ActualizarProveedor
    {
        //INSTANCIAS
        private IU_ActualizarProveedor _interfazProveedor;
        public Proveedor Proveedor { get; set; }

        public Controlador_ActualizarProveedor(IU_ActualizarProveedor interfaz)
        {
            _interfazProveedor = interfaz;
            Proveedor = new Proveedor();
        }

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
            Proveedor.IdBanco = banco;
        }

        public void cuentaCorrienteIngresada(string cc)
        {
            Proveedor.NroCuentaCorriente = cc;
        }

        public void tipoTelefono1Ingresado(int tipoTel)
        {
            Proveedor.IdTipoTelefonoUno=tipoTel;
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
            Proveedor.IdLocalidad = localidad;
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

        public bool verificarExistencia(string cuit)
        {            
            if (Proveedor.existe(long.Parse(cuit)))
                return true;
            else
                return false;
        }

        public List<Banco> mostrarDatosBancos()
        {
            return Proveedor.Banco.mostrarDatos();
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

        public void modificar()
        {
            Proveedor.actualizar(Proveedor);
        }
    }
}
