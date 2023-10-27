using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IP_ILEANAROMERO
{
    internal class Menu
    {
        // Atributo para almacenar una lista de empleados
        private static List<Empleado> empleados; 

        // Constructor para inicializar la lista de empleados
        static Menu()
        {
            empleados = new List<Empleado>();
        }

        // Método para mostrar el menú principal y ejecutar las opciones
        public static void MostrarMenu()
        {
            Console.Clear();
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Menú de Empleados");
                Console.WriteLine("1. Agregar empleado");
                Console.WriteLine("2. Consultar empleado");
                Console.WriteLine("3. Borrar empleado");
                Console.WriteLine("4. Modificar empleado");
                Console.WriteLine("5. Generar reportes");
                Console.WriteLine("6. Salir");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        AgregarEmpleado();
                        break;
                    case 2:
                        ConsultarEmpleado();
                        break;
                    case 3:
                        BorrarEmpleado();
                        break;
                    case 4:
                        ModificarEmpleado();
                        break;
                    case 5:
                        GenerarReportes();
                        break;
                    case 6:
                        Console.WriteLine("Gracias por usar el programa.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 6);
        }

        // Método para agregar un empleado a la lista
        public  static void AgregarEmpleado()
        {
            Console.WriteLine("Agregar Empleado");
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Console.Write("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la dirección: ");
            string direccion = Console.ReadLine();
            Console.Write("Ingrese el teléfono: ");
            string telefono = Console.ReadLine();
            Console.Write("Ingrese el salario: ");
            decimal salario = decimal.Parse(Console.ReadLine());
            Empleado nuevo = new Empleado(cedula, nombre, direccion, telefono, salario);
            empleados.Add(nuevo);
            Console.WriteLine("Empleado agregado con éxito.");
            Console.ReadLine(); 
            
        }

        // Método para consultar un empleado por su número de cédula
        public static void ConsultarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Consultar Empleado");
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Empleado encontrado = empleados.Find(e => e.Cedula == cedula);
            if (encontrado != null)
            {
                encontrado.Mostrar();
            }
            else
            {
                Console.WriteLine("No se encontró ningún empleado con esa cédula.");
            }
            Console.ReadLine();
        }

        // Método para borrar un empleado por su número de cédula
        public static void BorrarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Borrar Empleado");
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Empleado encontrado = empleados.Find(e => e.Cedula == cedula);
            if (encontrado != null)
            {
                empleados.Remove(encontrado);
                Console.WriteLine("Empleado borrado con éxito.");
                
            }
            else
            {
                Console.WriteLine("No se encontró ningún empleado con esa cédula.");
                
            }
            Console.ReadLine();
        }

        // Método para modificar un empleado por su número de cédula
        public static void ModificarEmpleado()
        {
            Console.Clear();
            Console.WriteLine("Modificar Empleado");
            Console.Write("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Empleado encontrado = empleados.Find(e => e.Cedula == cedula);
            if (encontrado != null)
            {
                Console.Write("Ingrese el nuevo nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la nueva dirección: ");
                string direccion = Console.ReadLine();
                Console.Write("Ingrese el nuevo teléfono: ");
                string telefono = Console.ReadLine();
                Console.Write("Ingrese el nuevo salario: ");
                decimal salario = decimal.Parse(Console.ReadLine());
                encontrado.Nombre = nombre;
                encontrado.Direccion = direccion;
                encontrado.Telefono = telefono;
                encontrado.Salario = salario;
                Console.ReadLine (); 

                Console.WriteLine("Empleado modificado con éxito.  ");
            }
            else
            {
                Console.WriteLine("No se encontró ningún empleado con esa cédula.");
            }

            Console.ReadLine () ;
        }

        // Método para mostrar el menú de reportes y ejecutar las opciones
        public static void GenerarReportes()
        {
            Console.Clear();
            int opcion;
            do
            {
                Console.WriteLine("Menú de Reportes");
                Console.WriteLine("1. Consultar empleados con número de cédula");
                Console.WriteLine("2. Listar todos los empleados ordenados por nombre");
                Console.WriteLine("3. Calcular y mostrar el promedio de los salarios");
                Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo");
                Console.WriteLine("5. Volver al menú principal");
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        ConsultarEmpleadosCedula();
                        break;
                    case 2:
                        ListarEmpleadosNombre();
                        break;
                    case 3:
                        CalcularPromedioSalarios();
                        break;
                    case 4:
                        CalcularSalariosExtremos();
                        break;
                    case 5:
                        Console.WriteLine("Volviendo al menú principal.");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            } while (opcion != 5);
            Console.Clear();
        }

        // Método para consultar los empleados que tienen un número de cédula dado
        public  static void ConsultarEmpleadosCedula()
        {
    
            Console.WriteLine("Consultar Empleados con Número de Cédula");
            Console.Write("Ingrese el número de cédula: ");
            string cedula = Console.ReadLine();
            List<Empleado> encontrados = empleados.FindAll(e => e.Cedula == cedula);
            if (encontrados.Count > 0)
            {
                foreach (Empleado e in encontrados)
                {
                    e.Mostrar();
                }
            }
            else
            {
                Console.WriteLine("No se encontraron empleados con ese número de cédula.");
            }
            Console.ReadLine();
        }

        // Método para listar todos los empleados ordenados por nombre
        public static void ListarEmpleadosNombre()
        {
            Console.WriteLine("Listar Todos los Empleados Ordenados por Nombre");
            List<Empleado> ordenados = empleados.OrderBy(e => e.Nombre).ToList();
            if (ordenados.Count > 0)
            {
                foreach (Empleado e in ordenados)
                {
                    e.Mostrar();
                }
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
            Console.ReadLine();
        }

        // Método para calcular y mostrar el promedio de los salarios
        public static void CalcularPromedioSalarios()
        {
            Console.WriteLine("Calcular y Mostrar el Promedio de los Salarios");
            if (empleados.Count > 0)
            {
                decimal suma = 0;
                foreach (Empleado e in empleados)
                {
                    suma += e.Salario;
                }
                decimal promedio = suma / empleados.Count;
                Console.WriteLine($"El promedio de los salarios es {promedio:C}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
        }

        // Método para calcular y mostrar el salario más alto y el más bajo
        public static void CalcularSalariosExtremos()
        {
            Console.Clear();
            Console.WriteLine("Calcular y Mostrar el Salario Más Alto y el Más Bajo");
            if (empleados.Count > 0)
            {
                decimal maximo = empleados.Max(e => e.Salario);
                decimal minimo = empleados.Min(e => e.Salario);
                // Mostrar los salarios extremos
                
                Console.WriteLine($"El salario más alto es  {maximo: C}");
                Console.WriteLine($"El salario más bajo es  {minimo: C}");
            }
            else
            {
                // Mostrar un mensaje de error si la lista está vacía
                Console.Clear();
                Console.WriteLine("No hay empleados registrados.");
            }
        }
    }
}
