using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
namespace CalculoSalarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoOperario = 0, tipoTecnico = 0, tipoProfesional = 0;
            double acumSalarioNetoOperario = 0, acumSalarioNetoTecnico = 0, acumSalarioNetoProfesional = 0;
            int cantidadEmpleados = 0;

            while (true)
            {
                Console.WriteLine("Ingrese el número de cédula del empleado (0 para terminar): ");
                string cedula = Console.ReadLine();

                if (cedula == "0")
                    break;

                Console.WriteLine("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
                int tipoEmpleado = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad de horas laboradas: ");
                int horasLaboradas = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el precio por hora: ");
                double precioHora = Convert.ToDouble(Console.ReadLine());

                double salarioOrdinario = horasLaboradas * precioHora;
                double aumento = 0;

                switch (tipoEmpleado)
                {
                    case 1:
                        aumento = salarioOrdinario * 0.15; // 15% de aumento para Operario
                        tipoOperario++;
                        acumSalarioNetoOperario += (salarioOrdinario + aumento);
                        break;
                    case 2:
                        aumento = salarioOrdinario * 0.10; // 10% de aumento para Técnico
                        tipoTecnico++;
                        acumSalarioNetoTecnico += (salarioOrdinario + aumento);
                        break;
                    case 3:
                        aumento = salarioOrdinario * 0.05; // 5% de aumento para Profesional
                        tipoProfesional++;
                        acumSalarioNetoProfesional += (salarioOrdinario + aumento);
                        break;
                }

                double salarioBruto = salarioOrdinario + aumento;
                double deduccionCCSS = salarioBruto * 0.0917;
                double salarioNeto = salarioBruto - deduccionCCSS;

                Console.WriteLine("\nCédula: " + cedula);
                Console.WriteLine("Nombre Empleado: " + nombre);
                Console.WriteLine("Tipo Empleado: " + tipoEmpleado);
                Console.WriteLine("Salario por Hora: " + precioHora);
                Console.WriteLine("Cantidad de Horas: " + horasLaboradas);
                Console.WriteLine("Salario Ordinario: " + salarioOrdinario);
                Console.WriteLine("Aumento: " + aumento);
                Console.WriteLine("Salario Bruto: " + salarioBruto);
                Console.WriteLine("Deducción CCSS: " + deduccionCCSS);
                Console.WriteLine("Salario Neto: " + salarioNeto);

                cantidadEmpleados++;
            }

            Console.WriteLine("\nEstadísticas:");
            Console.WriteLine("1) Cantidad Empleados Tipo Operarios: " + tipoOperario);
            Console.WriteLine("2) Acumulado Salario Neto para Operarios: " + acumSalarioNetoOperario);
            Console.WriteLine("3) Promedio Salario Neto para Operarios: " + (acumSalarioNetoOperario / tipoOperario));
            Console.WriteLine("4) Cantidad Empleados Tipo Técnico: " + tipoTecnico);
            Console.WriteLine("5) Acumulado Salario Neto para Técnicos: " + acumSalarioNetoTecnico);
            Console.WriteLine("6) Promedio Salario Neto para Técnicos: " + (acumSalarioNetoTecnico / tipoTecnico));
            Console.WriteLine("7) Cantidad Empleados Tipo Profesional: " + tipoProfesional);
            Console.WriteLine("8) Acumulado Salario Neto para Profesionales: " + acumSalarioNetoProfesional);
            Console.WriteLine("9) Promedio Salario Neto para Profesionales: " + (acumSalarioNetoProfesional / tipoProfesional));
        }
    }
}