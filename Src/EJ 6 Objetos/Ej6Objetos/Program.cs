using System;

namespace EJ_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hora horaInicial = new Hora();
            int horas;
            int minutos;
            int segundos;
            int milisegundos;
            //Console.WriteLine("El programa empieza a las 00:00:00:00 por defecto.");
            do
            {
                Console.WriteLine("Ingrese la hora: ");
                horas = int.Parse(Console.ReadLine());
            } while (horas >= 24);

            do
            {
                Console.WriteLine("Ingrese los minutos: ");
                minutos = int.Parse(Console.ReadLine());
            } while (minutos >= 60);

            do
            {
                Console.WriteLine("Ingrese los segundos: ");
                segundos = int.Parse(Console.ReadLine());
            } while (segundos >= 60);

            do
            {
                Console.WriteLine("Ingrese los milisegundos: ");
                milisegundos = int.Parse(Console.ReadLine());
            } while (milisegundos >= 1000);

            horaInicial.setHora(horas, minutos, segundos, milisegundos);

            Console.Clear();
            Console.WriteLine("1 - Incrementar la hora");
            Console.WriteLine("2 - Disminuír la hora");
            string respuesta = Console.ReadLine();

            if (respuesta == "1")
            {
                horaInicial.incrementarHora(horas, minutos, segundos, milisegundos);
            }
            else if (respuesta == "2")
            {
                horaInicial.disminuirHora(horas, minutos, segundos, milisegundos);
            }
            else
            {
                Console.WriteLine("Respuesta incorrecta. Se cerrará el programa.");
            }
        }
    }

    class Hora
    {
        private int horas;
        private int minutos;
        private int segundos;
        private int milisegundos;

        public Hora()
        {

        }

        public void setHora(int horas, int minutos, int segundos, int milisegundos)
        {
            this.horas = horas;
            this.minutos = minutos;
            this.segundos = segundos;
            this.milisegundos = milisegundos;
        }

        public string getHora()
        {
            return horas + ":" + minutos + ":" + segundos + ":" + milisegundos;
        }

        public void incrementarHora(int horas, int minutos, int segundos, int milisegundos)
        {
            int horaAumentada = 0 + horas;
            int minutoAumentado = 0 + minutos;
            int segundoAumentado = 0 + segundos;
            int milisegundoAumentado = 0 + milisegundos;

            Console.Clear();
            Console.WriteLine("La hora sumada sería: " + horaAumentada + ":" + minutoAumentado + ":" + segundoAumentado + ":" + milisegundoAumentado);
        }

        public void disminuirHora(int horas, int minutos, int segundos, int milisegundos)
        {
            int horaDisminuida = 24 - horas;
            int minutoDisminuido = 60 - minutos;
            int segundoDisminuido = 60 - segundos;
            int milisegundosDisminuido = 1000 - milisegundos;

            Console.Clear();
            Console.WriteLine("La hora disminuída sería: " + horaDisminuida + ":" + minutoDisminuido + ":" + segundoDisminuido + ":" + milisegundosDisminuido);
        }
    }
}
