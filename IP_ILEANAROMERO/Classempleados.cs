using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IP_ILEANAROMERO
{
    public class Empleado
    {
        // Atributos del empleado
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal Salario { get; set; }

        // Constructor para inicializar los atributos del empleado
        public Empleado(string cedula, string nombre, string direccion, string telefono, decimal salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Salario = salario;
        }

        // Método para mostrar los datos del empleado
        public void Mostrar()
        {
            Console.WriteLine("Cédula: " + Cedula);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Dirección: " + Direccion);
            Console.WriteLine("Teléfono: " + Telefono);
            Console.WriteLine("Salario: " + Salario);
            Console.WriteLine();
        }

    }

    


}
