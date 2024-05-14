using System;

class Program
{
    static void Main()
    {
        int groupNumber = 6;

        // **�������� 1: ���� ����� � ��������� ��������**
        FirstTask(groupNumber);

        // **�������� 2: ���������� ���������, ����� �� ���� ����������**
        SecondTask(groupNumber);

        // **�������� 3: ����������� ���������� �� ������������� ������� ������**
        ThirdTask(groupNumber);

        // **�������� 4: ��������� ������ ������ Y �� ������ ������**
        FourthTask(groupNumber);
    }
    // **������� ��� ������ ����� � ��������� ��������**

    // Task1

    static void FirstTask(int groupNumber)
    {
        // ����� ��� ��������� �������� �����
        int[] numbers = new int[3];
        // ���� ��� �������� 3 �����
        for (int i = 0; i < 3; i++)
        {
            // ��������� ������ �� �������� �����
            Console.Write($"Enter a number {i + 1}: ");
            // ���������� ��������� �����
            int input = int.Parse(Console.ReadLine());
            // ��������� ��������� ����� � �����
            numbers[i] = input;
        }
        // ������� �������
        Console.Write("\nNumbers in the array that are in the range from 1 to " + (10 + groupNumber) + ": ");
        // ������ ��� ����� � �����
        foreach (int number in numbers)
        {
            // ��������, �� ����� ����������� � �������
            if (number >= 1 && number <= (10 + groupNumber))
            {
                // ��������� �����
                Console.Write(number + " ");
            }
        }

        Console.ReadLine();
    }

    // Task2
    // ������� ��� ���������� ���������, ����� �� ���� ����������
    static void SecondTask(int groupNumber)
    {
        // ���� ��� ��������� ������ ����� ����������
        double side1, side2, side3;
        // ��������� ������ �� �������� ������ �����
        Console.WriteLine("Enter the lengths of the triangle sides:");
        Console.Write("Side 1: ");
        // ���� ��� �������� ���������� �������� ������� ������� 1
        while (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 1: ");
        }
        Console.Write("Side 2: ");
        // ���� ��� �������� ���������� �������� ������� ������� 2
        while (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 2: ");
        }
        Console.Write("Side 3: ");
        // ���� ��� �������� ���������� �������� ������� ������� 3
        while (!double.TryParse(Console.ReadLine(), out side3) || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 3: ");
        }
        // ���������� ���������
        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"Perimeter of the triangle: {perimeter}");
        // ��������, �� ��������� ����
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            // ���������� �����������
            double s = perimeter / 2;
            // ���������� �����
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            // ��������� �����
            Console.WriteLine($"Area of the triangle: {area}");
            // ���������� ���� ����������
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is isosceles.");
            else
                Console.WriteLine("The triangle is scalene.");
        }
        else
        {
            // ��������� ����������� ��� ��, �� ��������� �� ����
            Console.WriteLine("Such triangle does not exist.");
        }

        Console.ReadLine();
    }


    // Task 3
    // ������� ��� ����������� ���������� �� ������������� ������� ������

    static void ThirdTask(int groupNumber)
    {
        // ����� ����� X
        int[] X = new int[10 + groupNumber];
        // ������� �������� ����� ��� ������ X
        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(100);
        }
        // ���� ��� ��������� ���������� �� ������������� �������
        int min = X[0];
        int max = X[0];
        // ������ ��� �������� ������
        for (int i = 1; i < X.Length; i++)
        {
            // ��������� ����������/���� ��������
            if (X[i] < min)
                min = X[i];
            if (X[i] > max)
                max = X[i];
        }
        // �������� ������
        Console.Write("Array X: ");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        // ��������� ����������/���� ��������
        Console.WriteLine("\nMin value: " + min);
        Console.WriteLine("Max value: " + max);

        Console.ReadLine();
    }

    // Task 4
    // ������� ��� ��������� ������ ������ Y �� ������ ������

    static void FourthTask(int groupNumber)
    {
        //����� ������ X �� Y
        int[] X = new int[10 + groupNumber];
        int[] Y;
        int M; // ����� ��� ��������� �������� M

        // ��������� ���������� ����� ��� ������ X
        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(-10, 11);
        }
        // �������� �������� M
        Console.WriteLine("Enter the value of M: ");
        // ���� ��� �������� ���������� �������� M
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.WriteLine("Invalid input. Please enter an integer value:");
        }

        // ���������� ������ ������ Y
        int count = CountElementsAboveM(X, M);
        Y = new int[count];

        // ������ ��� ������ Y
        int index = 0;

        // ������ ��� �������� ������ X
        foreach (int element in X)
        {
            // ��������� �������� �� ������ Y, ���� ���� ������ ����� M
            if (Math.Abs(element) > M)
            {
                Y[index] = element;
                index++;
            }
        }

        // ��������� �������� M
        Console.WriteLine("M: " + M);

        // ��������� ������ X
        Console.WriteLine("����� X:");
        PrintArray(X);

        // ��������� ������ Y
        Console.WriteLine("����� Y:");
        PrintArray(Y);

        Console.ReadLine();
    }

    // **������� ��� ��������� ������� �������� ������, 
    //    ������ ���� ����� M**
    static int CountElementsAboveM(int[] array, int M)
    {
        // ����� ��� ��������� ������� ��������
        int count = 0;

        // ������ ��� �������� ������
        foreach (int element in array)
        {
            // ��������� ���������, ���� ������ �������� ����� M
            if (Math.Abs(element) > M)
                count++;
        }

        // ���������� ������� ��������
        return count;
    }

    // **������� ��� ������ ������ �� �����**
    static void PrintArray(int[] array)
    {
        // ������ ��� �������� ������
        foreach (int element in array)
        {
            // ��������� ��������
            Console.Write(element + " ");
        }

        // ������� �� ����� �����
        Console.WriteLine();
    }
}



