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
        public string Banco { get; set; }
        public int CodigoBanco { get; set; }
        public string NroCuentaCorriente { get; set; }
        public string NombreContactoUno { get; set; }
        public string CargoContactoUno { get; set; }
        public string TipoTelefonoUno { get; set; }
        public string NumeroDeTelefonoUno { get; set; }
        public string NombreContactoDos { get; set; }
        public string CargoContactoDos { get; set; }
        public string TipoTelefonoDos { get; set; }
        public string NumeroDeTelefonoDos { get; set; }
        public string Calle { get; set; }
        public string Barrio { get; set; }
        public string NumeroCasa { get; set; }
        public string Provincia { get; set; }
        public string Departamento { get; set; }
        public string Localidad { get; set; }
        public string CodigoPostal { get; set; }

        public Proveedor()
        {

        }

        //METODOS

        public int esProveedorRSocial(string razonSocial)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoProveedor FROM Proveedores WHERE razonSocial = '" + razonSocial + "'", conexion);
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
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return 0;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public void actualizar (Proveedor objeto)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                consulta = new SqlCommand("UPDATE Proveedores SET cuit=@cuit, razonSocial=@razonSocial, banco=@banco, nroCuentaCorriente=@nroCuentaCorriente, tipoTelefono1=@tipoTelefono1, nroTelefono1=@nroTelefono1, tipoTelefono2=@tipoTelefono2, nroTelefono2=@nroTelefono2, calle=@calle,  numero=@numero, provincia=@provincia, departamento=@departamento, localidad=@localidad, codigoPostal=@codigoPostal, nombreBarrio=@nombreBarrio WHERE codigoProveedor = @codigoProveedor", conexion);
        
                adaptador.InsertCommand = consulta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@banco", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = objeto.CodigoProveedor;
                adaptador.InsertCommand.Parameters["@cuit"].Value = objeto.Cuit;
                adaptador.InsertCommand.Parameters["@razonSocial"].Value = objeto.RazonSocial;
                adaptador.InsertCommand.Parameters["@banco"].Value = objeto.Banco;
                adaptador.InsertCommand.Parameters["@nroCuentaCorriente"].Value = objeto.NroCuentaCorriente;
                adaptador.InsertCommand.Parameters["@tipoTelefono1"].Value = objeto.TipoTelefonoUno;
                adaptador.InsertCommand.Parameters["@nroTelefono1"].Value = objeto.NumeroDeTelefonoUno;
                adaptador.InsertCommand.Parameters["@tipoTelefono2"].Value = objeto.TipoTelefonoDos;
                adaptador.InsertCommand.Parameters["@nroTelefono2"].Value = objeto.NumeroDeTelefonoDos;
                adaptador.InsertCommand.Parameters["@calle"].Value = objeto.Calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = objeto.NumeroCasa;
                adaptador.InsertCommand.Parameters["@provincia"].Value = objeto.Provincia;
                adaptador.InsertCommand.Parameters["@departamento"].Value = objeto.Departamento;
                adaptador.InsertCommand.Parameters["@localidad"].Value = objeto.Localidad;
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


        public void crear(Proveedor objeto)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            try
            {
                SqlCommand alta = new SqlCommand("insert into Proveedores (codigoProveedor, cuit, razonSocial, nombreFantasia, banco, nroCuentaCorriente, nombreContactoUno, cargoContactoUno, tipoTelefono1, nroTelefono1, nombreContactoDos, cargoContactoDos, tipoTelefono2, nroTelefono2, calle, numero, provincia, departamento, localidad, codigoPostal, nombreBarrio) values (@codigoProveedor, @cuit, @razonSocial, @nombreFantasia, @banco, @nroCuentaCorriente, @nombreContactoUno, @cargoContactoUno, @tipoTelefono1, @nroTelefono1, @nombreContactoDos, @cargoContactoDos, @tipoTelefono2, @nroTelefono2, @calle, @numero, @provincia, @departamento, @localidad, @codigoPostal, @nombreBarrio)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreFantasia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@banco", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreContactoUno", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cargoContactoUno", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreContactoDos", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cargoContactoDos", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = objeto.CodigoProveedor;
                adaptador.InsertCommand.Parameters["@cuit"].Value = objeto.Cuit;
                adaptador.InsertCommand.Parameters["@razonSocial"].Value = objeto.RazonSocial;
                adaptador.InsertCommand.Parameters["@nombreFantasia"].Value = objeto.NombreFantasia;
                adaptador.InsertCommand.Parameters["@banco"].Value = objeto.Banco;
                adaptador.InsertCommand.Parameters["@nroCuentaCorriente"].Value = objeto.NroCuentaCorriente;
                adaptador.InsertCommand.Parameters["@nombreContactoUno"].Value = objeto.NombreContactoUno;
                adaptador.InsertCommand.Parameters["@cargoContactoUno"].Value = objeto.CargoContactoUno;
                adaptador.InsertCommand.Parameters["@tipoTelefono1"].Value = objeto.TipoTelefonoUno;
                adaptador.InsertCommand.Parameters["@nroTelefono1"].Value = objeto.NumeroDeTelefonoUno;
                adaptador.InsertCommand.Parameters["@nombreContactoDos"].Value = objeto.NombreContactoDos;
                adaptador.InsertCommand.Parameters["@cargoContactoDos"].Value = objeto.CargoContactoDos;
                adaptador.InsertCommand.Parameters["@tipoTelefono2"].Value = objeto.TipoTelefonoDos;
                adaptador.InsertCommand.Parameters["@nroTelefono2"].Value = objeto.NumeroDeTelefonoDos;
                adaptador.InsertCommand.Parameters["@calle"].Value = objeto.Calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = objeto.NumeroCasa;
                adaptador.InsertCommand.Parameters["@provincia"].Value = objeto.Provincia;
                adaptador.InsertCommand.Parameters["@departamento"].Value = objeto.Departamento;
                adaptador.InsertCommand.Parameters["@localidad"].Value = objeto.Localidad;
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

        public void mostrarDatos(int codigoProveedor)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("select codigoProveedor, cuit, razonSocial, nombreFantasia, banco, nroCuentaCorriente, nombreContactoUno, cargoContactoUno, tipoTelefono1, nroTelefono1, nombreContactoDos, cargoContactoDos, tipoTelefono2, nroTelefono2, calle, numero, provincia, departamento, localidad, codigoPostal, nombreBarrio from Proveedores WHERE codigoProveedor = '" + codigoProveedor + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                    Cuit = lector["cuit"].ToString();
                    RazonSocial = lector["razonSocial"].ToString();
                    NombreFantasia = lector["nombreFantasia"].ToString();
                    Banco = lector["banco"].ToString();
                    NroCuentaCorriente = lector["nroCuentaCorriente"].ToString();
                    NombreContactoUno = lector["nombreContactoUno"].ToString();
                    CargoContactoUno = lector["cargoContactoUno"].ToString();
                    TipoTelefonoUno = lector["tipoTelefono1"].ToString();
                    NumeroDeTelefonoUno = lector["nroTelefono1"].ToString();
                    NombreContactoDos = lector["nombreContactoDos"].ToString();
                    CargoContactoDos = lector["cargoContactoDos"].ToString();
                    TipoTelefonoDos = lector["tipoTelefono2"].ToString();
                    NumeroDeTelefonoDos = lector["nroTelefono2"].ToString();
                    Calle = lector["calle"].ToString();
                    NumeroCasa = lector["numero"].ToString();
                    Provincia = lector["provincia"].ToString();
                    Departamento = lector["departamento"].ToString();
                    Localidad = lector["localidad"].ToString();
                    CodigoPostal = lector["codigoPostal"].ToString();
                    Barrio = lector["nombreBarrio"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }


        public Proveedor obtenerDatosProveedor(int codigoProveedor)
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
                    objeto.Banco = lector["banco"].ToString();
                    objeto.NroCuentaCorriente = lector["nroCuentaCorriente"].ToString();
                    objeto.TipoTelefonoUno = lector["tipoTelefono1"].ToString();
                    objeto.NumeroDeTelefonoUno = lector["nroTelefono1"].ToString();
                    objeto.TipoTelefonoDos = lector["tipoTelefono2"].ToString();
                    objeto.NumeroDeTelefonoDos = lector["nroTelefono2"].ToString();
                    objeto.Calle = lector["calle"].ToString();
                    objeto.NumeroCasa = lector["numero"].ToString();
                    objeto.Provincia = lector["provincia"].ToString();
                    objeto.Departamento = lector["departamento"].ToString();
                    objeto.Localidad = lector["localidad"].ToString();
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

        public int mostrarCodigoProveedor (string cuit)
        {
            int nroCodigoProveedor = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoProveedor from Proveedores WHERE cuit= '"+ cuit + "'", conexion);
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

        public List<Proveedor> mostrarDatos()
        {
            List<Proveedor> lista = new List<Proveedor>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());            
            consulta = new SqlCommand("select codigoProveedor, cuit, razonSocial, nombreFantasia, banco, nroCuentaCorriente, nombreContactoUno, cargoContactoUno, tipoTelefono1, nroTelefono1, nombreContactoDos, cargoContactoDos, tipoTelefono2, nroTelefono2, calle, numero, provincia, departamento, localidad, codigoPostal, nombreBarrio from Proveedores", conexion);
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
                                            Banco = lector["banco"].ToString(),
                                            NroCuentaCorriente = lector["nroCuentaCorriente"].ToString(),
                                            NombreContactoUno = lector["nombreContactoUno"].ToString(),
                                            CargoContactoUno = lector["cargoContactoUno"].ToString(),
                                            TipoTelefonoUno = lector["tipoTelefono1"].ToString(),
                                            NumeroDeTelefonoUno = lector["nroTelefono1"].ToString(),
                                            NombreContactoDos = lector["nombreContactoDos"].ToString(),
                                            CargoContactoDos = lector["cargoContactoDos"].ToString(),
                                            TipoTelefonoDos = lector["tipoTelefono2"].ToString(),
                                            NumeroDeTelefonoDos = lector["nroTelefono2"].ToString(),
                                            Calle = lector["calle"].ToString(),
                                            NumeroCasa = lector["numero"].ToString(),
                                            Provincia = lector["provincia"].ToString(),
                                            Departamento = lector["departamento"].ToString(),
                                            Localidad = lector["localidad"].ToString(),
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
    }
}


