using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class MiEmpresa
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public int CodigoMiEmpresa { get; set; }
        public string NombreFantasia { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NumeroTelefono { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Barrio { get; set; }
        public bool Facturacion { get; set; }
        public bool Navegacion { get; set; }
        public int CodigoLocalidad { get; set; }
        public int CodigoTipoTelefono { get; set; }
        public int CodigoCondicionIva { get; set; }
        public Localidad Localidad { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public CondicionIva CondicionIva { get; set; }        

        public MiEmpresa()
        {
            CodigoMiEmpresa = 0;
            NombreFantasia = string.Empty;
            RazonSocial = string.Empty;
            Cuit = string.Empty;
            IngresosBrutos = string.Empty;
            FechaInicio = DateTime.Today;
            NumeroTelefono = string.Empty;
            Email = string.Empty;
            PaginaWeb = string.Empty;
            Calle = string.Empty;
            Numero = string.Empty;
            CodigoPostal = string.Empty;
            Barrio = string.Empty;
            Facturacion = false;
            Navegacion = false;
            CodigoLocalidad = 0;
            CodigoTipoTelefono = 0;
            CodigoCondicionIva = 0;
            Localidad = new Localidad();
            TipoTelefono = new TipoTelefono();
            CondicionIva = new CondicionIva();
        }

        public void crear(MiEmpresa miEmpresa)
        {

        }

        public void modificar(MiEmpresa miEmpresa)
        {

        }

        public void mostrarDatos(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select codigoMiEmpresa, nombreFantasia, razonSocial, cuit, ingresosBrutos, fechaInicio, nroTelefono,
                                        email, paginaWeb, calle, numero, codigoPostal, nombreBarrio, facturacion, navegacion, codigoLocalidad,
                                        codigoTipoTelefono, codigoCondicionIVA from MiEmpresas where codigoMiEmpresa='"+ codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString());
                    NombreFantasia = lector["nombreFantasia"].ToString();
                    RazonSocial = lector["razonSocial"].ToString();
                    Cuit = lector["cuit"].ToString();
                    IngresosBrutos = lector["ingresosBrutos"].ToString();
                    FechaInicio = DateTime.Parse(lector["fechaInicio"].ToString());
                    NumeroTelefono = lector["nroTelefono"].ToString();
                    Email = lector["email"].ToString();
                    PaginaWeb = lector["paginaWeb"].ToString();
                    Calle = lector["calle"].ToString();
                    Numero = lector["numero"].ToString();
                    CodigoPostal = lector["codigoPostal"].ToString();
                    Barrio = lector["nombreBarrio"].ToString();
                    Facturacion = bool.Parse(lector["facturacion"].ToString());
                    Navegacion = bool.Parse(lector["navegacion"].ToString());
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                    CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    CodigoCondicionIva = int.Parse(lector["codigoCondicionIVA"].ToString());
                    Localidad.mostrarDatos(CodigoLocalidad);
                    TipoTelefono.mostrarDatos(CodigoTipoTelefono);
                    CondicionIva.mostrarDatos(CodigoCondicionIva);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<MiEmpresa> mostrarDatos()
        {
            List<MiEmpresa> lista = new List<MiEmpresa>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select codigoMiEmpresa, nombreFantasia, razonSocial, cuit, ingresosBrutos, fechaInicio, nroTelefono,
                                        email, paginaWeb, calle, numero, codigoPostal, nombreBarrio, facturacion, navegacion, codigoLocalidad,
                                        codigoTipoTelefono, codigoCondicionIVA from MiEmpresas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {                    
                    lista.Add(new MiEmpresa() {
                        CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString()),
                        NombreFantasia = lector["nombreFantasia"].ToString(),
                        RazonSocial = lector["razonSocial"].ToString(),
                        Cuit = lector["cuit"].ToString(),
                        IngresosBrutos = lector["ingresosBrutos"].ToString(),
                        FechaInicio = DateTime.Parse(lector["fechaInicio"].ToString()),
                        NumeroTelefono = lector["nroTelefono"].ToString(),
                        Email = lector["email"].ToString(),
                        PaginaWeb = lector["paginaWeb"].ToString(),
                        Calle = lector["calle"].ToString(),
                        Numero = lector["numero"].ToString(),
                        CodigoPostal = lector["codigoPostal"].ToString(),
                        Barrio = lector["nombreBarrio"].ToString(),
                        Facturacion = bool.Parse(lector["facturacion"].ToString()),
                        Navegacion = bool.Parse(lector["navegacion"].ToString()),
                        CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString()),
                        CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString()),
                        CodigoCondicionIva = int.Parse(lector["codigoCondicionIVA"].ToString()),                        
                });
                    
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return lista;                
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public bool existe(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from MiEmpresas where codigoMiEmpresa='"+ codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }
    }
}
