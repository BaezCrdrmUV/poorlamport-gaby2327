using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamport
{
    public class Proceso
    {
        int IdProceso { get; set; }
        int TiempoProceso { get; set; }

        public Proceso(int idProceso, int tiempoProceso)
        {
            this.IdProceso = idProceso;
            this.TiempoProceso = tiempoProceso;
        }

        public string EnviarMensaje(Proceso proceso, Mensaje mensaje)
        {
            TiempoProceso += 1;
            mensaje.Reloj = TiempoProceso;
            string historialEnviar = "Proceso " + this.IdProceso + " envió mensaje y su reloj es: " + TiempoProceso + "\n";
            string historialRecibir = proceso.RecibirMensaje(mensaje);
            return historialEnviar + historialRecibir;
        }

        public string RecibirMensaje(Mensaje mensaje)
        {
            int[] relojes = { TiempoProceso, mensaje.Reloj };
            TiempoProceso = relojes.Max() + 1;
            return "Proceso " + this.IdProceso + " recibió mensaje y su reloj es: " + TiempoProceso + "\n";
        }
    }
}
