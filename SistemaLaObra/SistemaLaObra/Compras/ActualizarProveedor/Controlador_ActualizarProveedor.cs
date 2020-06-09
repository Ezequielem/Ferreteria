using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Compras.ActualizarProveedor
{

    class Controlador_ActualizarProveedor
    {
        //INSTANCIAS

        public Proveedor Proveedor { get; set; }
        public Banco Banco { get; set; }
        public Provincia Provincia { get; set; }
        public Localidad Localidad { get; set; }
        public Departamento Departamento { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        IU_ActualizarProveedor interfazProveedor;

        //Atributos privados

        int i;
        int codP;
        int codD;
        int codL;

        public Controlador_ActualizarProveedor()
        {
            Proveedor = new Proveedor();
            Banco = new Banco();
            Provincia = new Provincia();
            Localidad = new Localidad();
            Departamento = new Departamento();
            TipoTelefono = new TipoTelefono();

        }

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
            Proveedor.Provincia = provincia;
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

        public bool verificarExistencia(long cuit)
        {            
            if (Proveedor.existe(cuit))
                return true;
            else
                return false;

        }

        public bool verificarExistenciaRSocial()
        {
            int i = Proveedor.esProveedorRSocial(Proveedor.RazonSocial);
            if (i == 0)
                return false;
            else
                return true;

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
            return Banco.mostrarDatos();
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

        public void conocerCodigoBanco()
        {
           i = Banco.mostrarCodigo(Proveedor.Banco);
           
        }

        public void conocerCodigoTipoTel()
        {
           i = TipoTelefono.mostrarCodigo(Proveedor.TipoTelefonoUno);
            
        }

        public void conocerCodigoTipoTel2()
        {
            i = TipoTelefono.mostrarCodigo(Proveedor.TipoTelefonoDos);
            
        }

        public void conocerCodigoProvincia()
        {
            codP = Provincia.mostrarCodigo(Proveedor.Provincia);
            
           
        }

        public void conocerCodigoDepartamento()
        {
         codD = Departamento.mostrarCodigo(Proveedor.Departamento, codP);
           
        }

        public void conocerCodigoLocalidad()
        {
         codL = Localidad.mostrarCodigo(Proveedor.Localidad, codD);
          ;
        }

        public void conocerCodigoProveedor()
        {
            int a= Proveedor.mostrarCodigoProveedor(Proveedor.Cuit);
            Proveedor.CodigoProveedor = a;
        }

        public void opcionConfirmarTomado()
        {
            actualizarDatos();
        }

        public void actualizarDatos()
        {
            Proveedor.actualizar(Proveedor);
        }


        public void cargarDatosInterfaz()
        {
            interfazProveedor.txt_Cuit.Text = Proveedor.Cuit.ToString();
            interfazProveedor.txt_RazonSocial.Text = Proveedor.RazonSocial;
            conocerCodigoBanco();
            interfazProveedor.cb_Banco.SelectedValue = i;
            interfazProveedor.txt_CuentaCorriente.Text = Proveedor.NroCuentaCorriente.ToString();
            conocerCodigoTipoTel();
            interfazProveedor.cb_TipoTelefonoUno.SelectedValue = i;
            conocerCodigoTipoTel2();
            interfazProveedor.cb_TipoTelefonoDos.SelectedValue = i;
            interfazProveedor.txt_NumeroTelefono.Text = Proveedor.NumeroDeTelefonoUno.ToString();
            interfazProveedor.txt_NumeroTelefono2.Text = Proveedor.NumeroDeTelefonoDos.ToString();
            interfazProveedor.txt_Barrio.Text = Proveedor.Barrio;
            interfazProveedor.txt_CPostal.Text = Proveedor.CodigoPostal.ToString();
            interfazProveedor.txt_Calle.Text = Proveedor.Calle;
            interfazProveedor.txt_NumeroCalle.Text = Proveedor.NumeroCasa.ToString();
            conocerCodigoProvincia();
            interfazProveedor.cb_Provincia.SelectedValue = codP;
            interfazProveedor.cargarDatosDepartamento();
            conocerCodigoDepartamento();
            interfazProveedor.cb_departamento.SelectedValue  = codD;
            interfazProveedor.cargarDatosLocalidades();
            conocerCodigoLocalidad();
            interfazProveedor.cb_Localidad.SelectedValue = codL;            
        }

        public void cargarDatos(IU_ActualizarProveedor interfaz)
        {
            interfazProveedor = interfaz;
            Proveedor.mostrarDatos();
            cargarDatosInterfaz();
        }








    }
}
