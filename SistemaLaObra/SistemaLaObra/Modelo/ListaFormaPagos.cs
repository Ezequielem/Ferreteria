using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class ListaFormaPago
    {
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlDataAdapter adaptador;
        SqlCommand consulta;
        SqlDataReader lector;

        public int CodigoListaFormaPago { get; set; }
        public int CodigoVenta { get; set; }
        public int CodigoFormaPago { get; set; }

        public List<ListaFormaPago> coleccionListaFormaPago { get; set; }

        public ListaFormaPago()
        {
            CodigoListaFormaPago = 0;
            CodigoVenta = 0;
            CodigoFormaPago = 0;
        }

        public void crear(ListaFormaPago listaFormaPago)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("INSERT INTO ListaFormaPagos (codigoVenta,codigoFormaPago) VALUES (@codigoVenta,@codigoFormaPago)", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoVenta", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoFormaPago", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoVenta"].Value = listaFormaPago.CodigoVenta;
            adaptador.InsertCommand.Parameters["@codigoFormaPago"].Value = listaFormaPago.CodigoFormaPago;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public List<ListaFormaPago> mostrarDatosColeccion(int codigoVenta)
        {
            coleccionListaFormaPago = new List<ListaFormaPago>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM ListaFormaPagos WHERE codigoVenta='"+codigoVenta+"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    coleccionListaFormaPago.Add(new ListaFormaPago { CodigoVenta = int.Parse(lector["codigoVenta"].ToString()), CodigoFormaPago = int.Parse(lector["codigoFormaPago"].ToString()) });
                }
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return coleccionListaFormaPago;
        }

    }
}
