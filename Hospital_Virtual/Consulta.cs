using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Virtual
{
     public class Consulta
    {

        public Consulta(DateTime fecha, int horaInicio, Estado estado)
        {
            Fecha = fecha;
            HoraInicio = horaInicio;
            Estado = estado;
        }

        public DateTime Fecha { get; set; }
        public int HoraInicio { get; set; }
        public enum Estado { get};
    }
}
