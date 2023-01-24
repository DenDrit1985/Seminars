//задание 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения
//которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

int N=123;
int[] a=new int[N];
Random random=new Random();
for(int i=0;i<a.Length;i++)
a[i]=random.Next(0,150);
for(int i=0;i<a.Length;i++)
System.Console.Write($"{a[i],4}");

int count=0;
for(var i=0; i<a.Length;i++)
{
if(a[i]>9 & a[i]<100)
count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);