// See https://aka.ms/new-console-template for more information

using PersonasYGrupos.Models;

Console.WriteLine("Hello, World!");
IListaBuilder MiGenerador = new InicialBuilder();
var elementos = MiGenerador.dameEmpleados();


//Mostrar todos los empleados que son chicos.
//Mostrar todos los empleados que tienen más de 16 años.
//Mostrar todos los empleados que son chicas, ordenado por FName.
//Mostrar los empleados cuyo nombre comience por j y sea chico, ordenar por edad
//Sacar los empleados agrupados por Sex.
//Sacar los empleados ordenados por FName y Agrupados por Sex.
