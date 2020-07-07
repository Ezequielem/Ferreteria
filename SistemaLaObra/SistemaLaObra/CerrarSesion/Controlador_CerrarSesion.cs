using SistemaLaObra.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLaObra.CerrarSesion
{
    class Controlador_CerrarSesion
    {
        public IU_CerrarSesion interfazCerrarSesion { get; set; }
        Usuario usuario;
        HistorialSesion historialSesion;

        public Controlador_CerrarSesion()
        {
            usuario = new Usuario();
            historialSesion = new HistorialSesion();
        }

        public void cerrarSesionUsuario(int codigoHistorial)
        {
            historialSesion.actualizarHistorial(codigoHistorial, DateTime.Now);
        }
    }
}
