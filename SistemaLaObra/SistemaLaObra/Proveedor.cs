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

        private int _codigoProveedor;
        private long _cuit;
        private string _razonSocial;
        private string _banco;
        private int _codigoBanco;
        private long _nroCuentaCorriente;
        private string _tipoTelefonoUno;
        private long _numeroTelefonoUno;
        private string _tipoTelefonoDos;
        private long _numeroTelefonoDos;
        private string _calle;
        private string _barrio;
        private int _numeroCasa;
        private string _provincia;
        private string _departamento;
        private string _localidad;
        private int _codigoPostal;

        public Proveedor()
        {

        }

        public int CodigoProveedor
        {
            get
            {
                return _codigoProveedor;
            }

            set
            {
                _codigoProveedor = value;
            }
        }

        public long Cuit
        {
            get
            {
                return _cuit;
            }

            set
            {
                _cuit = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return _razonSocial;
            }

            set
            {
                _razonSocial = value;
            }
        }

        public string Banco
        {
            get
            {
                return _banco;
            }

            set
            {
                _banco = value;
            }
        }


        public int CodigoBanco
        {
            get
            {
                return _codigoBanco;
            }

            set
            {
                _codigoBanco = value;
            }
        }

        public long NroCuentaCorriente
        {
            get
            {
                return _nroCuentaCorriente;
            }

            set
            {
                _nroCuentaCorriente = value;
            }
        }


        public string TipoTelefonoUno
        {
            get
            {
                return _tipoTelefonoUno;
            }

            set
            {
                _tipoTelefonoUno = value;
            }
        }

        public long NumeroDeTelefonoUno
        {
            get
            {
                return _numeroTelefonoUno;
            }

            set
            {
                _numeroTelefonoUno = value;
            }
        }

        public string TipoTelefonoDos
        {
            get
            {
                return _tipoTelefonoDos;
            }

            set
            {
                _tipoTelefonoDos = value;
            }
        }

        public long NumeroDeTelefonoDos
        {
            get
            {
                return _numeroTelefonoDos;
            }

            set
            {
                _numeroTelefonoDos = value;
            }
        }

        public string Calle
        {
            get
            {
                return _calle;
            }

            set
            {
                _calle = value;
            }
        }


        public string Barrio
        {
            get
            {
                return _barrio;
            }

            set
            {
                _barrio = value;
            }
        }


        public int NumeroCasa
        {
            get
            {
                return _numeroCasa;
            }

            set
            {
                _numeroCasa = value;
            }
        }

        public string Provincia
        {
            get
            {
                return _provincia;
            }

            set
            {
                _provincia = value;
            }
        }

        public string Departamento
        {
            get
            {
                return _departamento;
            }

            set
            {
                _departamento = value;
            }
        }

        public string Localidad
        {
            get
            {
                return _localidad;
            }

            set
            {
                _localidad = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return _codigoPostal;
            }

            set
            {
                _codigoPostal = value;
            }
        }

        //METODOS

        public int esProveedor (long cuit)
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

        public void actualizar (int codigoProveedor, long cuit, string razonSocial, string banco, long nroCuentaCorriente, string tipoTelefono1, long nroTelefono1, string tipoTelefono2, long nroTelefono2, string calle, int numero, string provincia, string departamento, string localidad, int codigoPostal, string nombreBarrio)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                consulta = new SqlCommand("UPDATE Proveedores SET cuit=@cuit, razonSocial=@razonSocial, banco=@banco, nroCuentaCorriente=@nroCuentaCorriente, tipoTelefono1=@tipoTelefono1, nroTelefono1=@nroTelefono1, tipoTelefono2=@tipoTelefono2, nroTelefono2=@nroTelefono2, calle=@calle,  numero=@numero, provincia=@provincia, departamento=@departamento, localidad=@localidad, codigoPostal=@codigoPostal, nombreBarrio=@nombreBarrio WHERE codigoProveedor = @codigoProveedor", conexion);
        
                adaptador.InsertCommand = consulta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@banco", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono1", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono2", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = codigoProveedor;
                adaptador.InsertCommand.Parameters["@cuit"].Value = cuit;
                adaptador.InsertCommand.Parameters["@razonSocial"].Value = razonSocial;
                adaptador.InsertCommand.Parameters["@banco"].Value = banco;
                adaptador.InsertCommand.Parameters["@nroCuentaCorriente"].Value = nroCuentaCorriente;
                adaptador.InsertCommand.Parameters["@tipoTelefono1"].Value = tipoTelefono1;
                adaptador.InsertCommand.Parameters["@nroTelefono1"].Value = nroTelefono1;
                adaptador.InsertCommand.Parameters["@tipoTelefono2"].Value = tipoTelefono2;
                adaptador.InsertCommand.Parameters["@nroTelefono2"].Value = nroTelefono2;
                adaptador.InsertCommand.Parameters["@calle"].Value = calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = numero;
                adaptador.InsertCommand.Parameters["@provincia"].Value = provincia;
                adaptador.InsertCommand.Parameters["@departamento"].Value = departamento;
                adaptador.InsertCommand.Parameters["@localidad"].Value = localidad;
                adaptador.InsertCommand.Parameters["@codigoPostal"].Value = codigoPostal;
                adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = nombreBarrio;

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


        public void crear(int codigoProveedor, long cuit, string razonSocial, string banco, long nroCuentaCorriente, string tipoTelefono1, long nroTelefono1, string tipoTelefono2, long nroTelefono2, string calle, int numero, string provincia, string departamento, string localidad, int codigoPostal, string nombreBarrio)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();

            try
            {
                SqlCommand alta = new SqlCommand("insert into Proveedores (codigoProveedor, cuit, razonSocial, banco, nroCuentaCorriente, tipoTelefono1, nroTelefono1, tipoTelefono2, nroTelefono2, calle, numero, provincia, departamento, localidad, codigoPostal, nombreBarrio) values (@codigoProveedor, @cuit, @razonSocial, @banco, @nroCuentaCorriente, @tipoTelefono1, @nroTelefono1, @tipoTelefono2, @nroTelefono2, @calle, @numero, @provincia, @departamento, @localidad, @codigoPostal, @nombreBarrio)", conexion);
                adaptador.InsertCommand = alta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProveedor", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@banco", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono1", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono1", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@tipoTelefono2", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono2", SqlDbType.BigInt));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@departamento", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@localidad", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));

                adaptador.InsertCommand.Parameters["@codigoProveedor"].Value = codigoProveedor;
                adaptador.InsertCommand.Parameters["@cuit"].Value = cuit;
                adaptador.InsertCommand.Parameters["@razonSocial"].Value = razonSocial;
                adaptador.InsertCommand.Parameters["@banco"].Value = banco;
                adaptador.InsertCommand.Parameters["@nroCuentaCorriente"].Value = nroCuentaCorriente;
                adaptador.InsertCommand.Parameters["@tipoTelefono1"].Value = tipoTelefono1;
                adaptador.InsertCommand.Parameters["@nroTelefono1"].Value = nroTelefono1;
                adaptador.InsertCommand.Parameters["@tipoTelefono2"].Value = tipoTelefono2;
                adaptador.InsertCommand.Parameters["@nroTelefono2"].Value = nroTelefono2;
                adaptador.InsertCommand.Parameters["@calle"].Value = calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = numero;
                adaptador.InsertCommand.Parameters["@provincia"].Value = provincia;
                adaptador.InsertCommand.Parameters["@departamento"].Value = departamento;
                adaptador.InsertCommand.Parameters["@localidad"].Value = localidad;
                adaptador.InsertCommand.Parameters["@codigoPostal"].Value = codigoPostal;
                adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = nombreBarrio;

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

        public void mostrarDatos()
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();
            if (Cuit != 0)
                consulta = new SqlCommand("SELECT * FROM Proveedores WHERE cuit = '" + Cuit + "'", conexion);
            else if (RazonSocial != "")
                consulta = new SqlCommand("SELECT * FROM Proveedores WHERE razonSocial = '" + RazonSocial + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                    Cuit = long.Parse(lector["cuit"].ToString());
                    RazonSocial = lector["razonSocial"].ToString();
                    Banco = lector["banco"].ToString();
                    NroCuentaCorriente = long.Parse(lector["nroCuentaCorriente"].ToString());
                    TipoTelefonoUno = lector["tipoTelefono1"].ToString();
                    NumeroDeTelefonoUno = long.Parse(lector["nroTelefono1"].ToString());
                    TipoTelefonoDos = lector["tipoTelefono2"].ToString();
                    NumeroDeTelefonoDos = long.Parse(lector["nroTelefono2"].ToString());
                    Calle = lector["calle"].ToString();
                    NumeroCasa = int.Parse(lector["numero"].ToString());
                    Provincia = lector["provincia"].ToString();
                    Departamento = lector["departamento"].ToString();
                    Localidad = lector["localidad"].ToString();
                    CodigoPostal = int.Parse(lector["codigoPostal"].ToString());
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

        public void mostrarDatosProveedor(int codigoProveedor)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("SELECT * FROM Proveedores WHERE codigoProveedor = '" + codigoProveedor + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                    Cuit = long.Parse(lector["cuit"].ToString());
                    RazonSocial = lector["razonSocial"].ToString();
                    Banco = lector["banco"].ToString();
                    NroCuentaCorriente = long.Parse(lector["nroCuentaCorriente"].ToString());
                    TipoTelefonoUno = lector["tipoTelefono1"].ToString();
                    NumeroDeTelefonoUno = long.Parse(lector["nroTelefono1"].ToString());
                    TipoTelefonoDos = lector["tipoTelefono2"].ToString();
                    NumeroDeTelefonoDos = long.Parse(lector["nroTelefono2"].ToString());
                    Calle = lector["calle"].ToString();
                    NumeroCasa = int.Parse(lector["numero"].ToString());
                    Provincia = lector["provincia"].ToString();
                    Departamento = lector["departamento"].ToString();
                    Localidad = lector["localidad"].ToString();
                    CodigoPostal = int.Parse(lector["codigoPostal"].ToString());
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
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            adaptador = new SqlDataAdapter();
            consulta = new SqlCommand("SELECT * FROM Proveedores WHERE codigoProveedor = '" + codigoProveedor + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    objeto.CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString());
                    objeto.Cuit = long.Parse(lector["cuit"].ToString());
                    objeto.RazonSocial = lector["razonSocial"].ToString();
                    objeto.Banco = lector["banco"].ToString();
                    objeto.NroCuentaCorriente = long.Parse(lector["nroCuentaCorriente"].ToString());
                    objeto.TipoTelefonoUno = lector["tipoTelefono1"].ToString();
                    objeto.NumeroDeTelefonoUno = long.Parse(lector["nroTelefono1"].ToString());
                    objeto.TipoTelefonoDos = lector["tipoTelefono2"].ToString();
                    objeto.NumeroDeTelefonoDos = long.Parse(lector["nroTelefono2"].ToString());
                    objeto.Calle = lector["calle"].ToString();
                    objeto.NumeroCasa = int.Parse(lector["numero"].ToString());
                    objeto.Provincia = lector["provincia"].ToString();
                    objeto.Departamento = lector["departamento"].ToString();
                    objeto.Localidad = lector["localidad"].ToString();
                    objeto.CodigoPostal = int.Parse(lector["codigoPostal"].ToString());
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

        public int mostrarCodigoProveedor (long cuit)
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

        public List<Proveedor> mostrarColeccionProveedores()
        {
            List<Proveedor> lista = new List<Proveedor>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());            
            consulta = new SqlCommand("SELECT * FROM Proveedores", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Proveedor() {
                                            CodigoProveedor = int.Parse(lector["codigoProveedor"].ToString()),
                                            Cuit = long.Parse(lector["cuit"].ToString()),
                                            RazonSocial = lector["razonSocial"].ToString(),
                                            Banco = lector["banco"].ToString(),
                                            NroCuentaCorriente = long.Parse(lector["nroCuentaCorriente"].ToString()),
                                            TipoTelefonoUno = lector["tipoTelefono1"].ToString(),
                                            NumeroDeTelefonoUno = long.Parse(lector["nroTelefono1"].ToString()),
                                            TipoTelefonoDos = lector["tipoTelefono2"].ToString(),
                                            NumeroDeTelefonoDos = long.Parse(lector["nroTelefono2"].ToString()),
                                            Calle = lector["calle"].ToString(),
                                            NumeroCasa = int.Parse(lector["numero"].ToString()),
                                            Provincia = lector["provincia"].ToString(),
                                            Departamento = lector["departamento"].ToString(),
                                            Localidad = lector["localidad"].ToString(),
                                            CodigoPostal = int.Parse(lector["codigoPostal"].ToString()),
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
    }
}


