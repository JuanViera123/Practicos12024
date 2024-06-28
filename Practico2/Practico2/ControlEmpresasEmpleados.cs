using System; 
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class ControlEmpresasEmpleados
    {
        public List<Empresa> listaEmpresas;
        public List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados ()
        {
            listaEmpresas = new List<Empresa> ();
            listaEmpleados = new List<Empleado> ();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "IAlpha" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "Udelar" });
            listaEmpresas.Add(new Empresa { Id = 3, Nombre = "SpaceZ" });


            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "JuanC", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "JuanR", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Daniel", Cargo = "Desarrollador", EmpresaId = 1, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "GonzaloT", Cargo = "CEO", EmpresaId = 2, Salario = 2000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 1, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 7, Nombre = "Gonzalo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
            listaEmpleados.Add(new Empleado { Id = 8, Nombre = "Leonardo", Cargo = "CEO", EmpresaId = 3, Salario = 3000 });
            

        
        }

        public void GetCeo(string _Cargo)
        {
            listaEmpleados.Where( x => x.Cargo == _Cargo).ToList().ForEach(x => Console.WriteLine(x.Nombre));

        }

        public void GetEmpleadosOrdenados()
        {
            listaEmpleados.OrderBy(x => x.Nombre).ToList().ForEach(x => Console.WriteLine(x.Nombre));
        }

        public void GetEmpleadosSegunSalario()
        {
            listaEmpleados.OrderBy(x => x.Salario).ToList().ForEach(x => Console.WriteLine(x.Nombre + " " + x.Salario));
        }

        public void GetEmpleadoEmpresa (int _Empresa)
        {
            listaEmpleados.Where(x => x.EmpresaId == _Empresa).ToList().ForEach(x => Console.WriteLine(x.Nombre));
        }

        public void promedioSalarios(int _Empresa)
        {
            var salarioPromedio = listaEmpleados.Where(x => x.EmpresaId == _Empresa).ToList().Average(x => x.Salario);
            Console.WriteLine(salarioPromedio.ToString());

        }

        public void GetCeoEmpresa1()
        {
            listaEmpleados.Where(x => x.EmpresaId == 1 && x.Cargo == "CEO").ToList().ForEach(x => Console.WriteLine(x.Nombre));
        }

        public void SalarioMasAlto()
        {
           int SalarioMaximo =  listaEmpleados.Max(x => x.Salario);
           listaEmpleados.Where(x => x.Salario == SalarioMaximo).ToList().ForEach(x => Console.WriteLine(x.Salario + " " + x.Nombre + " " + x.Cargo + " " + x.EmpresaId));
        }

        public void SalarioMayor2200()
        {
            listaEmpleados.Where(x => x.Salario > 2200).ToList().ForEach(x => Console.WriteLine(x.Nombre));
        }

        public void MayorSalarioPorCargo()
        {
        var MaxCEO = listaEmpleados.Where(x => x.Cargo == "CEO").ToList().Max(x => x.Salario);
        var MaxDesarrollador = listaEmpleados.Where(x => x.Cargo == "Desarrollador").ToList().Max(x => x.Salario);
         Console.WriteLine("Sueldo mayor CEO: " +  MaxCEO + " Sueldo mayor desarrollador: " + MaxDesarrollador);

        }

        public void MayorSalarioPorEmpresa()
        {
            var MaxE1 = listaEmpleados.Where(x => x.EmpresaId == 1).ToList().Max(x => x.Salario);
            var MaxE2 = listaEmpleados.Where(x => x.EmpresaId == 2).ToList().Max(x => x.Salario);
            var MaxE3 = listaEmpleados.Where(x => x.EmpresaId == 3).ToList().Max(x => x.Salario);
            Console.WriteLine("Sueldo mas alto empresa 1:" + MaxE1 + " Sueldo mas alto empresa 2:" + MaxE2 + " Sueldo mas alto empresa 3:" + MaxE3);

        }
    }
}
