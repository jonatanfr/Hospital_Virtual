using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Virtual
{
    
    public class Paciente
    {

        public Paciente(string historialMedico, string medicamentos, string antecedentesMedicos, PlanMedico planMedico)
        {
            HistorialMedico = historialMedico;
            Medicamentos = medicamentos;
            AntecedentesMedicos = antecedentesMedicos;
            PlanMedico = planMedico;
        }


        public string HistorialMedico { get; set; }
        public string Medicamentos { get; set; }
        public  string AntecedentesMedicos { get; set; }
        public PlanMedico planMedico { get; set; }

    }
}
