// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Сравните два числа");
int num1; 
int num2;
Console.WriteLine("Введите первое число - ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
num2 = Convert.ToInt32(Console.ReadLine());
 
    if (num1 > num2)
            {
                Console.WriteLine($"Число {num1} больше чем {num2}");
            }
            else if (num1 == num2)
            {
                Console.WriteLine($"Числа {num1} и {num2} равны");
            }
            else
            {
                Console.WriteLine($"Число {num2} больше чем {num1}");
            }
        

