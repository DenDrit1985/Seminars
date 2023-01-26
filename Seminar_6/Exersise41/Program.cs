/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел 
останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
0, 7, 8, -2, -2 -> 2
, -7, 567, 89, 223-> 4.*/

bool inpValid_01(int num)
{
    if(num > 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool inpValid(string num)
{
    bool res_val = int.TryParse(num, out int res_num);
    if(res_val == true)
    {
        return true;
    }   
    else
    {
        return false;
    }
}

int intNum = 0;
string strNum = "";
int sumRes = 0;
while(true)
{
    Console.WriteLine("введите следующее число или нажмите 'stop' для stop: ");
    strNum = Console.ReadLine();
    if(strNum.ToLower() == "stop")
    {
        Console.WriteLine($"Числа больше нуля: {sumRes}");
        Console.WriteLine("Пока");
        break;
    }
    else
    {
        bool result = inpValid(strNum);
        if(result == true)
        {
            intNum = Int32.Parse(strNum);
            bool result_02 = inpValid_01(intNum);
            if(result_02 == true) 
            {
                sumRes++;
            }
            continue;
        }
        else
        {
            Console.WriteLine("Ошибка");
            continue;
        }
    }    
}

