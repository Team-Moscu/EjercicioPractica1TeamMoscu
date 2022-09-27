using System;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace primerejercicioObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto1 = new Auto();
            Auto auto2 = new Auto(4, 6);
            int opc = 0;
            int elegirAu = 0;

            do
            {
                Console.WriteLine("Que auto desea elegir:");
                Console.WriteLine("1- Auto de fabrica");
                Console.WriteLine("2- Diseñar mi propio auto");
                Console.WriteLine("3- Cerrar el prorgama");
                elegirAu = int.Parse(Console.ReadLine());

            } while (elegirAu != 1 && elegirAu != 2 && elegirAu != 3);

            if (elegirAu == 1)
            {
                do
                {

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1- Mostrar medidas y color");
                        Console.WriteLine("2- Mostar los extras");
                        Console.WriteLine("3- Cerrar el programa");
                        opc = int.Parse(Console.ReadLine());
                    } while (opc != 1 && opc != 2 && opc != 3);



                    if (opc == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(auto1.getinfoauto());
                        Thread.Sleep(5000);
                    }
                    else if (opc == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(auto1.getextra());
                        Thread.Sleep(5000);
                    }


                } while (opc != 3);





            }

            if (elegirAu == 2)
            {

                do
                {

                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Opciones:");
                        Console.WriteLine("1- Cambiar las dimensiones del auto y color");
                        Console.WriteLine("2- Cambiar  los extras del auto");
                        Console.WriteLine("3- Mostar caracteristicas del Carro y sus extras");
                        Console.WriteLine("4- Cerrar programa");
                        opc = int.Parse(Console.ReadLine());
                    } while (opc != 1 && opc != 2 && opc != 3 && opc != 4);

                    if (opc == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("ingrese el largo del auto deseado:");
                        int largo = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el ancho del auto deseado:");
                        int ancho = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingrese el color del auto deseado:");
                        string color = Console.ReadLine();

                        auto2.setcaracteristicas(largo, ancho, color);

                        Console.Clear() ;
                        Console.WriteLine("Se han modificado correctamente las Caracteristicas del carro, volveras al Menu automaticamente");
                        Thread.Sleep(4000);
                    }
                    else if (opc == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Quiere que el vehiculo tenga climatizador? Ingrese S o N");
                        bool climatizadorC;
                        string climat = Console.ReadLine();
                        if (climat == "S")
                        {
                            climatizadorC = true;
                        }
                        else
                        {
                            climatizadorC = false;
                        }

                        Console.WriteLine("Ingrese el tipo de tapizeria que quiere equiparle: ");
                        Console.WriteLine("_cuero");
                        Console.WriteLine("_foamizada");
                        Console.WriteLine("_Alcántara");
                        Console.WriteLine("_vinilo");
                        Console.WriteLine("_tela");
                        Console.WriteLine("_microfibra");

                        string tapizeriaA = Console.ReadLine();

                        auto2.setthisextras(climatizadorC, tapizeriaA);
                        Console.Clear();
                        Console.WriteLine("Se han modificado correctamente los extras del carro, volveras al Menu automaticamente");
                        Thread.Sleep(4000);

                    }
                    else if (opc == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(auto2.getinfoauto());
                        Console.WriteLine(auto2.getextra());
                        Thread.Sleep(4000);
                    }

                } while (opc != 4);
            }

        }
    }
}


class Auto
{
    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private string tapizeria;
    private string color;

    public Auto()
    {
        ruedas = 4;
        largo = 3;
        ancho = 2;
        climatizador = false;
        tapizeria = "tela";
        color = "blanco";

    }
    public Auto(int a, int b)
    {
        ruedas = 4;
        largo = a;
        ancho = b;
        climatizador = false;
        tapizeria = "tela";
        color = "blanco";

    }

    //gatters y setters 

    public void setthisextras(bool climatizador, string tapizeria)
    {
        this.climatizador = climatizador;
        this.tapizeria = tapizeria;

    }


    public void setcaracteristicas(int largo, int ancho, string color)
    {
        this.largo = largo;
        this.ancho = ancho;
        this.color = color;

    }

    public string getinfoauto()
    {
        return "El auto tiene: \nRuedas: " + ruedas + "\nLargo:  " + largo + "\nAncho: " + ancho + "\nColor: " + color + "\n";

    }

    public string getextra()
    {
        return "Extras: \nClimatizador: " + climatizador + "\nTapizeria:  " + tapizeria;
    }
}


