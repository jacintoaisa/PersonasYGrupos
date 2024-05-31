// See https://aka.ms/new-console-template for more information

using PersonasYGrupos;
using PersonasYGrupos.Models;
using PersonasYGrupos.Services;
using PersonasYGrupos.Services.Filtros;
using PersonasYGrupos.Views;
using System.Linq.Dynamic;

IVisorEmpleados MiVisor = new VisorConsola();
GeneradorDeEjemplos Pruebas = new GeneradorDeEjemplos(new InicialBuilder(null), MiVisor);

//Mostrar todos los empleados que son chicos.
IValidadorEmp Validador = new SexoValidator('M');
Pruebas = new GeneradorDeEjemplos(new InicialBuilder(Validador), MiVisor);

//Mostrar todos los empleados que tienen más de 16 años.
Validador = new EdadValidator(Comparadores.mayor, 16);
Pruebas = new GeneradorDeEjemplos(new InicialBuilder(Validador), MiVisor);

//Mostrar todos los empleados que son chicas, ordenado por FName.
Validador = new SexoValidator('F');
var coleccion = new InicialBuilder(Validador).dameEmpleados();
string tipoOrdenacion = "Asc";
string campoOrdenacion = "FName";
var coleccionOrdenado = coleccion.OrderBy($"{campoOrdenacion} {tipoOrdenacion}");
MiVisor.muestraEmpleadosPlano(coleccionOrdenado.ToList());
//Mostrar los empleados cuyo nombre comience por j y sea chico, ordenar por edad
//Aqui falta el AndValidator para unir las dos la j y que sea chico. Este hacerlo vosotros.
Validador = new PrimeraLetraValidador('j');



//Sacar los empleados agrupados por Sex.
var coleccion2 = new InicialBuilder(null).dameEmpleados().ToList();
var coleccion3 = from p in coleccion2
            group p by p.Sex into g
            select g;
foreach (var item in coleccion3)
{
    Console.WriteLine(item.Key);
    foreach (var emp in item)
    {
        Console.WriteLine(emp);
    }
}
