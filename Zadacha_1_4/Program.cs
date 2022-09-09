// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
Console.WriteLine("Найдите максимальное число из трёх");
 string[] i = Console.ReadLine().Split(' ');
            int num1 = Convert.ToInt32(i[0]);
            int num2 = Convert.ToInt32(i[1]);
            int num3 = Convert.ToInt32(i[2]);
            Console.WriteLine(Math.Max(num1, Math.Max(num2, num3)));