﻿// Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
int[] array = new int[] {5, 15, 22, 8, 99, 100};
int i=0;
double pow=Math.Pow(array[i],3);
for(i=0;i<array.Length;i++)
 
    if((array[i] % 2) == 0) 
    {
    pow=Math.Pow(array[i],3);
    System.Console.WriteLine($"{pow}");
    }
 
 
else
{
    System.Console.WriteLine("Число заканчивается на нечетную цифру");
}