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

            per1 = new Persona(nombre, apellidos, dia, mes, anio);

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

            //Pilares programacion orientada a objetos

            //Polimorfismo -->

            //Herencia -->

            //Encapsulamiento --> dar privacidad a una clase,metodo,variable... (private)
            //controlar desde donde se puede acceder a nuestro codigo
            //se utiliza para no tener una ....API (interfaz de programación de aplicaciones) pantalla inermedia, ofrece informacion

            //Abstraccion(trabajo) --> ir paso por paso;
            //sacar idea principal de cada parrafo;
            //solo pensar en lo fundamental
            //no definir nada hasta el momento de su uso (metodos)
            //es como hacer un esquema de todo con las declaraciones de los metodos

            //crear todos metodos en interfaces,impl...  y que el codigo compile aunque no haga nada
            //es como tener un esquema de todo el proyecto y luego definir los metodos

            //Abstraccion(codigo) --> nombreInterfaz in = new nombreImpl();  esto es abstraccion


            //sobrecarga

        }
    }
}