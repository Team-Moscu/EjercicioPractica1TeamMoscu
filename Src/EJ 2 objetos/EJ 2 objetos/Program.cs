using System;

namespace Ej2Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            alumno alumno1 = new alumno();
            int respuesta;
            string continuar = "s";
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1 Para ver el nombre del alumno");
                    Console.WriteLine("2 Para ver el nombre y edad del alumno ");
                    Console.WriteLine("3 Para cambiar nombre del alumno y mostrar en pantalla");
                    Console.WriteLine("4 Para cambiar nombre y edad del alumno y mostrar en pantalla ");

                    respuesta = Int32.Parse(Console.ReadLine());

                } while (respuesta != 1 && respuesta != 2 && respuesta != 3 && respuesta != 4);

                if (respuesta == 1)
                {
                    Console.WriteLine(alumno1.getImprimirNombre());

                    do
                    {
                        Console.WriteLine("Desea continuar? S/N");
                        continuar = Console.ReadLine();
                    } while (continuar != "s" && continuar != "S" && continuar != "N" && continuar != "n");
                }
                else if (respuesta == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese  nuevo nombre del alumno:");
                    string x = Console.ReadLine();
                    alumno1.setCambirObj(x);
                    Console.WriteLine(alumno1.getImprimirNombre());
                    do
                    {
                        Console.WriteLine("Desea continuar? S/N");
                        continuar = Console.ReadLine();
                    } while (continuar != "s" && continuar != "S" && continuar != "N" && continuar != "n");
                }
                else if (respuesta == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese nuevo nombre del alumno:");
                    string x = Console.ReadLine();
                    Console.WriteLine("Ingrese edad del alumno:");
                    int y = Int32.Parse(Console.ReadLine());
                    alumno1.setCambirObj(x, y);
                    Console.WriteLine(alumno1.getImprimirNombreEdad());
                    do
                    {
                        Console.WriteLine("Desea continuar? S/N");
                        continuar = Console.ReadLine();
                    } while (continuar != "s" && continuar != "S" && continuar != "N" && continuar != "n");
                }
                else
                {
                    Console.WriteLine(alumno1.getImprimirNombreEdad());
                    do
                    {
                        Console.WriteLine("Desea continuar? S/N");
                        continuar = Console.ReadLine();
                    } while (continuar != "s" && continuar != "S" && continuar != "N" && continuar != "n");
                }
            }
            while (continuar == "s" || continuar == "S");
        }
    }
}

class alumno
{
    public string nombreAlumno;
    public int edadAlumno;

    public alumno()
    {
        nombreAlumno = "Pepe";
        edadAlumno = 18;
    }
    public alumno(string alumnoNombre, int alumnoEdad)
    {
        nombreAlumno = alumnoNombre;
        edadAlumno = alumnoEdad;

    }
    public string getImprimirNombreEdad()
    {
        Console.Clear();
        return "El nombre del alumno es " + nombreAlumno + " y tiene " + edadAlumno + " años." + "\n";
    }
    public string getImprimirNombre()
    {
        Console.Clear();
        return "El nombre del alumno es " + nombreAlumno + "\n";
    }
    public void setCambirObj(string nombreN)
    {
        nombreAlumno = nombreN;
    }
    public void setCambirObj(string nombreNue, int edadN)
    {
        nombreAlumno = nombreNue;
        edadAlumno = edadN;
    }
}
