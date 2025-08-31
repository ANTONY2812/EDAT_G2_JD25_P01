using System;
using NumerosAleatorios;


namespace Datos.Aleatorios
{
    public partial class frmDatosAleatorios : Form
    {
        public frmDatosAleatorios()
        {
            InitializeComponent();
        }

        private void frmDatosAleatorios_Load(object sender, EventArgs e)
        {

            comboBox1.Items.AddRange(new object[] { "A", "B", "C", "D" });
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }


        private void btnGenerar_Click(object sender, EventArgs e)
        {

        }



        private DateTime GenerarFecha()
        {
            DateTime inicio = new DateTime(1960, 1, 1);
            int rango = (DateTime.Today - inicio).Days;
            Random rnd = new Random();  
            return inicio.AddDays(rnd.Next(rango));
        }

        private void Datos_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();


            string[] nombres = { "Carlos Fernando Perez Carranza", "María Luna Perez", "Juan Carlos Sanchez Parra", "Ana Frank", "Pedro Suarez", "Lucía Alba", "Roberto Jimenez", "Elena Robles Lopez" };
            string[] grupos = { "A", "B", "C", "D" };


            Empleado emp = new Empleado
            {
                Nombre = nombres[rnd.Next(nombres.Length)],
                NumeroEmpleado = rnd.Next(1000, 9999),
                FechaNacimiento = DateTime.Now.AddYears(-rnd.Next(18, 60)).AddDays(rnd.Next(0, 365)),
                Genero = rnd.Next(2) == 0 ? "Masculino" : "Femenino",
                Grupo = grupos[rnd.Next(grupos.Length)],
                Sueldo = rnd.Next(6000, 25000),
                TieneSeguro = rnd.Next(2) == 0
            };


            Nom1.Text = emp.Nombre;
            Num1.Text = emp.NumeroEmpleado.ToString();
            dateTimePicker1.Value = emp.FechaNacimiento;

            if (emp.Genero == "Masculino")
                Masculino.Checked = true;
            else
                Femenino.Checked = true;

            comboBox1.Text = emp.Grupo;
            sueldo1.Text = emp.Sueldo.ToString("C");
            Seguro.Checked = emp.TieneSeguro;
        }

        private void sueldo11_Click(object sender, EventArgs e)
        {

        }
    }
}
