using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class MiEmpresa
    {
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public int CodigoMiEmpresa { get; set; }
        public string NombreFantasia { get; set; }
        public string RazonSocial { get; set; }
        public string Cuit { get; set; }
        public string IngresosBrutos { get; set; }
        public DateTime FechaInicio { get; set; }
        public string NumeroTelefono { get; set; }
        public string Email { get; set; }
        public string PaginaWeb { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string CodigoPostal { get; set; }
        public string Barrio { get; set; }
        public bool Facturacion { get; set; }
        public bool Navegacion { get; set; }
        public int CodigoLocalidad { get; set; }
        public int CodigoTipoTelefono { get; set; }
        public int CodigoCondicionIva { get; set; }
        public Localidad Localidad { get; set; }
        public TipoTelefono TipoTelefono { get; set; }
        public CondicionIva CondicionIva { get; set; }        

        public MiEmpresa()
        {
            CodigoMiEmpresa = 0;
            NombreFantasia = string.Empty;
            RazonSocial = string.Empty;
            Cuit = string.Empty;
            IngresosBrutos = string.Empty;
            FechaInicio = DateTime.Today;
            NumeroTelefono = string.Empty;
            Email = string.Empty;
            PaginaWeb = string.Empty;
            Calle = string.Empty;
            Numero = string.Empty;
            CodigoPostal = string.Empty;
            Barrio = string.Empty;
            Facturacion = false;
            Navegacion = false;
            CodigoLocalidad = 0;
            CodigoTipoTelefono = 0;
            CodigoCondicionIva = 0;
            Localidad = new Localidad();
            TipoTelefono = new TipoTelefono();
            CondicionIva = new CondicionIva();
        }

        public void crear(MiEmpresa miEmpresa)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"insert into MiEmpresas (nombreFantasia, razonSocial, cuit, ingresosBrutos, fechaInicio,
                                        nroTelefono, email, paginaWeb, calle, numero, codigoPostal, nombreBarrio, facturacion,
                                        navegacion, codigoLocalidad, codigoTipoTelefono, codigoCondicionIVA) values (@nombreFantasia,
                                        @razonSocial, @cuit, @ingresosBrutos, @fechaInicio, @nroTelefono, @email, @paginaWeb, @calle,
                                        @numero, @codigoPostal, @nombreBarrio, @facturacion, @navegacion, @codigoLocalidad, @codigoTipoTelefono, @codigoCondicionIVA)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = consulta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreFantasia", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@ingresosBrutos", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.DateTime));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nroTelefono", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@paginaWeb", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@facturacion", SqlDbType.Bit));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@navegacion", SqlDbType.Bit));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoLocalidad", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoTipoTelefono", SqlDbType.Int));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@codigoCondicionIVA", SqlDbType.Int));

                adaptador.InsertCommand.Parameters["@nombreFantasia"].Value = miEmpresa.NombreFantasia;
                adaptador.InsertCommand.Parameters["@razonSocial"].Value = miEmpresa.RazonSocial;
                adaptador.InsertCommand.Parameters["@cuit"].Value = miEmpresa.Cuit;
                adaptador.InsertCommand.Parameters["@ingresosBrutos"].Value = miEmpresa.IngresosBrutos;
                adaptador.InsertCommand.Parameters["@fechaInicio"].Value = miEmpresa.FechaInicio;
                adaptador.InsertCommand.Parameters["@nroTelefono"].Value = miEmpresa.NumeroTelefono;
                adaptador.InsertCommand.Parameters["@email"].Value = miEmpresa.Email;
                adaptador.InsertCommand.Parameters["@paginaWeb"].Value = miEmpresa.PaginaWeb;
                adaptador.InsertCommand.Parameters["@calle"].Value = miEmpresa.Calle;
                adaptador.InsertCommand.Parameters["@numero"].Value = miEmpresa.Numero;
                adaptador.InsertCommand.Parameters["@codigoPostal"].Value = miEmpresa.CodigoPostal;
                adaptador.InsertCommand.Parameters["@nombreBarrio"].Value = miEmpresa.Barrio;
                adaptador.InsertCommand.Parameters["@facturacion"].Value = miEmpresa.Facturacion;
                adaptador.InsertCommand.Parameters["@navegacion"].Value = miEmpresa.Navegacion;
                adaptador.InsertCommand.Parameters["@codigoLocalidad"].Value = miEmpresa.Localidad.CodigoLocalidad;
                adaptador.InsertCommand.Parameters["@codigoTipoTelefono"].Value = miEmpresa.TipoTelefono.CodigoTipoTelefono;
                adaptador.InsertCommand.Parameters["@codigoCondicionIVA"].Value = miEmpresa.CondicionIva.CodigoCondicionIva;

                conexion.Open();
                adaptador.InsertCommand.ExecuteNonQuery();                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void modificar(MiEmpresa miEmpresa)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"update MiEmpresas set nombreFantasia=@nombreFantasia, razonSocial=@razonSocial, cuit=@cuit, ingresosBrutos=@ingresosBrutos,
                                        fechaInicio=@fechaInicio, nroTelefono=@nroTelefono, email=@email, paginaWeb=@paginaWeb, calle=@calle, numero=@numero, codigoPostal=@codigoPostal,
                                        nombreBarrio=@nombreBarrio, facturacion=@facturacion, navegacion=@navegacion, codigoLocalidad=@codigoLocalidad,
                                        codigoTipoTelefono=@codigoTipoTelefono, codigoCondicionIVA=@codigoCondicionIVA where codigoMiEmpresa=@codigoMiEmpresa", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.UpdateCommand = consulta;
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoMiEmpresa", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreFantasia", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@ingresosBrutos", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@fechaInicio", SqlDbType.DateTime));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nroTelefono", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@email", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@paginaWeb", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@calle", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@numero", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreBarrio", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@facturacion", SqlDbType.Bit));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@navegacion", SqlDbType.Bit));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoLocalidad", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoTipoTelefono", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoCondicionIVA", SqlDbType.Int));

                adaptador.UpdateCommand.Parameters["@codigoMiEmpresa"].Value = miEmpresa.CodigoMiEmpresa;
                adaptador.UpdateCommand.Parameters["@nombreFantasia"].Value = miEmpresa.NombreFantasia;
                adaptador.UpdateCommand.Parameters["@razonSocial"].Value = miEmpresa.RazonSocial;
                adaptador.UpdateCommand.Parameters["@cuit"].Value = miEmpresa.Cuit;
                adaptador.UpdateCommand.Parameters["@ingresosBrutos"].Value = miEmpresa.IngresosBrutos;
                adaptador.UpdateCommand.Parameters["@fechaInicio"].Value = miEmpresa.FechaInicio;
                adaptador.UpdateCommand.Parameters["@nroTelefono"].Value = miEmpresa.NumeroTelefono;
                adaptador.UpdateCommand.Parameters["@email"].Value = miEmpresa.Email;
                adaptador.UpdateCommand.Parameters["@paginaWeb"].Value = miEmpresa.PaginaWeb;
                adaptador.UpdateCommand.Parameters["@calle"].Value = miEmpresa.Calle;
                adaptador.UpdateCommand.Parameters["@numero"].Value = miEmpresa.Numero;
                adaptador.UpdateCommand.Parameters["@codigoPostal"].Value = miEmpresa.CodigoPostal;
                adaptador.UpdateCommand.Parameters["@nombreBarrio"].Value = miEmpresa.Barrio;
                adaptador.UpdateCommand.Parameters["@facturacion"].Value = miEmpresa.Facturacion;
                adaptador.UpdateCommand.Parameters["@navegacion"].Value = miEmpresa.Navegacion;
                adaptador.UpdateCommand.Parameters["@codigoLocalidad"].Value = miEmpresa.Localidad.CodigoLocalidad;
                adaptador.UpdateCommand.Parameters["@codigoTipoTelefono"].Value = miEmpresa.TipoTelefono.CodigoTipoTelefono;
                adaptador.UpdateCommand.Parameters["@codigoCondicionIVA"].Value = miEmpresa.CondicionIva.CodigoCondicionIva;

                conexion.Open();
                adaptador.UpdateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public void eliminar(MiEmpresa miEmpresa)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("delete from MiEmpresas where codigoMiEmpresa=@codigoMiEmpresa", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.DeleteCommand = consulta;
                adaptador.DeleteCommand.Parameters.Add(new SqlParameter("@codigoMiEmpresa", SqlDbType.Int));
                adaptador.DeleteCommand.Parameters["@codigoMiEmpresa"].Value = miEmpresa.CodigoMiEmpresa;
                conexion.Open();
                adaptador.DeleteCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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
            consulta = new SqlCommand(@"select codigoMiEmpresa, nombreFantasia, razonSocial, cuit, ingresosBrutos, fechaInicio, nroTelefono,
                                        email, paginaWeb, calle, numero, codigoPostal, nombreBarrio, facturacion, navegacion, codigoLocalidad,
                                        codigoTipoTelefono, codigoCondicionIVA from MiEmpresas where codigoMiEmpresa='"+ codigo +"'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString());
                    NombreFantasia = lector["nombreFantasia"].ToString();
                    RazonSocial = lector["razonSocial"].ToString();
                    Cuit = lector["cuit"].ToString();
                    IngresosBrutos = lector["ingresosBrutos"].ToString();
                    FechaInicio = DateTime.Parse(lector["fechaInicio"].ToString());
                    NumeroTelefono = lector["nroTelefono"].ToString();
                    Email = lector["email"].ToString();
                    PaginaWeb = lector["paginaWeb"].ToString();
                    Calle = lector["calle"].ToString();
                    Numero = lector["numero"].ToString();
                    CodigoPostal = lector["codigoPostal"].ToString();
                    Barrio = lector["nombreBarrio"].ToString();
                    Facturacion = bool.Parse(lector["facturacion"].ToString());
                    Navegacion = bool.Parse(lector["navegacion"].ToString());
                    CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString());
                    CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString());
                    CodigoCondicionIva = int.Parse(lector["codigoCondicionIVA"].ToString());
                    Localidad.mostrarDatos(CodigoLocalidad);
                    TipoTelefono.mostrarDatos(CodigoTipoTelefono);
                    CondicionIva.mostrarDatos(CodigoCondicionIva);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public List<MiEmpresa> mostrarDatos()
        {
            List<MiEmpresa> lista = new List<MiEmpresa>();
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand(@"select codigoMiEmpresa, nombreFantasia, razonSocial, cuit, ingresosBrutos, fechaInicio, nroTelefono,
                                        email, paginaWeb, calle, numero, codigoPostal, nombreBarrio, facturacion, navegacion, codigoLocalidad,
                                        codigoTipoTelefono, codigoCondicionIVA from MiEmpresas", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {                    
                    lista.Add(new MiEmpresa() {
                        CodigoMiEmpresa = int.Parse(lector["codigoMiEmpresa"].ToString()),
                        NombreFantasia = lector["nombreFantasia"].ToString(),
                        RazonSocial = lector["razonSocial"].ToString(),
                        Cuit = lector["cuit"].ToString(),
                        IngresosBrutos = lector["ingresosBrutos"].ToString(),
                        FechaInicio = DateTime.Parse(lector["fechaInicio"].ToString()),
                        NumeroTelefono = lector["nroTelefono"].ToString(),
                        Email = lector["email"].ToString(),
                        PaginaWeb = lector["paginaWeb"].ToString(),
                        Calle = lector["calle"].ToString(),
                        Numero = lector["numero"].ToString(),
                        CodigoPostal = lector["codigoPostal"].ToString(),
                        Barrio = lector["nombreBarrio"].ToString(),
                        Facturacion = bool.Parse(lector["facturacion"].ToString()),
                        Navegacion = bool.Parse(lector["navegacion"].ToString()),
                        CodigoLocalidad = int.Parse(lector["codigoLocalidad"].ToString()),
                        CodigoTipoTelefono = int.Parse(lector["codigoTipoTelefono"].ToString()),
                        CodigoCondicionIva = int.Parse(lector["codigoCondicionIVA"].ToString()),                        
                });
                    
                }
                return lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return lista;                
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public bool existe(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from MiEmpresas where codigoMiEmpresa='"+ codigo +"'", conexion);
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }

        public bool existeCUIT(string codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from MiEmpresas where cuit='" + codigo + "'", conexion);
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
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }
        
        public bool existenUsuarios(int codigo)
        {
            AccesoDatos s = new AccesoDatos();
            conexion = new SqlConnection(s.CadenaConexion());
            consulta = new SqlCommand("select * from Encargados where codigoMiEmpresa='"+ codigo +"'", conexion);
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
            finally
            {
                conexion.Close();
                lector.Close();
            }
        }
    }
}
