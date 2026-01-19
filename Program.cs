using System;

namespace LabWork
{
    class Rectangle
    {
        public double B1 { get; set; }
        public double A1 { get; set; }
        public double B2 { get; set; }
        public double A2 { get; set; }

        public virtual void SetCoefficients()
        {
            Console.Write("b1: ");
            B1 = double.Parse(Console.ReadLine());
            Console.Write("a1: ");
            A1 = double.Parse(Console.ReadLine());
            Console.Write("b2: ");
            B2 = double.Parse(Console.ReadLine());
            Console.Write("a2: ");
            A2 = double.Parse(Console.ReadLine());
        }

        public virtual void DisplayCoefficients()
        {
            Console.WriteLine($"{B1} <= x1 <= {A1}, {B2} <= x2 <= {A2}");
        }

        public virtual bool IsPointInside()
        {
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            return (x1 >= B1 && x1 <= A1) && (x2 >= B2 && x2 <= A2);
        }
    }

    class Parallelepiped : Rectangle
    {
        public double B3 { get; set; }
        public double A3 { get; set; }

        public override void SetCoefficients()
        {
            base.SetCoefficients();
            Console.Write("b3: ");
            B3 = double.Parse(Console.ReadLine());
            Console.Write("a3: ");
            A3 = double.Parse(Console.ReadLine());
        }

        public override void DisplayCoefficients()
        {
            Console.WriteLine($"{B1} <= x1 <= {A1}, {B2} <= x2 <= {A2}, {7} <= x3 <= {A3}");
        }

        public override bool IsPointInside()
        {
            Console.Write("x1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("x3: ");
            double x3 = double.Parse(Console.ReadLine());
            return (x1 >= B1 && x1 <= A1) && (x2 >= B2 && x2 <= A2) && (x3 >= B3 && x3 <= A3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1 - Rectangle, 2 - Parallelepiped, 0 - Exit");
                string choice = Console.ReadLine();
                if (choice == "0") break;

                Rectangle figure;

                if (choice == "1")
                {
                    figure = new Rectangle();
                }
                else if (choice == "2")
                {
                    figure = new Parallelepiped();
                }
                else
                {
                    continue;
                }

                figure.SetCoefficients();
                figure.DisplayCoefficients();

                if (figure.IsPointInside())
                {
                    Console.WriteLine("Inside");
                }
                else
                {
                    Console.WriteLine("Outside");
                }
            }
        }
    }
}