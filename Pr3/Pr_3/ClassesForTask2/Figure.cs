using System;

namespace Pr_3.ClassesForTask2
{
    public class Figure
    {
        private Point[] points;

        public Figure(Point A, Point B, Point C)
        {
            points = new Point[] { A, B, C };
        }

        public Figure(Point A, Point B, Point C, Point D)
        {
            points = new Point[] { A, B, C, D };
        }

        public Figure(Point A, Point B, Point C, Point D, Point E)
        {
            points = new Point[] { A, B, C, D, E };
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }

            perimeter += LengthSide(points[points.Length - 1], points[0]); // Додаємо довжину останньої сторони

            Console.WriteLine("Name of the figure: " + points[0].Name);
            Console.WriteLine("Perimeter of the figure: " + perimeter);
        }

    }
}