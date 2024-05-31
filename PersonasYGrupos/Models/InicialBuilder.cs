using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PersonasYGrupos.Services;
using PersonasYGrupos.Services.Filtros;

namespace PersonasYGrupos.Models
{
    internal class InicialBuilder : IListaBuilder
    {
        private readonly IValidadorEmp Validador;
        public InicialBuilder(IValidadorEmp validador)
        {
            if (validador != null)
            {
                Validador = validador;
            }
            else
            {
                Validador = new TodosValidador();
            }
        }
        public List<Employee> dameEmpleados()
        {
            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee()
            {
                ID = 1,
                FName = "John",
                MName = "",
                LName = "Shields",
                DOB = DateTime.Parse("12/11/1971"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 2,
                FName = "Mary",
                MName = "Matthew",
                LName = "Jacobs",
                DOB = DateTime.Parse("01/17/1961"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 3,
                FName = "Amber",
                MName = "Carl",
                LName = "Agar",
                DOB = DateTime.Parse("12/23/1971"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 4,
                FName = "Kathy",
                MName = "",
                LName = "Berry",
                DOB = DateTime.Parse("11/15/1976"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 5,
                FName = "Lena",
                MName = "Ashco",
                LName = "Bilton",
                DOB = DateTime.Parse("05/11/1978"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 6,
                FName = "Susanne",
                MName = "",
                LName = "Buck",
                DOB = DateTime.Parse("03/7/1965"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 7,
                FName = "Jim",
                MName = "",
                LName = "Brown",
                DOB = DateTime.Parse("09/11/1972"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 8,
                FName = "Jane",
                MName = "G",
                LName = "Hooks",
                DOB = DateTime.Parse("12/11/1972"),
                Sex = 'F'
            });
            empList.Add(new Employee()
            {
                ID = 9,
                FName = "Robert",
                MName = "",
                LName = "",
                DOB = DateTime.Parse("06/28/1964"),
                Sex = 'M'
            });
            empList.Add(new Employee()
            {
                ID = 10,
                FName = "Cindy",
                MName = "Preston",
                LName = "Fox",
                DOB = DateTime.Parse("01/11/1978"),
                Sex = 'M'
            });
            return empList.Where(x=>Validador.isValid(x)).ToList();

        }
    }
}
