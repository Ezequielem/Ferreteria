using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaLaObra
{
    class ListaTarjetas
    {
        //INSTANCIAS
        SqlConnection conexion;
        SqlCommand alta;
        SqlDataReader lector;
        SqlDataAdapter adaptador = new SqlDataAdapter();
        AccesoDatos acceso;

        //ATRIBUTOS
        private int codigoListaTipoTarjeta;
        private int codigoTipoTarjeta;
        private int codigoBanco;
        private int codigoTarjeta;

        public int CodigoListaTipoTarjeta
        {
            get
            {
                return codigoListaTipoTarjeta;
            }

            set
            {
                codigoListaTipoTarjeta = value;
            }
        }

        public int CodigoTipoTarjeta
        {
            get
            {
                return codigoTipoTarjeta;
            }

            set
            {
                codigoTipoTarjeta = value;
            }
        }

        public int CodigoBanco
        {
            get
            {
                return codigoBanco;
            }

            set
            {
                codigoBanco = value;
            }
        }

        public int CodigoTarjeta
        {
            get
            {
                return codigoTarjeta;
            }

            set
            {
                codigoTarjeta = value;
            }
        }

        public void crear(int codigoListaT, int codigoTipoTarj, int codigoBanco, int codigoTarjeta)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            if (codigoTipoTarj != -1)
            {
                alta = new SqlCommand("insert into ListaTarjetas (codigoListaTarjeta, codigoTipoTarjeta, codigoBanco, codigoTarjeta) values (@codigoListaTarjeta, @codigoTipoTarjeta, @codigoBanco, @codigoTarjeta)", conexion);
                adaptador.InsertCommand = alta;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoListaTarjeta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoListaTarjeta"].Value = codigoListaT;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoTarjeta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoTipoTarjeta"].Value = codigoTipoTarj;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoBanco"].Value = codigoBanco;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTarjeta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoTarjeta"].Value = codigoTarjeta;
            }
            else
            {
                alta = new SqlCommand("insert into ListaTarjetas (codigoListaTarjeta, codigoTipoTarjeta, codigoBanco, codigoTarjeta) values (@codigoListaTarjeta, @codigoTipoTarjeta, @codigoBanco, @codigoTarjeta)", conexion);
                adaptador.InsertCommand = alta;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoListaTarjeta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoListaTarjeta"].Value = codigoListaT;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoTarjeta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoTipoTarjeta"].Value = System.Data.SqlTypes.SqlInt32.Null;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoBanco"].Value = codigoBanco;

                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTarjeta", SqlDbType.Int));
                adaptador.InsertCommand.Parameters["@codigoTarjeta"].Value = codigoTarjeta;
            }
           

            try
            {
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


        public int mostrarUltimoListaTarjetas()
        {
            int ultimoCodigo = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select max(codigoListaTarjeta) as ultimoCodigo from ListaTarjetas ", conexion);
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


    }
}
