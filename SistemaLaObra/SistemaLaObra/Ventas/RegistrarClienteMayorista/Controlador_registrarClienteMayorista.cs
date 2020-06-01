using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Ventas.RegistrarClienteMayorista
{
    class Controlador_registrarClienteMayorista
    {

        ClienteMayorista cliente;
        Provincia provincia;
        Departamento departamento;
        Banco banco;
        TipoTelefono tipoTelefono;

        public Controlador_registrarClienteMayorista()
        {
            cliente = new ClienteMayorista();
        }

        public bool verificarExistencia(string razonSocial)
        {
            int codigo = cliente.buscarCliente(razonSocial);
            if (codigo != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void razonSocialNvoCliente(string razonSocial)
        {
            cliente.RazonSocial = razonSocial;
        }

        public void cuitNvoCliente(string cuit)
        {
            cliente.Cuit = cuit;
        }

        public List<TipoTelefono> mostrarSeleccionTipoTelefono()
        {
            tipoTelefono = new TipoTelefono();
            return tipoTelefono.mostrarDatosColeccion();
        }

        public void tipoTelefonoNvoCliente(int codigoTipoTelefono)
        {
            cliente.CodigoTipoTelefono = codigoTipoTelefono;
        }

        public void nroTelefonoNvoCliente(string nroTelefono)
        {
            cliente.NumeroTelefono = nroTelefono;
        }

        public List<Banco> mostrarSeleccionBanco()
        {
            banco = new Banco();
            return banco.mostrarDatosColeccion();
        }

        public void nombreBancoNvoCliente(int codigoBanco)
        {
            cliente.CodigoBanco = codigoBanco;
        }

        public void nroCtaCteNvoCliente(string nroCuentaCorriente)
        {
            cliente.NumeroCtaCte = nroCuentaCorriente;
        }

        public void calleNvoCliente(string calle)
        {
            cliente.Calle = calle;
        }

        public void numeroNvoCliente(int numero)
        {
            cliente.Numero = numero;
        }

        public void deptoNvoCliente(string depto)
        {
            cliente.Depto = depto;
        }

        public void pisoNvoCliente(string piso)
        {
            cliente.Piso = piso;
        }

        public void barrioNvoCliente(string barrio)
        {
            cliente.NombreBarrio = barrio;
        }

        public void codigoPostalNvoCliente(int codigoPostal)
        {
            cliente.CodigoPostal = codigoPostal;
        }

        public List<Provincia> mostrarSeleccionProvincia()
        {
            provincia = new Provincia();
            return provincia.mostrarDatosColeccion();
        }

        public void provinciaNvoCliente(int codigoProvincia)
        {
            cliente.CodigoProvincia = codigoProvincia;
        }

        public List<Departamento> mostrarSeleccionDepartamento(int codigoProvincia)
        {
            provincia = new Provincia();
            return provincia.conocerDepartamento(codigoProvincia);
        }

        public void departamentoNvoCliente(int codigoDepartamento)
        {

            cliente.CodigoDepartamento = codigoDepartamento;
        }

        public List<Localidad> mostrarSeleccionLocalidad(int codigoDepartamento)
        {
            departamento = new Departamento();
            return departamento.conocerLocalidad(codigoDepartamento);
        }

        public void localidadNvoCliente(int codigoLocalidad)
        {
            cliente.CodigoLocalidad = codigoLocalidad;
        }

        public void registrarNvoCliente()
        {
            cliente.CodigoClienteMayorista = generarNvoNroCliente();
            cliente.crear(cliente);
        }

        private int generarNvoNroCliente()
        {
            return cliente.ultimoNroClienteMayorista() + 1;
        }

    }
}
