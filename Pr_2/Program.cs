using System;

class Program
{
    static void Main()
    {
        int groupNumber = 6;

        // **Завдання 1: Вибір чисел у вказаному інтервалі**
        FirstTask(groupNumber);

        // **Завдання 2: Обчислення периметру, площі та виду трикутника**
        SecondTask(groupNumber);

        // **Завдання 3: Знаходження мінімального та максимального значень масиву**
        ThirdTask(groupNumber);

        // **Завдання 4: Створення нового масиву Y за певною умовою**
        FourthTask(groupNumber);
    }
    // **Функція для вибору чисел у вказаному інтервалі**

    // Task1

    static void FirstTask(int groupNumber)
    {
        // Масив для зберігання введених чисел
        int[] numbers = new int[3];
        // Цикл для введення 3 чисел
        for (int i = 0; i < 3; i++)
        {
            // Виведення запиту на введення числа
            Console.Write($"Enter a number {i + 1}: ");
            // Зчитування введеного числа
            int input = int.Parse(Console.ReadLine());
            // Зберігання введеного числа в масиві
            numbers[i] = input;
        }
        // Виводжу діапазон
        Console.Write("\nNumbers in the array that are in the range from 1 to " + (10 + groupNumber) + ": ");
        // Перебір всіх чисел в масиві
        foreach (int number in numbers)
        {
            // Перевірка, чи число знаходиться в діапазоні
            if (number >= 1 && number <= (10 + groupNumber))
            {
                // Виведення числа
                Console.Write(number + " ");
            }
        }

        Console.ReadLine();
    }

    // Task2
    // Функція для обчислення периметру, площі та виду трикутника
    static void SecondTask(int groupNumber)
    {
        // Змінні для зберігання довжин сторін трикутника
        double side1, side2, side3;
        // Виведення запитів на введення довжин сторін
        Console.WriteLine("Enter the lengths of the triangle sides:");
        Console.Write("Side 1: ");
        // Цикл для перевірки коректності введення довжини сторони 1
        while (!double.TryParse(Console.ReadLine(), out side1) || side1 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 1: ");
        }
        Console.Write("Side 2: ");
        // Цикл для перевірки коректності введення довжини сторони 2
        while (!double.TryParse(Console.ReadLine(), out side2) || side2 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 2: ");
        }
        Console.Write("Side 3: ");
        // Цикл для перевірки коректності введення довжини сторони 3
        while (!double.TryParse(Console.ReadLine(), out side3) || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive number:");
            Console.Write("Side 3: ");
        }
        // Розрахунок периметру
        double perimeter = side1 + side2 + side3;
        Console.WriteLine($"Perimeter of the triangle: {perimeter}");
        // Перевірка, чи трикутник існує
        if (side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1)
        {
            // Розрахунок півпериметра
            double s = perimeter / 2;
            // Розрахунок площі
            double area = Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            // Виведення площі
            Console.WriteLine($"Area of the triangle: {area}");
            // Визначення типу трикутника
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is equilateral.");
            else if (side1 == side2 || side1 == side3 || side2 == side3)
                Console.WriteLine("The triangle is isosceles.");
            else
                Console.WriteLine("The triangle is scalene.");
        }
        else
        {
            // Виведення повідомлення про те, що трикутник не існує
            Console.WriteLine("Such triangle does not exist.");
        }

        Console.ReadLine();
    }


    // Task 3
    // Функція для знаходження мінімального та максимального значень масиву

    static void ThirdTask(int groupNumber)
    {
        // Задаю масив X
        int[] X = new int[10 + groupNumber];
        // Генерую випадкові числа для масиву X
        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(100);
        }
        // Змінні для зберігання мінімального та максимального значень
        int min = X[0];
        int max = X[0];
        // Перебір всіх елементів масиву
        for (int i = 1; i < X.Length; i++)
        {
            // Оновлення мінімального/макс значення
            if (X[i] < min)
                min = X[i];
            if (X[i] > max)
                max = X[i];
        }
        // вивдення масиву
        Console.Write("Array X: ");
        foreach (int num in X)
        {
            Console.Write(num + " ");
        }
        // Виведення мінімального/макс значеннь
        Console.WriteLine("\nMin value: " + min);
        Console.WriteLine("Max value: " + max);

        Console.ReadLine();
    }

    // Task 4
    // Функція для створення нового масиву Y за певною умовою

    static void FourthTask(int groupNumber)
    {
        //задаю масиви X та Y
        int[] X = new int[10 + groupNumber];
        int[] Y;
        int M; // Змінна для зберігання значення M

        // Генерація випадкових чисел для масиву X
        Random random = new Random();
        for (int i = 0; i < X.Length; i++)
        {
            X[i] = random.Next(-10, 11);
        }
        // Введення значення M
        Console.WriteLine("Enter the value of M: ");
        // Цикл для перевірки коректності введення M
        while (!int.TryParse(Console.ReadLine(), out M))
        {
            Console.WriteLine("Invalid input. Please enter an integer value:");
        }

        // Визначення розміру масиву Y
        int count = CountElementsAboveM(X, M);
        Y = new int[count];

        // Індекс для масиву Y
        int index = 0;

        // Перебір всіх елементів масиву X
        foreach (int element in X)
        {
            // Додавання елемента до масиву Y, якщо його модуль більше M
            if (Math.Abs(element) > M)
            {
                Y[index] = element;
                index++;
            }
        }

        // Виведення значення M
        Console.WriteLine("M: " + M);

        // Виведення масиву X
        Console.WriteLine("Масив X:");
        PrintArray(X);

        // Виведення масиву Y
        Console.WriteLine("Масив Y:");
        PrintArray(Y);

        Console.ReadLine();
    }

    // **Функція для підрахунку кількості елементів масиву, 
    //    модуль яких більше M**
    static int CountElementsAboveM(int[] array, int M)
    {
        // Змінна для підрахунку кількості елементів
        int count = 0;

        // Перебір всіх елементів масиву
        foreach (int element in array)
        {
            // Збільшення лічильника, якщо модуль елемента більше M
            if (Math.Abs(element) > M)
                count++;
        }

        // Повернення кількості елементів
        return count;
    }

    // **Функція для виводу масиву на екран**
    static void PrintArray(int[] array)
    {
        // Перебір всіх елементів масиву
        foreach (int element in array)
        {
            // Виведення елемента
            Console.Write(element + " ");
        }

        // Перехід на новий рядок
        Console.WriteLine();
    }
}



