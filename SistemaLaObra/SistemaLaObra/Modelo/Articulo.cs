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
    public class Articulo
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        private SqlCommand modificacion;

        public int CodigoArticulo { get; set; }
        public string Descripcion { get; set; }
        public string CodigoDescripcion { get; set; }
        public float PrecioUnitario { get; set; }
        public float PrecioCoste { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public int CodigoMarca { get; set; }
        public int CodigoUbicacion { get; set; }
        public int CodigoUnidadesDeMedida { get; set; }
        public int CodigoTipoArticulo { get; set; }
        public int CodigoSub1TipoArticulo { get; set; }
        public int CodigoSub2TipoArticulo { get; set; }
        public int CodigoSub3TipoArticulo { get; set; }
        public int CodigoProveedor { get; set; }

        public Articulo()
        {
            CodigoArticulo = 0;
            Descripcion = "";
            CodigoDescripcion = "";
            PrecioUnitario=0;
            PrecioCoste = 0;
            Stock = 0;
            StockMinimo = 0;
            CodigoMarca = 0;            
            CodigoUbicacion = 0;
            CodigoUnidadesDeMedida = 0;
            CodigoTipoArticulo = 0;
            CodigoSub1TipoArticulo = 0;
            CodigoSub2TipoArticulo = 0;
            CodigoSub3TipoArticulo = 0;
            CodigoProveedor = 0;
        }        

        public void crear(Articulo articulo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand alta = new SqlCommand("insert into Articulos (descripcion, codigoDescripcion, precioUnitario, precioDeCoste, stock, stockMinimo, codigoMarca, codigoUbicacion, codigoUnidadDeMedida, codigoTipoArticulo, codigoSub1TipoArticulo, codigoSub2TipoArticulo, codigoSub3TipoArticulo, codigoProveedor) values (@descripcion, @codigoDescripcion, @precioUnitario, @precioDeCoste, @stock, @stockMinimo, @codigoMarca, @codigoUbicacion, @codigoUnidadDeMedida, @codigoTipoArticulo, @codigoSub1TipoArticulo, @codigoSub2TipoArticulo, @codigoSub3TipoArticulo, @codigoProveedor)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoDescripcion", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precioUnitario", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@precioDeCoste", SqlDbType.Money));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@stock", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@stockMinimo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoMarca", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoUbicacion", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoUnidadDeMedida", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoSub1TipoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoSub2TipoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoSub3TipoArticulo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@descripcion"].Value = articulo.Descripcion;
                adaptador.InsertCommand.Parameters["@codigoDescripcion"].Value = articulo.CodigoDescripcion;
                adaptador.InsertCommand.Parameters["@precioUnitario"].Value = articulo.PrecioUnitario;
                adaptador.InsertCommand.Parameters["@precioDeCoste"].Value = articulo.PrecioCoste;
                adaptador.InsertCommand.Parameters["@stock"].Value = articulo.Stock;
                adaptador.InsertCommand.Parameters["@stockMinimo"].Value = articulo.StockMinimo;
                adaptador.InsertCommand.Parameters["@codigoMarca"].Value = articulo.CodigoMarca;
                adaptador.InsertCommand.Parameters["@codigoUbicacion"].Value = articulo.CodigoUbicacion;
                adaptador.InsertCommand.Parameters["@codigoUnidadDeMedida"].Value = articulo.CodigoUnidadesDeMedida;
                adaptador.InsertCommand.Parameters["@codigoTipoArticulo"].Value = articulo.CodigoTipoArticulo;
                adaptador.InsertCommand.Parameters["@codigoSub1TipoArticulo"].Value = articulo.CodigoSub1TipoArticulo;
                adaptador.InsertCommand.Parameters["@codigoSub2TipoArticulo"].Value = articulo.CodigoSub2TipoArticulo;
                adaptador.InsertCommand.Parameters["@codigoSub3TipoArticulo"].Value = articulo.CodigoSub3TipoArticulo;
                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = articulo.CodigoProveedor;

                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
                CodigoArticulo = buscarUltimoCodigoArticulo();
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
        }

        public void mostrarDatos(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoArticulo, descripcion, codigoDescripcion, precioUnitario, precioDeCoste, stock, stockMinimo, codigoMarca, codigoUbicacion, codigoUnidadDeMedida, codigoTipoArticulo, codigoSub1TipoArticulo, codigoSub2TipoArticulo, codigoSub3TipoArticulo, codigoProveedor from Articulos where codigoArticulo='" + codigo.ToString() + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();

                if (lector.Read())
                {
                    CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString());
                    Descripcion = lector["descripcion"].ToString();
                    CodigoDescripcion = lector["codigoDescripcion"].ToString();
                    PrecioUnitario = float.Parse(lector["precioUnitario"].ToString());
                    PrecioCoste = float.Parse(lector["precioDeCoste"].ToString());
                    Stock = int.Parse(lector["stock"].ToString());
                    StockMinimo = int.Parse(lector["stockMinimo"].ToString());
                    CodigoMarca = int.Parse(lector["codigoMarca"].ToString());
                    CodigoUbicacion = int.Parse(lector["codigoUbicacion"].ToString());
                    CodigoUnidadesDeMedida = int.Parse(lector["codigoUnidadDeMedida"].ToString());
                    CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString());
                    CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString());
                    CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString());
                    CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString());
                    CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public Articulo retornarDatos(int codigo)
        {
            Articulo art = new Articulo();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoArticulo, descripcion, codigoDescripcion, precioUnitario, precioDeCoste, stock, stockMinimo, codigoMarca, codigoUbicacion, codigoUnidadDeMedida, codigoTipoArticulo, codigoSub1TipoArticulo, codigoSub2TipoArticulo, codigoSub3TipoArticulo, codigoProveedor from Articulos where codigoArticulo='" + codigo.ToString() + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();

                if (lector.Read())
                {
                    art.CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString());
                    art.Descripcion = lector["descripcion"].ToString();
                    art.CodigoDescripcion = lector["codigoDescripcion"].ToString();
                    art.PrecioUnitario = float.Parse(lector["precioUnitario"].ToString());
                    art.PrecioCoste = float.Parse(lector["precioDeCoste"].ToString());
                    art.Stock = int.Parse(lector["stock"].ToString());
                    art.StockMinimo = int.Parse(lector["stockMinimo"].ToString());
                    art.CodigoMarca = int.Parse(lector["codigoMarca"].ToString());
                    art.CodigoUbicacion = int.Parse(lector["codigoUbicacion"].ToString());
                    art.CodigoUnidadesDeMedida = int.Parse(lector["codigoUnidadDeMedida"].ToString());
                    art.CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString());
                    art.CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString());
                    art.CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString());
                    art.CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString());
                    art.CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());                    
                }
                return art;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return art;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Articulo> mostrarDatos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoArticulo, descripcion, codigoDescripcion, precioUnitario, precioDeCoste, stock, stockMinimo, codigoMarca, codigoUbicacion, codigoUnidadDeMedida, codigoTipoArticulo, codigoSub1TipoArticulo, codigoSub2TipoArticulo, codigoSub3TipoArticulo, codigoProveedor from Articulos", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    lista.Add(new Articulo(){
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        CodigoDescripcion = lector["codigoDescripcion"].ToString(),
                        PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                        PrecioCoste = float.Parse(lector["precioDeCoste"].ToString()),
                        Stock = int.Parse(lector["stock"].ToString()),
                        StockMinimo = int.Parse(lector["stockMinimo"].ToString()),
                        CodigoMarca = int.Parse(lector["codigoMarca"].ToString()),
                        CodigoUbicacion = int.Parse(lector["codigoUbicacion"].ToString()),
                        CodigoUnidadesDeMedida = int.Parse(lector["codigoUnidadDeMedida"].ToString()),
                        CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString()),
                        CodigoSub1TipoArticulo = int.Parse(lector["codigoSub1TipoArticulo"].ToString()),
                        CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString()),
                        CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString()),
                        CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString())
                    });                    
                }
                return lista;
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }


        public List<Articulo> mostrarArticulosBajoStockManual(int stock)
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select *  from articulos where stock <= '" + stock + "'", conexion);
      


            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                 {

                    listaArticulo.Add(new Articulo
                    {
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                        PrecioCoste = float.Parse(lector["precioDeCoste"].ToString()),
                        Stock = int.Parse(lector["stock"].ToString()),
                        StockMinimo = int.Parse(lector["stockMinimo"].ToString()),                       
                        });                                      
                }                           
            }

            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return listaArticulo;
        }

        public List<Articulo> mostrarArticulosBajoStock()
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select *  from articulos where stock < stockMinimo", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaArticulo.Add(new Articulo
                    {
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                        PrecioCoste = float.Parse(lector["precioDeCoste"].ToString()),
                        Stock = int.Parse(lector["stock"].ToString()),
                        StockMinimo = int.Parse(lector["stockMinimo"].ToString()),
                    });
                }
            }

            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return listaArticulo;
        }

        public List<Articulo> mostrarListaArticulo(List<Articulo> lista,int codigoArticulo)
        {
            List<Articulo> listaArticulo = new List<Articulo>();
            listaArticulo = lista;
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select *  from articulos where codigoArticulo='" + codigoArticulo + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaArticulo.Add(new Articulo
                    {
                        CodigoArticulo = int.Parse(lector["codigoArticulo"].ToString()),
                        Descripcion = lector["descripcion"].ToString(),
                        CodigoDescripcion = lector["codigoDescripcion"].ToString(),
                        PrecioUnitario = float.Parse(lector["precioUnitario"].ToString()),
                        PrecioCoste = float.Parse(lector["precioDeCoste"].ToString()),
                        Stock = int.Parse(lector["stock"].ToString()),
                        StockMinimo = int.Parse(lector["stockMinimo"].ToString()),
                        CodigoMarca= int.Parse(lector["codigoMarca"].ToString()),
                        CodigoUbicacion = int.Parse(lector["codigoUbicacion"].ToString()),
                        CodigoUnidadesDeMedida = int.Parse(lector["codigoUnidadDeMedida"].ToString()),
                        CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString()),
                        CodigoTipoArticulo = int.Parse(lector["codigoTipoArticulo"].ToString()),
                        CodigoSub1TipoArticulo= int.Parse(lector["codigoSub1TipoArticulo"].ToString()),
                        CodigoSub2TipoArticulo = int.Parse(lector["codigoSub2TipoArticulo"].ToString()),
                        CodigoSub3TipoArticulo = int.Parse(lector["codigoSub3TipoArticulo"].ToString()),
                    });
                }
            }

            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return listaArticulo;
        }

        public string mostrarNombre(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select * from Articulos where codigoArticulo ='" + codigo.ToString() + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();

                if (lector.Read())
                {
                    Descripcion = lector["descripcion"].ToString();
                    return Descripcion;
                }
                return Descripcion;
            }
            catch (SqlException excepcion)
            {
                return excepcion.ToString();
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public void actualizarDatos(Articulo articulo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            modificacion = new SqlCommand("update Articulos set descripcion=@descripcion, codigoDescripcion=@codigoDescripcion, precioUnitario=@precioUnitario, stock=@stock, stockMinimo=@stockMinimo, codigoMarca=@codigoMarca, codigoUbicacion=@codigoUbicacion, codigoUnidadDeMedida=@codigoUnidadDeMedida, codigoTipoArticulo=@codigoTipoArticulo, codigoSub1TipoArticulo=@codigoSub1TipoArticulo, codigoSub2TipoArticulo=@codigoSub2TipoArticulo, codigoSub3TipoArticulo=@codigoSub3TipoArticulo where codigoArticulo=@codigoArticulo", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = modificacion;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoArticulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@descripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoDescripcion", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@precioUnitario", SqlDbType.Money));            
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@stock", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@stockMinimo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoMarca", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoUbicacion", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoUnidadDeMedida", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoTipoArticulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoSub1TipoArticulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoSub2TipoArticulo", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoSub3TipoArticulo", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@codigoArticulo"].Value = articulo.CodigoArticulo;
            adaptador.UpdateCommand.Parameters["@descripcion"].Value = articulo.Descripcion;
            adaptador.UpdateCommand.Parameters["@codigoDescripcion"].Value = articulo.CodigoDescripcion;
            adaptador.UpdateCommand.Parameters["@precioUnitario"].Value = articulo.PrecioUnitario;            
            adaptador.UpdateCommand.Parameters["@stock"].Value = articulo.Stock;
            adaptador.UpdateCommand.Parameters["@stockMinimo"].Value = articulo.StockMinimo;
            adaptador.UpdateCommand.Parameters["@codigoMarca"].Value = articulo.CodigoMarca;
            adaptador.UpdateCommand.Parameters["@codigoUbicacion"].Value = articulo.CodigoUbicacion;
            adaptador.UpdateCommand.Parameters["@codigoUnidadDeMedida"].Value = articulo.CodigoUnidadesDeMedida;
            adaptador.UpdateCommand.Parameters["@codigoTipoArticulo"].Value = articulo.CodigoTipoArticulo;      
            adaptador.UpdateCommand.Parameters["@codigoSub1TipoArticulo"].Value = articulo.CodigoSub1TipoArticulo;
            adaptador.UpdateCommand.Parameters["@codigoSub2TipoArticulo"].Value = articulo.CodigoSub2TipoArticulo;
            adaptador.UpdateCommand.Parameters["@codigoSub3TipoArticulo"].Value = articulo.CodigoSub3TipoArticulo;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();           
            }
            catch (SqlException excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {                
                conexion.Close();                
            }
        }

        public int conocerProveedor(int codigoArticulo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoProveedor from ListaProveedoresArticulos where codigoArticulo='"+ codigoArticulo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoProveedor"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                return 0;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }

        }

        public int buscarArticulo(string nombreArticulo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoArticulo from Articulos where descripcion ='" + nombreArticulo+"'", conexion);

            try
            {
                conexion.Open();    
                lector = consulta.ExecuteReader();

                if (lector.Read())
                {
                    int codigoArticulo = int.Parse(lector["codigoArticulo"].ToString());
                    return codigoArticulo;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
                return 0;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<int> buscarListaDeArticulos(string nombreArticulo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoArticulo from Articulos where descripcion like '" + nombreArticulo + "%'", conexion);

            List<int> codigoArticulos = new List<int>();

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    codigoArticulos.Add(int.Parse(lector["codigoArticulo"].ToString()));
                }                
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return codigoArticulos;
        }

        public int buscarUltimoCodigoArticulo()
        {
            int codigo=0;
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());

            try
            {
                SqlCommand consulta = new SqlCommand("select max(codigoArticulo) as codigoArticulo from Articulos", conexion);
                conexion.Open();
                lector = consulta.ExecuteReader();
            }
            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                if (lector.Read())
                {
                    codigo = int.Parse(lector["codigoArticulo"].ToString());
                }
                lector.Close();
                conexion.Close();
            }
            CodigoArticulo = codigo;
            return codigo;
        }

        public bool stockValido(int cantidadSolicitada)
        {
            if (cantidadSolicitada <= Stock)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void disminuirStock(int cantidad, int codigo)
        {
            try
            {
                AccesoDatos s = new AccesoDatos();
                conexion = new SqlConnection(s.CadenaConexion());
                conexion.Open();
                adaptador = new SqlDataAdapter();
                modificacion = new SqlCommand("UPDATE Articulos SET stock=stock-@cantidad WHERE codigoArticulo=@codigo", conexion);
                adaptador.UpdateCommand = modificacion;

                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cantidad", System.Data.SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));

                adaptador.UpdateCommand.Parameters["@cantidad"].Value = cantidad;
                adaptador.UpdateCommand.Parameters["@codigo"].Value = codigo;

                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo actualizar stock " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void aumentarStock(int cantidad, int codigo)
        {
            try
            {
                AccesoDatos s = new AccesoDatos();
                conexion = new SqlConnection(s.CadenaConexion());
                conexion.Open();
                adaptador = new SqlDataAdapter();
                modificacion = new SqlCommand("UPDATE Articulos SET stock=stock+@cantidad WHERE codigoArticulo=@codigo", conexion);
                adaptador.UpdateCommand = modificacion;

                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cantidad", System.Data.SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int));

                adaptador.UpdateCommand.Parameters["@cantidad"].Value = cantidad;
                adaptador.UpdateCommand.Parameters["@codigo"].Value = codigo;

                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo actualizar stock " + e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public string buscarNombreMarca(int codigoMarca)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Marcas where codigoMarca='" + codigoMarca + "'", conexion);
            string nombreMarca = "";
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreMarca = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreMarca;
        }

        public string buscarNombreUdadMedida(int codigoUdadMedida)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from UnidadesDeMedida where codigoUnidadDeMedida='" + codigoUdadMedida + "'", conexion);
            string nombreUdadMedida = "";
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreUdadMedida = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreUdadMedida;
        }

        public string buscarNombreProveedor(int codigoProveedor)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select razonSocial from Proveedores where codigoProveedor='" + codigoProveedor + "'", conexion);
            string nombreProveedor = "";
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreProveedor = lector["razonSocial"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreProveedor;
        }

        public int buscarCodigoProveedor(int codigoArticulo)
        {
            int codigo=-1;
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select codigoProveedor from ListaProveedoresArticulos where codigoArticulo='" + codigoArticulo + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                   codigo = int.Parse(lector["codigoProveedor"].ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return codigo;
        }

        public string buscarNombreTipoArticulo(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from TiposArticulos where codigoTipoArticulo='" + codigo + "'", conexion);
            string descripcion = string.Empty;
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return descripcion;
        }

        public string buscarNombreSubTipo1(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Sub1TiposArticulos where codigoSub1TipoArticulo='" + codigo + "'", conexion);
            string descripcion = string.Empty;
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return descripcion;
        }

        public string buscarNombreSubTipo2(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Sub2TiposArticulos where codigoSub2TipoArticulo='" + codigo + "'", conexion);
            string descripcion = string.Empty;
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return descripcion;
        }

        public string buscarNombreSubTipo3(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Sub3TiposArticulos where codigoSub3TipoArticulo='" + codigo + "'", conexion);
            string descripcion = string.Empty;
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    descripcion = lector["descripcion"].ToString();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return descripcion;
        }

        public string mostrarMarca(Articulo articuloRecibido)
        {
            string nombreMarca = "";
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Marcas where codigoMarca='" + articuloRecibido.CodigoMarca + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreMarca=lector["descripcion"].ToString();
                }
            }
            catch (Exception )
            {
                return "sin datos";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreMarca;
        }

        public string mostrarUbicacion(Articulo articuloRecibido)
        {
            string nombreUbicacion = "";
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select descripcion from Ubicaciones where codigoUbicacion='" + articuloRecibido.CodigoUbicacion + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    nombreUbicacion = lector["descripcion"].ToString();
                }
            }
            catch (Exception)
            {
                return "sin datos";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return nombreUbicacion;
        }

        public List<ListaProveedoresArticulo> buscarListaProveedoresArticulo(List<ListaProveedoresArticulo> lista, int codigoArticulo)
        {
            List<ListaProveedoresArticulo> listaProveedoresArticulo = new List<ListaProveedoresArticulo>();
            listaProveedoresArticulo = lista;
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select *  from ListaProveedoresArticulos where codigoArticulo='" + codigoArticulo + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaProveedoresArticulo.Add(new ListaProveedoresArticulo
                    {
                        CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString()),
                        PrecioProveedor = float.Parse(lector["precioProveedor"].ToString()),
                        CodigoArticulo= int.Parse(lector["codigoArticulo"].ToString()), 

                    });
                }
            }

            catch (Exception excepcion)
            {
                MessageBox.Show(excepcion.ToString());
            }
            finally
            {
                conexion.Close();
            }
            return listaProveedoresArticulo;
        }

        public Encargado conocerEncargado(int codigoEncargado)
        {
            AccesoDatos acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            Encargado encargado = new Encargado();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            SqlCommand consulta = new SqlCommand("select legajo, nombre, apellido, codigoTipoDocumento, nroDocumento, fechaNacimiento, codigoTipoTelefono, nroTelefono, calle, numero, depto, piso, codigoPostal, nombreBarrio, codigoUsuario, codigoProvincia, codigoDepartamento, codigoLocalidad from Encargados where codigoEncargado='" + codigoEncargado + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    encargado.Legajo = int.Parse(lector["legajo"].ToString());
                    encargado.Nombre = lector["nombre"].ToString();
                    encargado.Apellido = lector["apellido"].ToString();
                    encargado.CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString());
                    encargado.NroDocumento = lector["nroDocumento"].ToString();
                    encargado.FechaNacimiento = DateTime.Parse(lector["fechaNacimiento"].ToString());
                    encargado.CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    encargado.CodigoTipoTelefono = int.Parse(lector["nroTelefono"].ToString());
                    encargado.Calle = lector["calle"].ToString();
                    encargado.Numero = lector["numero"].ToString();
                    encargado.Depto = lector["depto"].ToString();
                    encargado.Piso = lector["piso"].ToString();
                    encargado.CodigoPostal = (lector["codigoPostal"].ToString());
                    encargado.NombreBarrio = lector["nombreBarrio"].ToString();
                    encargado.CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                    encargado.CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                }
                return encargado;
            }
            catch (Exception e)
            {
                string log = e.ToString();
                return encargado;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}
