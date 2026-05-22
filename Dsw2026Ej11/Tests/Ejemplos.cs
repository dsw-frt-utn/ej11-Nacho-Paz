using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList caso = new CasoList();
        caso.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        caso.AgregarAlumno(new Alumno(2, "Maria", 9.0));
        caso.AgregarAlumno(new Alumno(3, "Pedro", 7.5));
        Console.WriteLine("Alumnos:");
        foreach (Alumno alumno in caso.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("\nBuscar alumno por nombre:");
        Alumno? alumnoEncontrado = caso.BuscarAlumno("Maria");
        Console.WriteLine(alumnoEncontrado != null ? alumnoEncontrado.ToString() : "No existe");
        alumnoEncontrado = caso.BuscarAlumno("Ana");
        Console.WriteLine(alumnoEncontrado != null ? alumnoEncontrado.ToString() : "No existe");
        Console.WriteLine("\nAlumnos después de eliminar uno:");
        caso.EliminarAlumno(caso.GetAlumnos()[0]);
        foreach (Alumno alumno in caso.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
        Console.WriteLine("\nAlumnos después de eliminar el primer elemento:");
        caso.EliminarAlumnoEnPosicion(0);
        foreach (Alumno alumno in caso.GetAlumnos())
        {
            Console.WriteLine(alumno);
        }
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary caso = new CasoDictionary();
        caso.AgregarAlumno(new Alumno(1, "Juan", 8.5));
        caso.AgregarAlumno(new Alumno(2, "Maria", 9.0));
        caso.AgregarAlumno(new Alumno(3, "Pedro", 7.5));
        Console.WriteLine("\nMostrar un alumno:");
        Alumno? alumno = caso.BuscarAlumno(2);
        Console.WriteLine(alumno != null ? alumno.ToString() : "No existe");
        alumno = caso.BuscarAlumno(4);
        Console.WriteLine(alumno != null ? alumno.ToString() : "No existe");
        Console.WriteLine("\nEliminar un alumno y mostrar los alumnos:");
        caso.EliminarAlumno(2);
        foreach (Alumno a in caso.GetAlumnos().Values)
        {
            Console.WriteLine(a);
        }
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        
    }
}
