using System;

namespace Ej5Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de columnas que desee para las matrices: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de filas que desee para las matrices: ");
            int m = int.Parse(Console.ReadLine());

            int[,] primeraMatriz = new int[n, m];
            int[,] segundaMatriz = new int[n, m];

            Matriz2[,] miMatriz2 = new Matriz2[n, m];
            Matriz2[,] miMatriz1 = new Matriz2[n, m];
            Random numRandom = new Random();

            int respuesta;
            do
            {
                Console.WriteLine("Opciones");
                Console.WriteLine("1 - Utilizar números aleatorios");
                Console.WriteLine("2 - Ingresar valores manualmente");
                respuesta = int.Parse(Console.ReadLine());
            } while (respuesta != 1 && respuesta != 2);

            //Añade los numeros a la primera matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (respuesta == 1)
                    {
                        int numero1 = numRandom.Next(10);
                        miMatriz1[i, j] = new Matriz2(numero1);
                        primeraMatriz[i, j] = miMatriz1[i, j].getInfo();
                    }
                    else
                    {
                        Console.WriteLine($"Ingrese un elemento {i + 1}{j + 1} de la primera matriz");
                        int numero1 = int.Parse(Console.ReadLine());
                        miMatriz1[i, j] = new Matriz2(numero1);
                        primeraMatriz[i, j] = miMatriz1[i, j].getInfo();
                    }
                }
            }
            Console.Clear();
            //Añade los numeros a la segunda matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (respuesta == 1)
                    {
                        int numero2 = numRandom.Next(10);
                        miMatriz2[i, j] = new Matriz2(numero2);
                        segundaMatriz[i, j] = miMatriz2[i, j].getInfo();
                    }
                    else
                    {
                        Console.WriteLine($"Ingrese un elemento {i + 1}{j + 1} de la segunda matriz");
                        int numero2 = int.Parse(Console.ReadLine());
                        miMatriz2[i, j] = new Matriz2(numero2);
                        segundaMatriz[i, j] = miMatriz2[i, j].getInfo();
                    }
                }
            }

            //Muestra las Matrices
            Matrices mostrar = new Matrices();
            mostrar.mostrarMatriz(1, n, m, primeraMatriz);

            mostrar.mostrarMatriz(2, n, m, segundaMatriz);

            int respuestaDos;
            do
            {
                Console.WriteLine("Seleccione la operación a realizar");
                Console.WriteLine("1 - Sumar las matrices");
                Console.WriteLine("2 - Restar las matrices");
                if (n == 2 && m == 2)
                {
                    Console.WriteLine("3 - Multiplicar las matrices");
                }
                respuestaDos = int.Parse(Console.ReadLine());
            } while (respuestaDos != 1 && respuestaDos != 2 && respuestaDos != 3);

            if(respuestaDos == 1)
            {
                OperacionSumar sumarMatrices = new OperacionSumar();
                sumarMatrices.SumarMatrizes(n, m, ref primeraMatriz, segundaMatriz);
            }
            else if (respuestaDos == 2)
            {
                OperacionRestar restarMatrices = new OperacionRestar();
                restarMatrices.RestarMatrizes(n, m, ref primeraMatriz, segundaMatriz);
            }
            else
            {
                OperacionMultiplicar multiplicarMatrices = new OperacionMultiplicar();
                multiplicarMatrices.MultiplicarMatrices(n, m, primeraMatriz, segundaMatriz);
            }
        }
    }
}

class Matriz2
{
    private int d;
    public Matriz2(int d)
    {
        this.d = d;
    }
    public int getInfo()
    {
        return d;
    }

    public void setInfo(int nuevoValor)
    {
        d = nuevoValor;
    }
}

class Matrices
{
    public Matrices()
    {

    }
    public void mostrarMatriz(int a, int n, int m, int[,] matriz)
    {
        Console.WriteLine("Matriz " + a);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(" " + matriz[i, j]);
            }
            Console.WriteLine("");
        }
        Console.WriteLine("");
    }
}

class OperacionSumar
{
    public OperacionSumar()
    {

    }
    public void SumarMatrizes(int n, int m, ref int[,] matrizPrimera, int[,] matrizSegunda)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrizPrimera[i, j] = matrizPrimera[i, j] + matrizSegunda[i, j];
            }
        }

        Console.WriteLine("La suma de las dos matrices es:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(" " + matrizPrimera[i,j]);
            }
            Console.WriteLine("");
        }
    }
}

class OperacionRestar
{
    public OperacionRestar()
    {

    }
    public void RestarMatrizes(int n, int m, ref int[,] matrizPrimera, int[,] matrizSegunda)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrizPrimera[i, j] = matrizPrimera[i, j] - matrizSegunda[i, j];
            }
        }

        Console.WriteLine("La resta de las dos matrices es:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(" " + matrizPrimera[i, j]);
            }
            Console.WriteLine("");
        }
    }
}

class OperacionMultiplicar
{
    public OperacionMultiplicar()
    {

    }

    public void MultiplicarMatrices (int n, int m, int[,] matrizPrimera, int[,] matrizSegunda)
    {
        int[,] terceraMatriz = new int[n, m];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                terceraMatriz[0, 0] = (matrizPrimera[0, 0] * matrizSegunda[0, 0]) + (matrizPrimera[0, 1] * matrizSegunda[1, 0]);
                terceraMatriz[0, 1] = (matrizPrimera[0, 0] * matrizSegunda[0, 1]) + (matrizPrimera[0, 1] * matrizSegunda[1, 1]);
                terceraMatriz[1, 0] = (matrizPrimera[1, 0] * matrizSegunda[0, 0]) + (matrizPrimera[1, 1] * matrizSegunda[1, 0]);
                terceraMatriz[1, 1] = (matrizPrimera[1, 0] * matrizSegunda[0, 1]) + (matrizPrimera[1, 1] * matrizSegunda[1, 1]);
            }
        }

        Console.WriteLine("La multiplicación de las dos matrices es:");

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(" " + terceraMatriz[i, j]);
            }
            Console.WriteLine("");
        }
    }
}
