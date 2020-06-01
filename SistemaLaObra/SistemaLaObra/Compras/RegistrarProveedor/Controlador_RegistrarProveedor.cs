using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Compras.RegistrarProveedor
{
    class Controlador_RegistrarProveedor
    {
        //INSTANCIAS
        Proveedor proveedor;
        Banco banco;
        Provincia provincia;
        Localidad localidad;
        Departamento departamento;
        TipoTelefono tipoTelefono;
        


        public Controlador_RegistrarProveedor()
        {
            proveedor = new Proveedor();
            banco = new Banco();
            provincia = new Provincia();
            localidad = new Localidad();
            departamento = new Departamento();
            tipoTelefono = new TipoTelefono();
            
        }


        //METODOS

        public void numeroCuitIngresado(long cuit)
        {
            proveedor.Cuit = cuit;
        }

        public void razonSocialIngresada(string razonSocial)
        {
            proveedor.RazonSocial = razonSocial;
        }

        public void nombreBancoSeleccionado(string banco)
        {
            proveedor.Banco = banco;
        }

        public void cuentaCorrienteIngresada(long cc)
        {
            proveedor.NroCuentaCorriente = cc;
        }

        public void tipoTelefono1Ingresado(string tipoTel)
        {
            proveedor.TipoTelefonoUno = tipoTel;
        }

        public void numeroTelefono1Ingresado(long telefono)
        {
            proveedor.NumeroDeTelefonoUno = telefono;
        }

        public void tipoTelefono2Ingresado(string tipoTel)
        {
            proveedor.TipoTelefonoDos = tipoTel;
        }

        public void numeroTelefono2Ingresado(long telefono)
        {
            proveedor.NumeroDeTelefonoDos = telefono;
        }

        public void provinciaSeleccionada(string provincia)
        {
            proveedor.Provincia= provincia;
        }

        public void localidadSeleccionada(string localidad)
        {
            proveedor.Localidad = localidad;
        }

        public void departamentoSeleccionado(string departamento)
        {
            proveedor.Departamento = departamento;
        }

        public void barrioSeleccionado(string barrio)
        {
            proveedor.Barrio = barrio;
        }


        public void calleIngresada(string calle)
        {
            proveedor.Calle = calle;
        }

        public void numeroDomicilioIngresado(int numeroDomicilio)
        {
            proveedor.NumeroCasa = numeroDomicilio;
        }

        public void codigoPostalIngresado(int codPostal)
        {
            proveedor.CodigoPostal = codPostal;
        }

        public bool verificarExistencia()
        {
           int i= proveedor.esProveedor(proveedor.Cuit);
            if (i == 0)
                return false;
            else
                return true;            
            
            }

        private void buscarUltimoProveedor()
        {
            int valor = proveedor.ultimoNroProveedor();
            if (valor != 0)
            {
                proveedor.CodigoProveedor = (int)valor + 1;
            }
            else
            {
                proveedor.CodigoProveedor = 1;
            }
        }


        public List<Banco> mostrarDatosBancos()
        {
           return  banco.mostrarDatosColeccion();
        }

        public List<TipoTelefono> mostrarDatosTiposTelefonos()
        {
            tipoTelefono = new TipoTelefono();
            return tipoTelefono.mostrarDatosColeccion();
        }


        public List<Provincia> mostrarDatosProvincias()
        {
            return provincia.mostrarDatosColeccion();
        }


        public List<Departamento> mostrarDatosDepartamento(int codigoProvincia)
        {
            provincia = new Provincia();
            return provincia.conocerDepartamento(codigoProvincia);
        }


        public List<Localidad> mostrarDatosLocalidad(int codigoDepto)
        {
            departamento = new Departamento();
            return departamento.conocerLocalidad(codigoDepto);
        }


        public void crear()
        {
            buscarUltimoProveedor();
            proveedor.crear(proveedor.CodigoProveedor, proveedor.Cuit, proveedor.RazonSocial, proveedor.Banco, proveedor.NroCuentaCorriente, proveedor.TipoTelefonoUno, proveedor.NumeroDeTelefonoUno, proveedor.TipoTelefonoDos, proveedor.NumeroDeTelefonoDos, proveedor.Calle, proveedor.NumeroCasa, proveedor.Provincia, proveedor.Departamento, proveedor.Localidad, proveedor.CodigoPostal, proveedor.Barrio);
        }


        public void opcionConfirmarTomado()
        {
            crear();
        }
        


    }
}
