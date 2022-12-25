//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введи трёхзначное число: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
threeDigitNumber=Math.Abs(threeDigitNumber);
if(threeDigitNumber.ToString().Length == 3)
{
    threeDigitNumber /=10;
    threeDigitNumber %=10;
    Console.Write(threeDigitNumber);
}
else{
   Console.Write($"{threeDigitNumber} число не явялется 3-ех значным"); 
}