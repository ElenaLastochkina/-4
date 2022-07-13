void Zadacha25()
{
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.WriteLine ("введите число A:");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите число B:");
int B = Convert.ToInt32(Console.ReadLine());

  Console.WriteLine($"Число {A} в степени {B} равно {Power(A, B)}");

}

int Power(int A, int B)
{
    int result = 1;

    for (int i = 0; i < B; i++)
  {
    result *= A; 
  }
  return result;
}
Zadacha25();


void Zadacha27()
{
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
///452 -> 11
///82 -> 10
///9012 -> 12
Console.WriteLine ("введите число:");
int number = Convert.ToInt32(Console.ReadLine());

SumOfDigit(number);

}

void SumOfDigit(int number)
{
    int sum = 0;

Console.Write("В числе" + number);
while(number >0)
{
    sum += number % 10;
    number /= 10;
}
Console.WriteLine(" сумма цифр равна: " + sum);
}
Zadacha27();

void Zadacha29()
{
//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел 
//и выводит отсортированный по модулю массив.
//-2, 1, 7, 5, 19 -> [1, -2, 5, 7, 19]
//6, 1, -33 -> [1, 6, -33]

int size = 8;
int[] array = new int[size];
Random random = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-10, 11);
}

Console.WriteLine();
Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine();

for (int i = array.Length - 1; i > 0; i--)
{
    int j = i;
    for (j = 0; j < i; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Вывод массива");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine();
}
Zadacha29();