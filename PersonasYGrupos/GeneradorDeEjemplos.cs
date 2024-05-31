using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonasYGrupos.Models;
using PersonasYGrupos.Views;

namespace PersonasYGrupos
{
    public class GeneradorDeEjemplos
    {
        private IListaBuilder ConstructorLista;
        private IVisorEmpleados Visor;
        private bool EsMulti = false;

        public GeneradorDeEjemplos(IListaBuilder generador, IVisorEmpleados visionado, bool esMulti = false)
        {
            this.ConstructorLista = generador;
            this.Visor = visionado;
            this.EsMulti = esMulti;
            if (!EsMulti)
            {
                Visor.muestraEmpleadosPlano(this.ConstructorLista.dameEmpleados());
            }
            else
            {
                
            }
        }
    }
}
