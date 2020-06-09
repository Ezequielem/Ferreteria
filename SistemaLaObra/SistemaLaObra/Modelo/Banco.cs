using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SistemaLaObra
{
    public class Banco
    {
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlCommand alta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoBanco { get; set; }
        public string Descripcion { get; set; }

        public Banco()
        {
            CodigoBanco = 0;
            Descripcion = "";
        }

      public void crear(int codigoBanco, string descripcion)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            alta = new SqlCommand("insert into Bancos (codigoBanco, descripcion) values (@codigoBanco, @descripcion)", conexion);
            adaptador = new SqlDataAdapter();
            try
            {                
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoBanco"].Value = codigoBanco;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters["@descripcion"].Value = descripcion;
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void mostrarDatos(int id)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from Bancos where codigoBanco='"+ id +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoBanco = int.Parse(lector["codigoBanco"].ToString()); 
                    Descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Banco> mostrarDatos()
        {
            List<Banco> lista = new List<Banco>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from Bancos",conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Banco { CodigoBanco = int.Parse(lector["codigoBanco"].ToString()), Descripcion = lector["descripcion"].ToString()});
                }              
                return lista;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public string mostrarNombre(int codigo)

        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Bancos where codigoBanco='" + codigo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return lector["descripcion"].ToString();
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                return "false";
            }
            finally
            {
                conexion.Close();
            }
        }

        public int mostrarUltimoCodigoBanco()
        {
            int ultimoCodigo = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoBanco) as ultimoCodigo from Bancos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int resultado;
                    bool ultimoCod = int.TryParse(lector["ultimoCodigo"].ToString(), out resultado);
                    if (ultimoCod)
                    {
                        ultimoCodigo = resultado;
                    }
                    else
                    {
                        ultimoCodigo = 0;
                    }
                }
                return ultimoCodigo;
            }
            catch (NullReferenceException)
            {
                return ultimoCodigo;
            }
            finally
            {
                conexion.Close();
            }
        }

        public int mostrarCodigo(string banco)

        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoBanco from Bancos where descripcion='" + banco + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoBanco"].ToString());
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }


        public int existeBanco (string banco)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoBanco from Bancos where descripcion='" + banco + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoBanco"].ToString());
                }
                else
                {
                    return -1;
                }
            }
            catch (Exception)
            {
                return -1;
            }
            finally
            {
                conexion.Close();
            }
        }

    }
}
