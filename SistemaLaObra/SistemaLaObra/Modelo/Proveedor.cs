using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaLaObra
{
    public class Proveedor
    {
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoProveedor { get; set; }
        public string Cuit { get; set; }
        public string NombreFantasia { get; set; }
        public string RazonSocial { get; set; }
        public int IdBanco { get; set; }
        public string NroCuentaCorriente { get; set; }
        public string NombreContactoUno { get; set; }
        public string CargoContactoUno { get; set; }
        public int IdTipoTelefonoUno { get; set; }
        public string NumeroDeTelefonoUno { get; set; }
        public string NombreContactoDos { get; set; }
        public string CargoContactoDos { get; set; }
        public int IdTipoTelefonoDos { get; set; }
        public string NumeroDeTelefonoDos { get; set; }
        public string Calle { get; set; }
        public string Barrio { get; set; }
        public string NumeroCasa { get; set; }
        public string CodigoPostal { get; set; }
        public int IdLocalidad { get; set; }
        public Localidad Localidad { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public Banco Banco { get; set; }


        public Proveedor()
        {
            IdLocalidad = 0;
            IdTipoTelefonoUno = 0;
            IdTipoTelefonoDos = 0;
            IdBanco = 0;
            Localidad = new Localidad();
            TipoTelefono = new TipoTelefono();
            Banco = new Banco();
        }

        //METODOS

        public void actualizar (Proveedor objeto)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                consulta = new SqlCommand("UPDATE Proveedores SET cuit=@cuit, razonSocial=@razonSocial, nombreFantasia=@nombreFantasia, banco=@banco, nroCuentaCorriente=@nroCuentaCorriente, nombreContactoUno=@nombreContactoUno, cargoContactoUno=@cargoContactoUno, tipoTelefono1=@tipoTelefono1, nroTelefono1=@nroTelefono1, nombreContactoDos=@nombreContactoDos, cargoContactoDos=@cargoContactoDos, tipoTelefono2=@tipoTelefono2, nroTelefono2=@nroTelefono2, calle=@calle,  numero=@numero, localidad=@localidad, codigoPostal=@codigoPostal, nombreBarrio=@nombreBarrio WHERE codigoProveedor = @codigoProveedor", conexion);
        
                adaptador.UpdateCommand = consulta;
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreFantasia", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@banco", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreContactoUno", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cargoContactoUno", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tipoTelefono1", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroTelefono1", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreContactoDos", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cargoContactoDos", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@tipoTelefono2", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroTelefono2", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));

                adaptador.UpdateCommand.Parameters["@codigoProveedor"].Value = objeto.CodigoProveedor;
                adaptador.UpdateCommand.Parameters["@cuit"].Value = objeto.Cuit;
                adaptador.UpdateCommand.Parameters["@razonSocial"].Value = objeto.RazonSocial;
                adaptador.UpdateCommand.Parameters["@nombreFantasia"].Value = objeto.NombreFantasia;
                adaptador.UpdateCommand.Parameters["@banco"].Value = objeto.Banco.CodigoBanco;
                adaptador.UpdateCommand.Parameters["@nroCuentaCorriente"].Value = objeto.NroCuentaCorriente;
                adaptador.UpdateCommand.Parameters["@nombreContactoUno"].Value = objeto.NombreContactoUno;
                adaptador.UpdateCommand.Parameters["@cargoContactoUno"].Value = objeto.CargoContactoUno;
                adaptador.UpdateCommand.Parameters["@tipoTelefono1"].Value = objeto.IdTipoTelefonoUno;
                adaptador.UpdateCommand.Parameters["@nroTelefono1"].Value = objeto.NumeroDeTelefonoUno;
                adaptador.UpdateCommand.Parameters["@nombreContactoDos"].Value = objeto.NombreContactoDos;
                adaptador.UpdateCommand.Parameters["@cargoContactoDos"].Value = objeto.CargoContactoDos;
                adaptador.UpdateCommand.Parameters["@tipoTelefono2"].Value = objeto.IdTipoTelefonoDos;
                adaptador.UpdateCommand.Parameters["@nroTelefono2"].Value = objeto.NumeroDeTelefonoDos;
                adaptador.UpdateCommand.Parameters["@calle"].Value = objeto.Calle;
                adaptador.UpdateCommand.Parameters["@numero"].Value = objeto.NumeroCasa;
                adaptador.UpdateCommand.Parameters["@localidad"].Value = objeto.Localidad.CodigoLocalidad;
                adaptador.UpdateCommand.Parameters["@codigoPostal"].Value = objeto.CodigoPostal;
                adaptador.UpdateCommand.Parameters["@nombreBarrio"].Value = objeto.Barrio;

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

        public void crear(Proveedor objeto)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            try
            {
                SqlCommand alta = new SqlCommand("insert into Proveedores (codigoProveedor, cuit, razonSocial, nombreFantasia, banco, nroCuentaCorriente, nombreContactoUno, cargoContactoUno, tipoTelefono1, nroTelefono1, nombreContactoDos, cargoContactoDos, tipoTelefono2, nroTelefono2, calle, numero, localidad, codigoPostal, nombreBarrio) values (@codigoProveedor, @cuit, @razonSocial, @nombreFantasia, @banco, @nroCuentaCorriente, @nombreContactoUno, @cargoContactoUno, @tipoTelefono1, @nroTelefono1, @nombreContactoDos, @cargoContactoDos, @tipoTelefono2, @nroTelefono2, @calle, @numero, @localidad, @codigoPostal, @nombreBarrio)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreFantasia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@banco", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreContactoUno", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cargoContactoUno", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono1", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreContactoDos", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cargoContactoDos", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono2", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = objeto.CodigoProveedor;
                adaptador.InsertCommand.Parameters["@cuit"].Value = objeto.Cuit;
                adaptador.InsertCommand.Parameters["@razonSocial"].Value = objeto.RazonSocial;
                adaptador.InsertCommand.Parameters["@nombreFantasia"].Value = objeto.NombreFantasia;
                adaptador.InsertCommand.Parameters["@banco"].Value = objeto.Banco.CodigoBanco;
                adaptador.InsertCommand.Parameters["@nroCuentaCorriente"].Value = objeto.NroCuentaCorriente;
                adaptador.InsertCommand.Parameters["@nombreContactoUno"].Value = objeto.NombreContactoUno;
                adaptador.InsertCommand.Parameters["@cargoContactoUno"].Value = objeto.CargoContactoUno;
                adaptador.InsertCommand.Parameters["@tipoTelefono1"].Value = objeto.IdTipoTelefonoUno;
                adaptador.InsertCommand.Parameters["@nroTelefono1"].Value = objeto.NumeroDeTelefonoUno;
                adaptador.InsertCommand.Parameters["@nombreContactoDos"].Value = objeto.NombreContactoDos;
                adaptador.InsertCommand.Parameters["@cargoContactoDos"].Value = objeto.CargoContactoDos;
                adaptador.InsertCommand.Parameters["@tipoTelefono2"].Value = objeto.IdTipoTelefonoDos;
                adaptador.InsertCommand.Parameters["@nroTelefono2"].Value = objeto.NumeroDeTelefonoDos;
                adaptador.InsertCommand.Parameters["@calle"].Value = objeto.Calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = objeto.NumeroCasa;
                adaptador.InsertCommand.Parameters["@localidad"].Value = objeto.IdLocalidad;
                adaptador.InsertCommand.Parameters["@codigoPostal"].Value = objeto.CodigoPostal;
                adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = objeto.Barrio;

                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
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

        public Proveedor mostrarDatos(int codigoProveedor)
        {
            Proveedor objeto = new Proveedor();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("SELECT * FROM Proveedores WHERE codigoProveedor = '" + codigoProveedor + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    objeto.CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                    objeto.Cuit = lector["cuit"].ToString();
                    objeto.RazonSocial = lector["razonSocial"].ToString();
                    objeto.NombreFantasia = lector["nombreFantasia"].ToString();
                    objeto.IdBanco = int.Parse(lector["banco"].ToString());
                    objeto.NroCuentaCorriente = lector["nroCuentaCorriente"].ToString();
                    objeto.NombreContactoUno = lector["nombreContactoUno"].ToString();
                    objeto.CargoContactoUno = lector["cargoContactoUno"].ToString();
                    objeto.IdTipoTelefonoUno = int.Parse(lector["tipoTelefono1"].ToString());
                    objeto.NumeroDeTelefonoUno = lector["nroTelefono1"].ToString();
                    objeto.NombreContactoDos = lector["nombreContactoDos"].ToString();
                    objeto.CargoContactoDos = lector["cargoContactoDos"].ToString();
                    objeto.IdTipoTelefonoDos = int.Parse(lector["tipoTelefono2"].ToString());
                    objeto.NumeroDeTelefonoDos = lector["nroTelefono2"].ToString();
                    objeto.Calle = lector["calle"].ToString();
                    objeto.NumeroCasa = lector["numero"].ToString();
                    objeto.IdLocalidad = int.Parse(lector["localidad"].ToString());
                    objeto.CodigoPostal = lector["codigoPostal"].ToString();
                    objeto.Barrio = lector["nombreBarrio"].ToString();
                }
                return objeto;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return objeto;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Proveedor> mostrarDatos()
        {
            List<Proveedor> lista = new List<Proveedor>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());            
            consulta = new SqlCommand("select codigoProveedor, cuit, razonSocial, nombreFantasia, banco, nroCuentaCorriente, nombreContactoUno, cargoContactoUno, tipoTelefono1, nroTelefono1, nombreContactoDos, cargoContactoDos, tipoTelefono2, nroTelefono2, calle, numero, localidad, codigoPostal, nombreBarrio from Proveedores", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Proveedor() {
                                            CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString()),
                                            Cuit = lector["cuit"].ToString(),
                                            RazonSocial = lector["razonSocial"].ToString(),
                                            NombreFantasia = lector["nombreFantasia"].ToString(),
                                            IdBanco = int.Parse(lector["banco"].ToString()),
                                            NroCuentaCorriente = lector["nroCuentaCorriente"].ToString(),
                                            NombreContactoUno = lector["nombreContactoUno"].ToString(),
                                            CargoContactoUno = lector["cargoContactoUno"].ToString(),
                                            IdTipoTelefonoUno = int.Parse(lector["tipoTelefono1"].ToString()),
                                            NumeroDeTelefonoUno = lector["nroTelefono1"].ToString(),
                                            NombreContactoDos = lector["nombreContactoDos"].ToString(),
                                            CargoContactoDos = lector["cargoContactoDos"].ToString(),
                                            IdTipoTelefonoDos = int.Parse(lector["tipoTelefono2"].ToString()),
                                            NumeroDeTelefonoDos = lector["nroTelefono2"].ToString(),
                                            Calle = lector["calle"].ToString(),
                                            NumeroCasa = lector["numero"].ToString(),
                                            IdLocalidad = int.Parse(lector["localidad"].ToString()),
                                            CodigoPostal = lector["codigoPostal"].ToString(),
                                            Barrio = lector["nombreBarrio"].ToString()
                                            });                    
                }
                return lista;
            }
            catch (Exception)
            {               
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public int mostrarCodigoProveedor(string cuit)
        {
            int nroCodigoProveedor = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoProveedor from Proveedores WHERE cuit= '" + cuit + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int valor;
                    bool resultado = int.TryParse(lector["codigoProveedor"].ToString(), out valor);
                    if (resultado)
                    {
                        nroCodigoProveedor = valor;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
            }
            return nroCodigoProveedor;
        }

        public int ultimoNroProveedor()
        {
            int ultimoNroProveedor = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT MAX(codigoProveedor) AS codigo FROM Proveedores", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    int valor;
                    bool resultado = int.TryParse(lector["codigo"].ToString(), out valor);
                    if (resultado)
                    {
                        ultimoNroProveedor = valor;
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
            }
            return ultimoNroProveedor;
        }

        public bool existe(long cuit)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoProveedor FROM Proveedores WHERE cuit = '" + cuit + "'", conexion);
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public bool existe(string razonSocial)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoProveedor FROM Proveedores WHERE razonSocial= '" + razonSocial + "'", conexion);
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return false;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }
    }
}


