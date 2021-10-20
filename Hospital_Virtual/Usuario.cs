using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Virtual
{
    public class Usuario
    {
        public Usuario(string nombre, string apellido, TipoDocumento tipoDocumento, int dni, DateTime fechaDeNacimiento, EstadoCivil estadoCivil, int telefono, int edad, string email, string direccion, string ciudad, int codPostal)
        {
            Nombre = nombre;
            Apellido = apellido;
            TipoDocumento = tipoDocumento;
            Dni = dni;
            FechaDeNacimiento = fechaDeNacimiento;
            EstadoCivil = estadoCivil;
            Telefono = telefono;
            Edad = edad;
            Email = email;
            Direccion = direccion;
            Ciudad = ciudad;
            CodPostal = codPostal;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDocumento tipoDocumento { get; }
        public int Dni { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public enum EstadoCivil { get };
        public int Telefono { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public int CodPostal { get; set; }

    }
}
