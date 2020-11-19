using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using SistemaLaObra.Properties;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace SistemaLaObra
{
    public class AccesoDatos
    {
        //string conexion; 

        public string CadenaConexion()
        {
            //conexion = @"Data Source=PC-EZEQUIEL\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True"; EZEQUIEL            

            //conexion = @"Data Source=DESKTOP-928I2N6\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True"; //NOTEBOOK EZE

            //conexion = @"Data Source=FRONTERA\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True"; //MARTIN

            //conexion = @Data Source=DESKTOP-HSJCUE2\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True // PC FERRETERIA ARGUELLO

            //conexion = @"Data Source=DESKTOP-GJK2S05\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //GERARDO

            //connectionString="Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\eemen\Documents\FerroSystem\Base de Datos\LaObra.mdf; Integrated Security = True"; DIRECCION A DOCUMENTOS

            //Data Source=DESKTOP-HSJCUE2\SQLEXPRESS;Initial Catalog=LaObra;Integrated Security=True

            //return conexion;

            return SistemaLaObra.Properties.Settings.Default.nuevaCadena;
        }

        public string generarScript()
        {
            var server = new Server(new ServerConnection { ConnectionString = this.CadenaConexion() });
            server.ConnectionContext.Connect();
            var database = server.Databases["LaObra"];
            var sb = new StringBuilder();
            foreach (Table table in database.Tables)
            {
                var scripter = new Scripter(server) { Options = { ScriptData = true } };
                var script = scripter.EnumScript(new SqlSmoObject[] { table });
                foreach (var line in script)
                    sb.AppendLine(line);
            }
            return sb.ToString();
        }
    }
}
