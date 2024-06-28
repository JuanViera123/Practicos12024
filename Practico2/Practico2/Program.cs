using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1
            //List<Persona> personas = new List<Persona>();
            
            //Persona persona1 = new Persona("Juan", 25, "Lima");
            //Persona persona2 = new Persona("Maria", 30, "Bogota");
            //Persona persona3 = new Persona("Pedro", 35, "Madrid");
            //Persona persona4 = new Persona("Ana", 20, "Lima");
            //Persona persona5 = new Persona("Jose", 40, "Buenos Aires");

            //personas.Add(persona1);
            //personas.Add(persona2);
            //personas.Add(persona3);
            //personas.Add(persona4);
            //personas.Add(persona5);


            //personas.Where(x => x.Edad > 30 && x.Ciudad == "Madrid").ToList().Select(x => x.Nombre).ToList().ForEach(x => Console.WriteLine(x));
            //personas.Where(x => x.Edad >= 25 && x.Edad < 35).ToList().OrderBy(x => x.Edad).ToList().ForEach(x => Console.WriteLine(x.Nombre));


            //Console.ReadLine();

            ControlEmpresasEmpleados ce = new ControlEmpresasEmpleados();

            //ce.GetCeo("CEO");

            //ce.GetEmpleadosOrdenados();

            //ce.GetEmpleadosSegunSalario();

            //ce.GetEmpleadoEmpresa(2);

            //ce.promedioSalarios(3);

            //ce.GetCeoEmpresa1();

            //ce.SalarioMasAlto();

            //ce.SalarioMayor2200();
            //ce.MayorSalarioPorCargo();
            //ce.MayorSalarioPorEmpresa();

            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int i in lista.OrderByDescending(x => x))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(lista.Sum(x => x));

            Console.WriteLine(lista.Where(x => x % 2 == 0).ToList().Sum());

            int SumaMenoresDeOcho = 0;
            int SumaMayoresDeOcho = 0;

            foreach(int i in lista)
            {
                if (i % 2 == 0 && i > 8)
                {
                    SumaMayoresDeOcho = +i;
                }
                else if (i % 2 == 0 && i <= 8) {
                    SumaMenoresDeOcho = SumaMenoresDeOcho + i;
                }
            }

            Console.WriteLine("Suma total numeros menores que 8 = " + SumaMenoresDeOcho);
            Console.WriteLine("Suma total mayores que 8 = " + SumaMayoresDeOcho);

            Console.WriteLine(lista.Where(x => x % 2 == 0 && x <= 8).ToList().Sum(x => x));
            Console.WriteLine(lista.Where(x => x % 2 == 0 && x > 8).ToList().Sum(x => x));

            Console.WriteLine("Escriba una letra minuscula (desde a hasta f) para saber cual es la siguiente letra del abecedario");
            string letra = Console.ReadLine();

          
            switch (letra) 
            {
                case "a":
                    Console.WriteLine("La siguiente letra es b");
                    break;
                case "b":
                    Console.WriteLine("La siguiente letra es c");
                    break;
                case "c":
                    Console.WriteLine("La siguiente letra es c");
                    break;
                case "d":
                    Console.WriteLine("La siguiente letra es e");
                    break;
                case "e":
                    Console.WriteLine("La siguiente letra es f");
                    break;
                case "f":
                    Console.WriteLine("La siguiente letra es g");
                    break;
            }
        }
    }
}

    