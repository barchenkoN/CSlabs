using System;
using Pr_3.ClassesForTask1;
using Pr_3.ClassesForTask2;

namespace Pr_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
        }

        private static void Task1()
        {
            Book book = new Book("The White Guard", "Mikhail Bulgakov", "A novel set in Kiev during the Russian Civil War, focusing on the lives of the Turbin family and their experiences during the chaos of the time.");
            book.Show();
        }

        private static void Task2()
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(0, 4, "B");
            Point C = new Point(3, 0, "C");

            Figure figure = new Figure(A, B, C);

            figure.PerimeterCalculator();
        }
    }
}