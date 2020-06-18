using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class CondicionIva
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public int CodigoCondicionIva { get; set; }
        public string Descripcion { get; set; }

        public CondicionIva()
        {
            CodigoCondicionIva = 0;
            Descripcion = string.Empty;
        }

        public void mostrarDatos(int codigo)
        {
            List<CondicionIva> lista = new List<CondicionIva>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select codigoCondicionIVA, descripcion from CondicionesIVA where codigoCondicionIVA='"+ codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoCondicionIva = int.Parse(lector["codigoCondicionIVA"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());                
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<CondicionIva> mostrarDatos()
        {
            List<CondicionIva> lista = new List<CondicionIva>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select codigoCondicionIVA, descripcion from CondicionesIVA", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new CondicionIva()
                    {
                        CodigoCondicionIva=int.Parse(lector["codigoCondicionIVA"].ToString()),
                        Descripcion=lector["descripcion"].ToString()
                    });
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
