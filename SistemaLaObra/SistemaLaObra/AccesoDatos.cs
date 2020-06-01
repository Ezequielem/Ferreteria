using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using SistemaLaObra.Properties;

namespace SistemaLaObra
{
    class AccesoDatos
    {
        //string conexion; 

        public string CadenaConexion()
        {
            //conexion = @"Data Source=PC-EZEQUIEL\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True"; EZEQUIEL

            //conexion = @"Data Source=DESKTOP-928I2N6\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True"; //NOTEBOOK EZE

            //conexion = @"Data Source=FRONTERA\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True"; //MARTIN

            //conexion = @"Data Source=DESKTOP-GJK2S05\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //GERARDO

            //connectionString="Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\eemen\Documents\FerroSystem\Base de Datos\LaObra.mdf; Integrated Security = True"; DIRECCION A DOCUMENTOS

            //return conexion;

            return Settings.Default.LaObraConnectionString;
        }
    }
}
