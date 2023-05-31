using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Recuperacio_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor vacio
            Persona per1 = new Persona();

            //constructor servicios
            Servicio servicio = new Servicio();

            //variables
            string nombre;
            string apellidos;
            int anio, mes, dia;
            
            nombre = servicio.Pedir("dime el nombre");
            apellidos = servicio.Pedir("dime el apellido");
            dia = Convert.ToInt32(servicio.Pedir("dime la fecha de nacimiento (dia)"));
            mes = Convert.ToInt32(servicio.Pedir("dime la fecha de nacimiento (mes)"));
            anio = Convert.ToInt32(servicio.Pedir("dime la fecha de nacimiento (año)"));

            //con objetos
            //per1 = new Persona(nombre, apellidos, dia, mes, anio);            

            //con getters y setters
            per1.Nombre=nombre;
            per1.Apellidos = apellidos;
            per1.Dia = dia;
            per1.Mes = mes;
            per1.Anio = anio;

            Console.WriteLine(per1.ToString());

            /*
            per1.Nombre = "diego";
            per1.Apellidos = "de la prada";

            Console.WriteLine("vacio");
            Console.WriteLine("{0} {1}",per1.Nombre,per1.Apellidos);
            Console.WriteLine("\ntodos campos");            
            Console.WriteLine("{0} {1} {2}-{3}-{4}", per2.Nombre,per2.Apellidos,per2.Dia,per2.Mes,per2.Anio);
            Console.WriteLine(per2.ToString());
            */

            Console.ReadKey();
        }
    }
}