using System;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número del vector A: ");
            int primerNumVectorA = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número del vector A: ");
            int segundoNumVectorA = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Ingrese el primer número del vector B: ");
            int primerNumVectorB = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número del vector B: ");
            int segundoNumVectorB = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Vector A: " + primerNumVectorA +" "+ segundoNumVectorA);
            Console.WriteLine("Vector B: " + primerNumVectorB +" "+ segundoNumVectorB);

            Console.WriteLine("\nIngrese 1 si quiere sumar los vectores");
            Console.WriteLine("ingrese 2 si quiere restar los vectores ");
            Console.WriteLine("ingrese 3 si quiere saber la distancia entre los vectores");
            string decision = Console.ReadLine();

            Vectores vector = new Vectores();
            vector.SetNumerosVector(primerNumVectorA, segundoNumVectorA, primerNumVectorB, segundoNumVectorB);

            if (decision == "1")
            {
                Console.Clear();
                Console.WriteLine(vector.GetSuma());
            }
            else if (decision == "2")
            {
                Console.Clear();
                Console.WriteLine(vector.GetResta());
            }
            else if (decision == "3")
            {
                Console.Clear();
                Console.WriteLine(vector.GetDistancia());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Número de decisión no valido");
            }
        }
    }

    class Vectores
    {
        private int primerNumVectorA;
        private int segundoNumVectorA;
        private int primerNumVectorB;
        private int segundoNumVectorB;

        public Vectores()
        {
            this.primerNumVectorA = 3;
            this.segundoNumVectorA = 7;
            this.primerNumVectorB = 2;
            this.segundoNumVectorB = 6;
        }

        public void SetNumerosVector(int primerNumA, int segundoNumA, int primerNumB, int segundoNumB)
        {
            primerNumVectorA = primerNumA;
            segundoNumVectorA = segundoNumA;
            primerNumVectorB = primerNumB;
            segundoNumVectorB = segundoNumB;
        }

        public string GetSuma()
        {
            return "El resultado de la suma de los dos vectores es C = (" + (primerNumVectorA + primerNumVectorB) + " , " + (segundoNumVectorA + segundoNumVectorB) + ")";
        }

        public string GetResta()
        {
            return "El resultado de la suma de los dos vectores es C = (" + (primerNumVectorA - primerNumVectorB) + " , " + (segundoNumVectorA - segundoNumVectorB) + ")";
        }

        public string GetDistancia()
        {
            int resultadoA = primerNumVectorB - primerNumVectorA;
            int resultadoB = segundoNumVectorB - segundoNumVectorA;

            resultadoA = resultadoA * resultadoA;
            resultadoB = resultadoB * resultadoB;

            int resultadoC = resultadoA + resultadoB;

            double resultadoD = Math.Sqrt(resultadoC);

            return "La distancia entre los vectores es " + resultadoD;
        }
    }
}
