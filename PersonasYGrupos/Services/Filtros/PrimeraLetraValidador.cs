using PersonasYGrupos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasYGrupos.Services.Filtros
{
    public class PrimeraLetraValidador : IValidadorEmp
    {
        private readonly char primeraLetra;

        public PrimeraLetraValidador(char primeraLetra)
        {
            this.primeraLetra = primeraLetra;
        }

        public bool isValid(Employee empleado)
        {
            return (empleado.FName[0] == primeraLetra);
        }
    }
}
