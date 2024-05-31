using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonasYGrupos.Models;

namespace PersonasYGrupos.Views
{
    public interface IVisorEmpleados
    {
        void muestraEmpleadosPlano(List<Employee> lista);
        void muestraEmpleadosAgrupados(List<Employee> lista);


    }
}
