using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerc6
{
    class Forma
    {
        double x;
        double y;
        double area;
        double perimetro;

        public Forma(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public virtual double Area()
        {
            return area;
        }
        public virtual double Perimetro()
        {
            return perimetro;
        }

        public override string ToString()
        {
            return "X: " + x + " Y: " + y;
        }

    }
    class Rectangulo : Forma
    {
        double lado1;
        double lado2;

        public Rectangulo(double x, double y, double lado1, double lado2) : base(x, y)
        {
            this.Lado1 = lado1;
            this.Lado2 = lado2;
        }

        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; }

        public override double Area()
        {
            return lado1 * lado2;
        }

        public override double Perimetro()
        {
            return 2 * (lado1 + lado2);
        }
        public override string ToString()
        {
            return "Rectangulo: " + "Lado 1: " + lado1 + " Lado 2: " + lado2 + "En x: " + X + "En y: " + Y;
        }
    }

    class Circulo : Forma
    {
        double radio;

        public Circulo(double x, double y, double radio) : base(x, y)
        {
            this.radio = radio;
        }

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(radio, 2);
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * radio;
        }

        public override string ToString()
        {
            return "Círculo de radio:" + radio + " en x: " + X + "," + " y: " + Y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Forma forma = new Forma(2.2, 4.3);
            forma.ToString();
            Rectangulo rectangulo = new Rectangulo(3.0, 4.0, 5.0, 6.0);
            Console.WriteLine(rectangulo);
            Console.WriteLine($"Área: {rectangulo.Area()}");
            Console.WriteLine($"Perímetro: {rectangulo.Perimetro()}");

            Circulo circulo = new Circulo(7.0, 8.0, 9.0);
            Console.WriteLine(circulo);
            Console.WriteLine($"Área: {circulo.Area()}");
            Console.WriteLine($"Perímetro: {circulo.Perimetro()}");



            Console.ReadKey();
        }
    }
}
