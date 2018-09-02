using System;

namespace _02SikidomokTerulete
{
    class Program
    {
        static void Main(string[] args)
        {

            var square = new Square(side: 4);
            
            //e helyett
            //"A négyzet területe: " + square.Area().ToString();
            Console.WriteLine($"A négyzet területe: {square.Area()}");

            var circle = new Circle(radius: 5);
            Console.WriteLine($"A kör területe: {circle.Area()}");

            var triangle = new Triangle(triangleBase: 6, height:4);

            Console.WriteLine($"A háromszög területe: {triangle.Area()}");

            Console.ReadLine();

        }
    }
}
