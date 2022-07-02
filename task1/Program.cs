// Задача 1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}

int num = Prompt("Введите пятизначное число: ");
if (num > 9999 && num < 100000)                 //если число пятизначное
{
    int firstpart = num / 1000;                 // первые 2 цифры числа
    int secondpart = num % 100;                 // последние 2 цифры числа 

    int temp1 = firstpart % 10;                 //вторая цифра 
    int temp2 = firstpart / 10;                 //получаем первую цифру
    int temp3 = secondpart % 10;                //последняя цифра
    int temp4 = secondpart / 10;                //четвертая цифра
    if (temp1 == temp4 && temp2 == temp3)       //если вторая цифра равна четвертой и первая цифра равна последней
    {
        System.Console.WriteLine($"Число {num} является палиндромом");
    }
    else System.Console.WriteLine($"Число {num} не палиндром");
}
else System.Console.WriteLine("Вы ввели не пятизначное число.");