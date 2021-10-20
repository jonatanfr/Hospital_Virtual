using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Virtual
{

    public class Medico
    {
        public Medico(int numeroMatricula, Especialidad especialidad)
        {
            NumeroMatricula = numeroMatricula;
            Especialidad = especialidad;
        }

        public int NumeroMatricula { get; set; }
        public enum Especialidad { get }
    }
}
