using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> alumnos;

    public void AgregarAlumno(Alumno alumno)
    {
        alumnos.Add(alumno.Id, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        return alumnos.GetValueOrDefault(legajo);
    }

    public Dictionary<int, Alumno> GetAlumnos()
    {
        return alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        alumnos.Remove(legajo);
    }
}
