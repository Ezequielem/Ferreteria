using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.Ventas.ActualizarClienteMayorista
{
    class Controlador_ActualizarClienteMayorista
    {
        //Instancias
        ClienteMayorista cliente;
        Provincia provincia;
        Departamento departamento;
        Banco banco;
        TipoTelefono tipoTelefono;
        public IU_ActualizarClienteMayorista InterfazActualizarCliente { get; set; }

        public Controlador_ActualizarClienteMayorista()
        {
            cliente = new ClienteMayorista();
        }

        public void razonSocialCliente(string razonSocial)
        {
            cliente.RazonSocial = razonSocial;
        }

        public void buscarDatosClienteMayorista()
        {
            cliente.CodigoClienteMayorista = cliente.buscarCliente(cliente.RazonSocial);
            mostrarDatosCliente();
        }

        private void mostrarDatosCliente()
        {
            cliente.mostrarDatos(cliente.CodigoClienteMayorista);
            InterfazActualizarCliente.txt_cuit.Text = cliente.Cuit;
            InterfazActualizarCliente.cargarTipoTelefono();
            InterfazActualizarCliente.cbx_tipoTelefono.Text = cliente.conocerTipoTelefono(cliente.CodigoTipoTelefono);
            InterfazActualizarCliente.txt_nroTelefono.Text = cliente.NumeroTelefono;
            InterfazActualizarCliente.cargarBancos();
            InterfazActualizarCliente.cbx_banco.Text = cliente.conocerBanco(cliente.CodigoBanco);
            InterfazActualizarCliente.txt_nroCuentaCorriente.Text = cliente.NumeroCtaCte;
            InterfazActualizarCliente.txt_calle.Text = cliente.Calle;
            InterfazActualizarCliente.txt_numero.Text = cliente.Numero.ToString();
            InterfazActualizarCliente.txt_depto.Text = cliente.Depto;
            InterfazActualizarCliente.txt_piso.Text = cliente.Piso;
            InterfazActualizarCliente.txt_barrio.Text = cliente.NombreBarrio;
            InterfazActualizarCliente.txt_codigoPostal.Text = cliente.CodigoPostal.ToString();
            InterfazActualizarCliente.cargarProvincias();
            InterfazActualizarCliente.cbx_provincia.Text = cliente.conocerProvincia(cliente.CodigoProvincia);
            InterfazActualizarCliente.cargarDepartamentos();
            InterfazActualizarCliente.cbx_departamento.Text = cliente.conocerDepartamento(cliente.CodigoDepartamento);
            InterfazActualizarCliente.cargarLocalidades();
            InterfazActualizarCliente.cbx_localidad.Text = cliente.conocerLocalidad(cliente.CodigoLocalidad);
        }

        public void cuitCliente(string cuit)
        {
            cliente.Cuit = cuit;
        }

        public List<TipoTelefono> mostrarSeleccionTipoTelefono()
        {
            tipoTelefono = new TipoTelefono();
            return tipoTelefono.mostrarDatos();
        }

        public void tipoTelefonoCliente(int codigoTipoTelefono)
        {
            cliente.CodigoTipoTelefono = codigoTipoTelefono;
        }

        public void nroTelefonoCliente(string nroTelefono)
        {
            cliente.NumeroTelefono = nroTelefono;
        }

        public List<Banco> mostrarSeleccionBanco()
        {
            banco = new Banco();
            return banco.mostrarDatos();
        }

        public void nombreBancoCliente(int codigoBanco)
        {
            cliente.CodigoBanco = codigoBanco;
        }

        public void nroCtaCteCliente(string nroCuentaCorriente)
        {
            cliente.NumeroCtaCte = nroCuentaCorriente;
        }

        public void calleCliente(string calle)
        {
            cliente.Calle = calle;
        }

        public void numeroCliente(int numero)
        {
            cliente.Numero = numero;
        }

        public void deptoCliente(string depto)
        {
            cliente.Depto = depto;
        }

        public void pisoCliente(string piso)
        {
            cliente.Piso = piso;
        }

        public void barrioCliente(string barrio)
        {
            cliente.NombreBarrio = barrio;
        }

        public void codigoPostalCliente(int codigoPostal)
        {
            cliente.CodigoPostal = codigoPostal;
        }

        public List<Provincia> mostrarSeleccionProvincia()
        {
            provincia = new Provincia();
            return provincia.mostrarDatos();
        }

        public void provinciaCliente(int codigoProvincia)
        {
            cliente.CodigoProvincia = codigoProvincia;
        }

        public List<Departamento> mostrarSeleccionDepartamento(int codigoProvincia)
        {
            provincia = new Provincia();
            return provincia.conocerDepartamento(codigoProvincia);
        }

        public void departamentoCliente(int codigoDepartamento)
        {
            cliente.CodigoDepartamento = codigoDepartamento;
        }

        public List<Localidad> mostrarSeleccionLocalidad(int codigoDepartamento)
        {
            departamento = new Departamento();
            return departamento.conocerLocalidad(codigoDepartamento);
        }

        public void localidadCliente(int codigoLocalidad)
        {
            cliente.CodigoLocalidad = codigoLocalidad;
        }

        public void actualizarDatosCliente()
        {
            cliente.actualizarDatos(cliente);
        }
    }
}
