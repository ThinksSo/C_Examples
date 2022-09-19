void Task9()
{
    // Вывести случайное число из отрезка [10, 99]
    // и показать наибольшую цифру из числа

    Random random = new Random(); 
    // создание объекта Random типа random
    int num = random.Next(10,100);
    Console.WriteLine(num);

    int tens = num / 10;
    int ones = num % 10;

    Console.WriteLine(tens);
    Console.WriteLine(ones);

    if (tens == ones) 
    {Console.WriteLine($"a = b = {tens} \n");}
    else if (tens > ones) 
    {Console.WriteLine($"max = {tens} \n");}
    else 
    {Console.WriteLine($"max = {ones} \n");}
}

Task9();


void Task11()
{
    // В11. Напишите программу, которая выводит случайное трёхзначное число 
    // и удаляет вторую цифру этого числа.

    Random random = new Random(); 
  
    int num = random.Next(100,1000);
    Console.WriteLine(num);

    int thousands = num /100;
    int tens = num / 10;
    int ones = num % 10;

    Console.WriteLine(thousands * 10 + ones);
   
}

Task11();
