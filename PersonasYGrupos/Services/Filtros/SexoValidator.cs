using PersonasYGrupos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasYGrupos.Services.Filtros
{
    public class SexoValidator : IValidadorEmp
    {
        private char _sexo;

        public SexoValidator(char sexo)
        {
            _sexo = sexo;
        }
        public bool isValid(Employee empleado)
        {
            return empleado.Sex == _sexo;
        }
    }
}
