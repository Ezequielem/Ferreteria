using SistemaLaObra.InicioSesion;
using SistemaLaObra.Modelo;
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
    public class Encargado
    {
        AccesoDatos acceso;
        SqlConnection conexion;
        SqlCommand consulta;
        SqlDataReader lector;
        SqlDataAdapter adaptador;

        public int CodigoEncargado { get; set; }
        public int Legajo { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public int CodigoTipoDocumento { get; set; }
        public String NroDocumento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int CodigoTipoTelefono { get; set; }
        public String NroTelefono { get; set; }
        public String Calle { get; set; }
        public String Numero { get; set; }
        public String Depto { get; set; }
        public String Piso { get; set; }
        public String NombreBarrio { get; set; }
        public String CodigoPostal { get; set; }
        public int CodigoLocalidad { get; set; }
        public int CodigoUsuario { get; set; }
        public int CodigoMiEmpresa { get; set; }
        public MiEmpresa MiEmpresa { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public Localidad Localidad { get; set; }
        public Usuario Usuario { get; set; }

        public Encargado()
        {
            MiEmpresa = new MiEmpresa();
            TipoDocumento = new TipoDocumento();
            TipoTelefono = new TipoTelefono();
            Localidad = new Localidad();
            Usuario = new Usuario();
        }

        public void crear(Encargado encargado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand(@"INSERT INTO Encargados(legajo,nombre,apellido,codigoTipoDocumento,
                                        nroDocumento,fechaNacimiento,codigoTipoTelefono,nroTelefono,calle,numero,depto,piso,
                                        codigoPostal,nombreBarrio,codigoLocalidad,
                                        codigoUsuario, codigoMiEmpresa) VALUES(@legajo,@nombre,@apellido,
                                        @codigoTipoDocumento,@nroDocumento,@fechaNacimiento,@codigoTipoTelefono,@nroTelefono,
                                        @calle,@numero,@depto,@piso,@codigoPostal,@nombreBarrio,
                                        @codigoLocalidad,@codigoUsuario, @codigoMiEmpresa)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = consulta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@legajo", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoDocumento", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroDocumento", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.Date));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoTelefono", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@depto", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoLocalidad", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoUsuario", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoMiEmpresa", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@legajo"].Value = encargado.Legajo;
                adaptador.InsertCommand.Parameters["@nombre"].Value = encargado.Nombre;
                adaptador.InsertCommand.Parameters["@apellido"].Value = encargado.Apellido;
                adaptador.InsertCommand.Parameters["@nombre"].Value = encargado.Nombre;
                adaptador.InsertCommand.Parameters["@codigoTipoDocumento"].Value = encargado.TipoDocumento.CodigoTipoDocumento;
                adaptador.InsertCommand.Parameters["@nroDocumento"].Value = encargado.NroDocumento;
                adaptador.InsertCommand.Parameters["@fechaNacimiento"].Value = encargado.FechaNacimiento;
                adaptador.InsertCommand.Parameters["@codigoTipoTelefono"].Value = encargado.TipoTelefono.CodigoTipoTelefono;
                adaptador.InsertCommand.Parameters["@nroTelefono"].Value = encargado.NroTelefono;
                adaptador.InsertCommand.Parameters["@calle"].Value = encargado.Calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = encargado.Numero;
                adaptador.InsertCommand.Parameters["@depto"].Value = encargado.Depto;
                adaptador.InsertCommand.Parameters["@piso"].Value = encargado.Piso;
                adaptador.InsertCommand.Parameters["@codigoPostal"].Value = encargado.CodigoPostal;
                adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = encargado.NombreBarrio;
                adaptador.InsertCommand.Parameters["@codigoLocalidad"].Value = encargado.Localidad.CodigoLocalidad;
                adaptador.InsertCommand.Parameters["@codigoUsuario"].Value = encargado.Usuario.CodigoUsuario;
                adaptador.InsertCommand.Parameters["@codigoMiEmpresa"].Value = encargado.MiEmpresa.CodigoMiEmpresa;
            
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

        public void actualizar(Encargado encargado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand(@"UPDATE Encargados SET nombre = @nombre, 
                                                              apellido = @apellido,
                                                              codigoTipoDocumento = @codigoTipoDocumento,
                                                              nroDocumento = @nroDocumento,
                                                              fechaNacimiento = @fechaNacimiento,
                                                              codigoTipoTelefono = @codigoTipoTelefono,
                                                              nroTelefono = @nroTelefono,
                                                              calle = @calle,
                                                              numero = @numero,
                                                              depto = @depto,
                                                              piso = @piso,
                                                              codigoPostal = @codigoPostal,
                                                              nombreBarrio = @nombreBarrio,
                                                              codigoLocalidad = @codigoLocalidad,
                                                              codigoMiEmpresa = @codigoMiEmpresa
                                                              WHERE codigoEncargado = @codigoEncargado", conexion);
            adaptador = new SqlDataAdapter();
            adaptador.UpdateCommand = consulta;

            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoEncargado", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoTipoDocumento", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroDocumento", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechaNacimiento", SqlDbType.Date));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoTipoTelefono", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroTelefono", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@depto", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@piso", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoLocalidad", SqlDbType.Int));
            adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoMiEmpresa", SqlDbType.Int));

            adaptador.UpdateCommand.Parameters["@codigoEncargado"].Value = encargado.CodigoEncargado;
            adaptador.UpdateCommand.Parameters["@nombre"].Value = encargado.Nombre;
            adaptador.UpdateCommand.Parameters["@apellido"].Value = encargado.Apellido;
            adaptador.UpdateCommand.Parameters["@nombre"].Value = encargado.Nombre;
            adaptador.UpdateCommand.Parameters["@codigoTipoDocumento"].Value = encargado.CodigoTipoDocumento;
            adaptador.UpdateCommand.Parameters["@nroDocumento"].Value = encargado.NroDocumento;
            adaptador.UpdateCommand.Parameters["@fechaNacimiento"].Value = encargado.FechaNacimiento;
            adaptador.UpdateCommand.Parameters["@codigoTipoTelefono"].Value = encargado.CodigoTipoTelefono;
            adaptador.UpdateCommand.Parameters["@nroTelefono"].Value = encargado.NroTelefono;
            adaptador.UpdateCommand.Parameters["@calle"].Value = encargado.Calle;
            adaptador.UpdateCommand.Parameters["@numero"].Value = encargado.Numero;
            adaptador.UpdateCommand.Parameters["@depto"].Value = encargado.Depto;
            adaptador.UpdateCommand.Parameters["@piso"].Value = encargado.Piso;
            adaptador.UpdateCommand.Parameters["@codigoPostal"].Value = encargado.CodigoPostal;
            adaptador.UpdateCommand.Parameters["@nombreBarrio"].Value = encargado.NombreBarrio;
            adaptador.UpdateCommand.Parameters["@codigoLocalidad"].Value = encargado.CodigoLocalidad;
            adaptador.UpdateCommand.Parameters["@codigoMiEmpresa"].Value = encargado.CodigoMiEmpresa;

            try
            {
                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
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

        public void mostrarDatos(int codigoEncargado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Encargados WHERE codigoEncargado = '" + codigoEncargado + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString());
                    Legajo = int.Parse(lector["legajo"].ToString());
                    Nombre = lector["nombre"].ToString();
                    Apellido = lector["apellido"].ToString();
                    CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString());
                    NroDocumento = lector["nroDocumento"].ToString();
                    FechaNacimiento = (DateTime)lector["fechaNacimiento"];
                    CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    NroTelefono = lector["nroTelefono"].ToString();
                    Calle = lector["calle"].ToString();
                    Numero =lector["numero"].ToString();
                    Depto = lector["depto"].ToString();
                    Piso = lector["piso"].ToString();
                    CodigoPostal = lector["codigoPostal"].ToString();
                    NombreBarrio = lector["nombreBarrio"].ToString();
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                    CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                    CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString());
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

        public List<Encargado> mostrarDatos()
        {
            List<Encargado> lista = new List<Encargado>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Encargados", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new Encargado() 
                    {
                        CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString()),
                        Legajo = int.Parse(lector["legajo"].ToString()),
                        Nombre = lector["nombre"].ToString(),
                        Apellido = lector["apellido"].ToString(),
                        CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString()),
                        NroDocumento = lector["nroDocumento"].ToString(),
                        FechaNacimiento = (DateTime)lector["fechaNacimiento"],
                        CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString()),
                        NroTelefono = lector["nroTelefono"].ToString(),
                        Calle = lector["calle"].ToString(),
                        Numero = lector["numero"].ToString(),
                        Depto = lector["depto"].ToString(),
                        Piso = lector["piso"].ToString(),
                        CodigoPostal = lector["codigoPostal"].ToString(),
                        NombreBarrio = lector["nombreBarrio"].ToString(),
                        CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString()),
                        CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString()),
                        CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString())
                    });                    
                }
                return lista;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public Encargado obtenerDatos(int codigoEncargado)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Encargados WHERE codigoEncargado = '" + codigoEncargado + "'", conexion);

            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    this.CodigoEncargado = int.Parse(lector["codigoEncargado"].ToString());
                    this.Legajo = int.Parse(lector["legajo"].ToString());
                    this.Nombre = lector["nombre"].ToString();
                    this.Apellido = lector["apellido"].ToString();
                    this.CodigoTipoDocumento = int.Parse(lector["codigoTipoDocumento"].ToString());
                    this.NroDocumento = lector["nroDocumento"].ToString();
                    this.FechaNacimiento = (DateTime)lector["fechaNacimiento"];
                    this.CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    this.NroTelefono = lector["nroTelefono"].ToString();
                    this.Calle = lector["calle"].ToString();
                    this.Numero = lector["numero"].ToString();
                    this.Depto = lector["depto"].ToString();
                    this.Piso = lector["piso"].ToString();
                    this.CodigoPostal = lector["codigoPostal"].ToString();
                    this.NombreBarrio = lector["nombreBarrio"].ToString();
                    this.CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                    this.CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                    this.CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString());
                }
                return this;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
                return this;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public int obtenerCodigoEncargado(int codigoUsuario)
        {
            int codigoEncargado = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoEncargado FROM Encargados WHERE codigoUsuario = '" + codigoUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    codigoEncargado = int.Parse(lector["codigoEncargado"].ToString());
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
            return codigoEncargado;
        }        
    }
}
