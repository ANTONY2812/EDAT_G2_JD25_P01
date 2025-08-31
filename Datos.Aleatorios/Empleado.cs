using System;

namespace NumerosAleatorios
{
    public class Empleado
    {

        private string nombre;
        private int numeroEmpleado;
        private DateTime fechaNacimiento;
        private string genero;
        private string grupo;
        private decimal sueldo;
        private bool tieneSeguro;


        public string Nombre { get => nombre; set => nombre = value; }
        public int NumeroEmpleado { get => numeroEmpleado; set => numeroEmpleado = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public decimal Sueldo { get => sueldo; set => sueldo = value; }
        public bool TieneSeguro { get => tieneSeguro; set => tieneSeguro = value; }
    }
}
