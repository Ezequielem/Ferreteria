using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class PuntoDeVenta
    {
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataAdapter adaptador;
        SqlDataReader lector;

        public int CodigoPuntoVenta { get; set; }
        public string NombreFantasia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string NombreBarrio { get; set; }
        public int CodigoLocalidad { get; set; }
        public int CodigoSistemaFacturacion { get; set; }
        public int CodigoMiEmpresa { get; set; }
        public Localidad Localidad { get; set; }
        public MiEmpresa MiEmpresa { get; set; }
        public SistemaDeFacturacion SistemaDeFacturacion { get; set; }

        public PuntoDeVenta()
        {
            CodigoPuntoVenta = 0;
            NombreFantasia = string.Empty;
            Calle = string.Empty;
            Numero = string.Empty;
            CodigoPostal = string.Empty;
            NombreBarrio = string.Empty;
            CodigoLocalidad = 0;
            CodigoSistemaFacturacion = 0;
            CodigoMiEmpresa = 0;
            Localidad = new Localidad();
            MiEmpresa = new MiEmpresa();
            SistemaDeFacturacion = new SistemaDeFacturacion();
        }

        public void crear()
        {

        }

        public void modificar()
        {

        }

        public void mostrarDatos(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select codigoPuntoVenta, nombreFantasia, calle, numero, codigoPostal, nombreBarrio, 
                                        codigoLocalidad, codigoSistemaFacturacion, codigoMiEmpresa from PuntosDeVentas 
                                        where codigoPuntoVenta='" + codigo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoPuntoVenta = int.Parse(lector["codigoPuntoVenta"].ToString());
                    NombreFantasia = lector["nombreFantasia"].ToString();
                    Calle = lector["calle"].ToString();
                    Numero = lector["numero"].ToString();
                    CodigoPostal = lector["codigoPostal"].ToString();
                    NombreBarrio = lector["nombreBarrio"].ToString();
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                    CodigoSistemaFacturacion = int.Parse(lector["codigoSistemaFacturacion"].ToString());
                    CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString());
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

        public List<PuntoDeVenta> mostrarDatos(MiEmpresa objeto)
        {
            List<PuntoDeVenta> lista = new List<PuntoDeVenta>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select codigoPuntoVenta, nombreFantasia, calle, numero, codigoPostal, nombreBarrio, 
                                        codigoLocalidad, codigoSistemaFacturacion, codigoMiEmpresa from PuntosDeVentas 
                                        where codigoMiEmpresa='"+ objeto.CodigoMiEmpresa +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new PuntoDeVenta()
                    { 
                        CodigoPuntoVenta = int.Parse(lector["codigoPuntoVenta"].ToString()),
                        NombreFantasia = lector["nombreFantasia"].ToString(),
                        Calle = lector["calle"].ToString(),
                        Numero = lector["numero"].ToString(),
                        CodigoPostal = lector["codigoPostal"].ToString(),
                        NombreBarrio = lector["nombreBarrio"].ToString(),
                        CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString()),
                        CodigoSistemaFacturacion = int.Parse(lector["codigoSistemaFacturacion"].ToString()),
                        CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString())
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

        public List<PuntoDeVenta> mostrarDatos()
        {
            List<PuntoDeVenta> lista = new List<PuntoDeVenta>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select codigoPuntoVenta, nombreFantasia, calle, numero, codigoPostal, nombreBarrio, 
                                        codigoLocalidad, codigoSistemaFacturacion, codigoMiEmpresa from PuntosDeVentas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new PuntoDeVenta()
                    {
                        CodigoPuntoVenta = int.Parse(lector["codigoPuntoVenta"].ToString()),
                        NombreFantasia = lector["nombreFantasia"].ToString(),
                        Calle = lector["calle"].ToString(),
                        Numero = lector["numero"].ToString(),
                        CodigoPostal = lector["codigoPostal"].ToString(),
                        NombreBarrio = lector["nombreBarrio"].ToString(),
                        CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString()),
                        CodigoSistemaFacturacion = int.Parse(lector["codigoSistemaFacturacion"].ToString()),
                        CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString())
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
    }
}
