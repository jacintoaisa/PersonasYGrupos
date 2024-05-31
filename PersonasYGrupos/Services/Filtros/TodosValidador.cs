using PersonasYGrupos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasYGrupos.Services.Filtros
{
    public class TodosValidador : IValidadorEmp
    {
        public bool isValid(Employee empleado)
        {
            return true;
        }
    }
}
