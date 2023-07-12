// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = Int32.Parse(Console.ReadLine());

int[] arr = num.ToString().ToCharArray().Select(x => x - '0').ToArray();

if (arr[0] == arr[4] && arr[1] == arr[3])
{
    Console.WriteLine("Введенное число является палиндромом!");
}
else
{
    Console.WriteLine("Введенное число не является палиндромом!");
}