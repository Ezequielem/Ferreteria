﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaLaObra.Modelo
{
    public class Usuario
    {
        private AccesoDatos acceso;
        private SqlConnection conexion;
        private SqlDataAdapter adaptador;
        private SqlDataReader lector;
        private SqlCommand consulta;

        public int CodigoUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }

        public Usuario()
        {
            CodigoUsuario = 0;
            NombreUsuario = "";
            Contraseña = "";
        }

        public void crear(Usuario usuario)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand(@"INSERT INTO Usuarios (nombreUsuario,contraseña) 
                                        VALUES (@nombreUsuario,@contraseña)", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.InsertCommand = consulta;
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@nombreUsuario", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters.Add(new SqlParameter("@contraseña", SqlDbType.VarChar));
                adaptador.InsertCommand.Parameters["@nombreUsuario"].Value = usuario.NombreUsuario;
                adaptador.InsertCommand.Parameters["@contraseña"].Value = usuario.Contraseña;
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

        public void actualizar(Usuario usuario)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand(@"update Usuarios set nombreUsuario=@nombreUsuario, contraseña=@contraseña where codigoUsuario=@codigoUsuario", conexion);
            try
            {
                adaptador = new SqlDataAdapter();
                adaptador.UpdateCommand = consulta;
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@nombreUsuario", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@contraseña", SqlDbType.VarChar));
                adaptador.UpdateCommand.Parameters.Add(new SqlParameter("@codigoUsuario", SqlDbType.Int));
                adaptador.UpdateCommand.Parameters["@nombreUsuario"].Value = usuario.NombreUsuario;
                adaptador.UpdateCommand.Parameters["@contraseña"].Value = usuario.Contraseña;
                adaptador.UpdateCommand.Parameters["@codigoUsuario"].Value = usuario.CodigoUsuario;
                conexion.Open();
                consulta.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public void mostrarDatos(int codigoUsuario)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Usuarios WHERE codigoUsuario='" + codigoUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                    NombreUsuario = lector["nombreUsuario"].ToString();
                    Contraseña = lector["contraseña"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public void mostrarDatos(string nombreUsuario)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT * FROM Usuarios WHERE nombreUsuario='" + nombreUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                    NombreUsuario = lector["nombreUsuario"].ToString();
                    Contraseña = lector["contraseña"].ToString();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public List<Usuario> mostrarDatos()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoUsuario,nombreUsuario FROM Usuarios", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    listaUsuario.Add(new Usuario
                    {
                        CodigoUsuario = int.Parse(lector["codigoUsuario"].ToString()),
                        NombreUsuario = lector["nombreUsuario"].ToString()
                    });
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
            return listaUsuario;
        }

        public int obtenerCodigoUsuario(string nombreUsuario)
        {
            int codigoUsuario = 0;
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT codigoUsuario FROM Usuarios WHERE nombreUsuario='" + nombreUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                if (lector.Read())
                {
                    codigoUsuario = int.Parse(lector["codigoUsuario"].ToString());
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
            return codigoUsuario;
        }

        public bool comprobarContraseña(string contraseña)
        {
            if (Contraseña == contraseña)
                return true;
            else
                return false;
        }

        public List<TipoDeAcceso_X_Usuario> obtenerTipoAcceso(int codigoUsuario)
        {
            List<TipoDeAcceso_X_Usuario> lista = new List<TipoDeAcceso_X_Usuario>();
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand(@"select CodigoTipoAcceso, CodigoUsuario from TiposDeAccesos_X_Usuarios 
                                        where CodigoUsuario='" + codigoUsuario + "'", conexion);
            try
            {
                conexion.Open();
                lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    lista.Add(new TipoDeAcceso_X_Usuario()
                    {
                        CodigoTipoAcceso = int.Parse(lector["CodigoTipoAcceso"].ToString()),
                        CodigoUsuario = int.Parse(lector["CodigoUsuario"].ToString())
                    });
                }
                return lista;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                return lista;
            }
            finally
            {
                lector.Close();
                conexion.Close();
            }
        }

        public bool existe(string nombreUsuario)
        {
            acceso = new AccesoDatos();
            conexion = new SqlConnection(acceso.CadenaConexion());
            consulta = new SqlCommand("SELECT nombreUsuario FROM Usuarios where nombreUsuario='" + nombreUsuario + "'", conexion);
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
                MessageBox.Show(error.Message);
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
