﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            var s1 = new Rectangle(10, 20);
            Console.WriteLine("{0},{1}", s1.X, s1.Y);

            var s2 = new Circle(25, 25);
            Console.WriteLine("{0},{1}", s2.X, s2.Y);

            var s3 = new Square(50, 50);
            Console.ReadKey();

          

            //  VirtualKeyword();

            //   new Square().Calculate();
            Console.ReadKey();

        }

        private static void Polymorphism()
        {
            var shapes = new List<Shape>()
            {
                new Rectangle(),
                new Circle(),
                new Triangle(),
                new Square()

            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }

        private static void VirtualKeyword()
        {
            var _s1 = new Rectangle();
            var _s2 = new Circle();

            _s1.X = 10;
            _s1.Y = 100;
            Console.WriteLine("{0},{1}", _s1.X, _s1.Y);
            _s1.Draw();

            _s2.X = 5;
            _s2.Y = 55;
            Console.WriteLine("{0},{1}", _s2.X, _s2.Y);
            _s2.Draw();

            new Triangle().Draw();  // Methodu çağırmak için alternatif yöntem. 
        }
    }
}


