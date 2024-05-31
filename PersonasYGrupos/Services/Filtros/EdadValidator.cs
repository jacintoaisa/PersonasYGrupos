using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonasYGrupos.Models;

namespace PersonasYGrupos.Services.Filtros
{
    public class EdadValidator : IValidadorEmp
    {
        private readonly Comparadores _comp;
        private readonly int _numero;


        public EdadValidator(Comparadores comp, int _numero)
        {
            _comp = comp;
            this._numero = _numero;
        }
        public bool isValid(Employee empleado)
        {
            // Save today's date.
            var today = DateTime.Today;

            // Calculate the age.
            var age = today.Year - empleado.DOB.Year;

            switch (_comp)
            {
                case Comparadores.menor:
                    return age < _numero;
                case Comparadores.menorOIgual:
                    return age <= _numero;
                case Comparadores.igual:
                    return age == _numero;
                case Comparadores.mayorOIgual:
                    return age >= _numero;
                case Comparadores.mayor:
                    return age >= _numero;

            }
        }
    }
}
