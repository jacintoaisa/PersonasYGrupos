using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonasYGrupos.Models;

namespace PersonasYGrupos.Services.Filtros
{
    internal interface IValidadorEmp
    {
        bool isValid(Employee empleado);
    }
}
