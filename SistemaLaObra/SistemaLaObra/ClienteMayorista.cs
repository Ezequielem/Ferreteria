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
    public class ClienteMayorista
    {

        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        int codigoClienteMayorista;
        string cuit;
        string razonSocial;
        int codigoBanco;
        string numeroCtaCte;
        int codigoTipoTelefono;
        string numeroTelefono;
        string calle;
        int numero;
        string depto;
        string piso;
        int codigoPostal;
        string nombreBarrio; //Considerar como web car
        int codigoProvincia;
        int codigoDepartamento;
        int codigoLocalidad;

        List<string> listaNombresClientes;

        public int CodigoClienteMayorista
        {
            get
            {
                return codigoClienteMayorista;
            }

            set
            {
                codigoClienteMayorista = value;
            }
        }

        public string Cuit
        {
            get
            {
                return cuit;
            }

            set
            {
                cuit = value;
            }
        }

        public string RazonSocial
        {
            get
            {
                return razonSocial;
            }

            set
            {
                razonSocial = value;
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

        public string NumeroCtaCte
        {
            get
            {
                return numeroCtaCte;
            }

            set
            {
                numeroCtaCte = value;
            }
        }

        public int CodigoTipoTelefono
        {
            get
            {
                return codigoTipoTelefono;
            }

            set
            {
                codigoTipoTelefono = value;
            }
        }

        public string NumeroTelefono
        {
            get
            {
                return numeroTelefono;
            }

            set
            {
                numeroTelefono = value;
            }
        }

        public string Calle
        {
            get
            {
                return calle;
            }

            set
            {
                calle = value;
            }
        }

        public int Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Depto
        {
            get
            {
                return depto;
            }

            set
            {
                depto = value;
            }
        }

        public string Piso
        {
            get
            {
                return piso;
            }

            set
            {
                piso = value;
            }
        }

        public int CodigoPostal
        {
            get
            {
                return codigoPostal;
            }

            set
            {
                codigoPostal = value;
            }
        }

        public string NombreBarrio
        {
            get
            {
                return nombreBarrio;
            }

            set
            {
                nombreBarrio = value;
            }
        }

        public int CodigoProvincia
        {
            get
            {
                return codigoProvincia;
            }

            set
            {
                codigoProvincia = value;
            }
        }

        public int CodigoDepartamento
        {
            get
            {
                return codigoDepartamento;
            }

            set
            {
                codigoDepartamento = value;
            }
        }

        public int CodigoLocalidad
        {
            get
            {
                return codigoLocalidad;
            }

            set
            {
                codigoLocalidad = value;
            }
        }

        public ClienteMayorista()
        {
            CodigoClienteMayorista = 0;
            Cuit = "";
            RazonSocial = "";
            CodigoBanco = 0;
            NumeroCtaCte = "";
            CodigoTipoTelefono = 0;
            NumeroTelefono = "";
            Calle = "";
            Numero = 0;
            Depto = "";
            Piso = "";
            CodigoPostal = 0;
            NombreBarrio = "";
            CodigoProvincia = 0;
            CodigoDepartamento = 0;
            CodigoLocalidad = 0;
        }

        public void crear(ClienteMayorista cliente)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("INSERT INTO ClientesMayoristas(codigoClienteMayorista,cuit,razonSocial,codigoBanco,nroCuentaCorriente,codigoTipoTelefono,nroTelefono,calle,numero,depto,piso,codigoPostal,nombreBarrio,codigoProvincia,codigoDepartamento,codigoLocalidad) VALUES(@codigoClienteMayorista,@cuit,@razonSocial,@codigoBanco,@nroCuentaCorriente,@codigoTipoTelefono,@nroTelefono,@calle,@numero,@depto,@piso,@codigoPostal,@nombreBarrio,@codigoProvincia,@codigoDepartamento,@codigoLocalidad)", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.InsertCommand = consulta;

            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoClienteMayorista", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoTelefono", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@depto", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoProvincia", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoDepartamento", SqlDbType.Int));
            adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoLocalidad", SqlDbType.Int));

            adaptador.InsertCommand.Parameters["@codigoClienteMayorista"].Value = cliente.CodigoClienteMayorista;
            adaptador.InsertCommand.Parameters["@cuit"].Value = cliente.Cuit;
            adaptador.InsertCommand.Parameters["@razonSocial"].Value = cliente.RazonSocial;
            adaptador.InsertCommand.Parameters["@codigoBanco"].Value = cliente.CodigoBanco;
            adaptador.InsertCommand.Parameters["@nroCuentaCorriente"].Value = cliente.NumeroCtaCte;
            adaptador.InsertCommand.Parameters["@codigoTipoTelefono"].Value = cliente.CodigoTipoTelefono;
            adaptador.InsertCommand.Parameters["@nroTelefono"].Value = cliente.NumeroTelefono;
            adaptador.InsertCommand.Parameters["@calle"].Value = cliente.Calle;
            adaptador.InsertCommand.Parameters["@numero"].Value = cliente.Numero;

            if(cliente.Depto == "") adaptador.InsertCommand.Parameters["@depto"].Value = DBNull.Value;
            else adaptador.InsertCommand.Parameters["@depto"].Value = cliente.Depto;

            if(cliente.Piso == "") adaptador.InsertCommand.Parameters["@piso"].Value = DBNull.Value;
            else adaptador.InsertCommand.Parameters["@piso"].Value = cliente.Piso;

            if(cliente.CodigoPostal == 0) adaptador.InsertCommand.Parameters["@codigoPostal"].Value = DBNull.Value;
            else adaptador.InsertCommand.Parameters["@codigoPostal"].Value = cliente.CodigoPostal;

            adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = cliente.NombreBarrio;
            adaptador.InsertCommand.Parameters["@codigoProvincia"].Value = cliente.CodigoProvincia;
            adaptador.InsertCommand.Parameters["@codigoDepartamento"].Value = cliente.CodigoDepartamento;
            adaptador.InsertCommand.Parameters["@codigoLocalidad"].Value = cliente.CodigoLocalidad;

            try
            {
                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void actualizarDatos(ClienteMayorista cliente)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("UPDATE ClientesMayoristas SET codigoBanco=@codigoBanco, nroCuentaCorriente=@nroCuentaCorriente, codigoTipoTelefono=@codigoTipoTelefono, nroTelefono=@nroTelefono, calle=@calle, numero=@numero, depto=@depto, piso=@piso, codigoPostal=@codigoPostal, nombreBarrio=@nombreBarrio, codigoProvincia=@codigoProvincia, codigoDepartamento=@codigoDepartamento, codigoLocalidad=@codigoLocalidad WHERE codigoClienteMayorista=@codigoClienteMayorista", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = consulta;
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoClienteMayorista", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoBanco", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroCuentaCorriente", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoTipoTelefono", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroTelefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@depto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoProvincia", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoDepartamento", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoLocalidad", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@codigoClienteMayorista"].Value = cliente.CodigoClienteMayorista;
            adaptador.UpdateCommand.Parameters["@codigoBanco"].Value = cliente.CodigoBanco;
            adaptador.UpdateCommand.Parameters["@nroCuentaCorriente"].Value = cliente.NumeroCtaCte;
            adaptador.UpdateCommand.Parameters["@codigoTipoTelefono"].Value = cliente.CodigoTipoTelefono;
            adaptador.UpdateCommand.Parameters["@nroTelefono"].Value = cliente.NumeroTelefono;
            adaptador.UpdateCommand.Parameters["@calle"].Value = cliente.Calle;
            adaptador.UpdateCommand.Parameters["@numero"].Value = cliente.Numero;

            if (cliente.Depto == "") adaptador.UpdateCommand.Parameters["@depto"].Value = DBNull.Value;
            else adaptador.UpdateCommand.Parameters["@depto"].Value = cliente.Depto;

            if (cliente.Piso == "") adaptador.UpdateCommand.Parameters["@piso"].Value = DBNull.Value;
            else adaptador.UpdateCommand.Parameters["@piso"].Value = cliente.Piso;

            if (cliente.CodigoPostal == 0) adaptador.UpdateCommand.Parameters["@codigoPostal"].Value = DBNull.Value;
            else adaptador.UpdateCommand.Parameters["@codigoPostal"].Value = cliente.CodigoPostal;

            adaptador.UpdateCommand.Parameters["@nombreBarrio"].Value = cliente.NombreBarrio;
            adaptador.UpdateCommand.Parameters["@codigoProvincia"].Value = cliente.CodigoProvincia;
            adaptador.UpdateCommand.Parameters["@codigoDepartamento"].Value = cliente.CodigoDepartamento;
            adaptador.UpdateCommand.Parameters["@codigoLocalidad"].Value = cliente.CodigoLocalidad;

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

        public void mostrarDatos(int codigoClienteMayorista)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM ClientesMayoristas WHERE codigoClienteMayorista = '" + codigoClienteMayorista + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoClienteMayorista = int.Parse(lector["codigoClienteMayorista"].ToString());
                    Cuit = lector["cuit"].ToString();
                    RazonSocial = lector["razonSocial"].ToString();
                    CodigoBanco = int.Parse(lector["codigoBanco"].ToString());
                    NumeroCtaCte = lector["nroCuentaCorriente"].ToString();
                    CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    NumeroTelefono = lector["nroTelefono"].ToString();
                    Calle = lector["calle"].ToString();
                    Numero = int.Parse(lector["numero"].ToString());
                    Depto = lector["depto"].ToString();
                    Piso = lector["piso"].ToString();

                    int numero3;
                    bool resultado3 = int.TryParse(lector["codigoPostal"].ToString(), out numero3);
                    if (resultado3) CodigoPostal = numero3;
                    else CodigoPostal = 0;

                    NombreBarrio = lector["nombreBarrio"].ToString();
                    CodigoProvincia = int.Parse(lector["codigoProvincia"].ToString());
                    CodigoDepartamento = int.Parse(lector["codigoDepartamento"].ToString());
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                }
                else
                {
                    MessageBox.Show("No se encontro ningun cliente con el dato ingresado");
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

        public List<string> mostrarColeccionNombreClientes(string cadena)
        {
            listaNombresClientes = new List<string>();

            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT razonSocial FROM ClientesMayoristas WHERE razonSocial LIKE '" + cadena + "%'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaNombresClientes.Add(lector["razonSocial"].ToString());
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
            return listaNombresClientes;
        }

        public int buscarCliente(string razonSocial)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoClienteMayorista FROM ClientesMayoristas WHERE razonSocial = '" + razonSocial + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoClienteMayorista"].ToString());
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
        
        public string conocerBanco(int codigoBanco)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT descripcion FROM Bancos WHERE codigoBanco = '" + codigoBanco + "'", conexion);
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
                    return "";
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return "";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public string conocerTipoTelefono(int codigoTipoTelefono)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT descripcion FROM TiposTelefonos WHERE codigoTipoTelefono = '" + codigoTipoTelefono + "'", conexion);
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
                    return "";
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return "";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public string conocerProvincia(int codigoProvincia)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT descripcion FROM Provincias WHERE codigoProvincia = '" + codigoProvincia + "'", conexion);
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
                    return "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return "";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public string conocerDepartamento(int codigoDepartamento)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT descripcion FROM Departamentos WHERE codigoDepartamento = '" + codigoDepartamento + "'", conexion);
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
                    return "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return "";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public string conocerLocalidad(int codigoLocalidad)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT descripcion FROM Localidades WHERE codigoLocalidad = '" + codigoLocalidad + "'", conexion);
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
                    return "";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return "";
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public int ultimoNroClienteMayorista()
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select max(codigoClienteMayorista) as codigoClienteMayorista from ClientesMayoristas",conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    return int.Parse(lector["codigoClienteMayorista"].ToString());
                }
                else
                {
                    return 0;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                return 0;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public bool esCliente(string cuit)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("select * from ClientesMayoristas where cuit='"+ cuit +"'", conexion);

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
            catch (Exception)
            {
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
