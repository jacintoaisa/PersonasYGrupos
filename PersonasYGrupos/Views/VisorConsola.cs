using PersonasYGrupos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasYGrupos.Views
{
    internal class VisorConsola : IVisorEmpleados
    {
        public void muestraEmpleadosAgrupados(List<Employee> lista)
        {
            throw new NotImplementedException();
        }

        public void muestraEmpleadosPlano(List<Employee> lista)
        {
            foreach (var item01 in lista)
            {
                Console.WriteLine(item01);
            }
        }
    }
}
