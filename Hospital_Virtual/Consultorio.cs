using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Virtual
{
    public class Consultorio
    {
        public Consultorio(string direccion, string nombre, Medico medico)
        {
            Direccion = direccion;
            Nombre = nombre;
            Medico = medico;
        }

        public string Direccion { get; set; }
        public string Nombre { get; set; }
        public Medico Medico { get; set; }
    }
}
