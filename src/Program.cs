using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СергеевПрактика
{
    internal class Program
    {
        static void Main(string[] args)

        //Задание 1.1 Среднее арифмитическое

        {
            Console.WriteLine("Введите первое число:");
            double firstNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double secondNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число:");
            double thirdNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите четвёртое число:");
            double fourthNum = Convert.ToInt32(Console.ReadLine());

            double result = (firstNum + secondNum + thirdNum + fourthNum) / 4;
            Console.WriteLine("Среднее значение:" + result);
        }
    }
}
//Задание 2.1 Калькулятор


    internal class partialProgram
    {
        static void Calculator(string[] args)
        {
            float one, two, result;
            char sign;
            Console.Write("Введите первое число: ");
            one = Convert.ToSingle(Console.ReadLine());
            Console.Write("Введите знак: ");
            sign = Convert.ToChar(Console.ReadLine());
            Console.Write("Введите второе число: ");
            two = Convert.ToSingle(Console.ReadLine());
            if (sign == '+')
            {
                result = one + two;
                Console.WriteLine("Ответ " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '-')
            {
                result = one - two;
                Console.WriteLine("Ответ " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '*')
            {
                result = one * two;
                Console.WriteLine("Ответ " + result);
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
            }
            else if (sign == '/')
            {
                if (two == 0)
                {
                    Console.WriteLine("Ошибка. Делитель не может быть равен нулю.");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }
                else
                {
                    result = one / two;
                    Console.WriteLine("Ответ: " + result);
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                }


            }
            else
            {
                Console.WriteLine("Ошибка. Неверный знак.");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();


            }

        }

    }
//Задание 3.1 Температура
class Prog
{
    static void Temprature(string[] args)
    {
        Console.WriteLine("Выберите шкалу вводимой температуры:");
        Console.WriteLine("1. Цельсий");
        Console.WriteLine("2. Кельвин");
        Console.WriteLine("3. Фаренгейт");
        Console.Write(">");

        if (int.TryParse(Console.ReadLine(), out int inputScale) && inputScale >= 1 && inputScale <= 3)
        {
            Console.Write("Введите показатель температуры (градусы):\n>");
            if (double.TryParse(Console.ReadLine(), out double inputTemperature))
            {
                Console.WriteLine("Выберите тип шкалы для конвертации:");
                Console.WriteLine("1. Цельсий");
                Console.WriteLine("2. Кельвин");
                Console.WriteLine("3. Фаренгейт");
                Console.Write(">");

                if (int.TryParse(Console.ReadLine(), out int outputScale) && outputScale >= 1 && outputScale <= 3)
                {
                    double result = 0;
                    string inputScaleName = "";
                    string outputScaleName = "";

                    switch (inputScale)
                    {
                        case 1:
                            inputScaleName = "Цельсий";
                            result = inputTemperature;
                            break;
                        case 2:
                            inputScaleName = "Кельвин";
                            result = inputTemperature - 273.15;
                            break;
                        case 3:
                            inputScaleName = "Фаренгейт";
                            result = (inputTemperature - 32) * 5 / 9;
                            break;
                    }

                    switch (outputScale)
                    {
                        case 1:
                            outputScaleName = "Цельсий";
                            break;
                        case 2:
                            outputScaleName = "Кельвин";
                            result += 273.15;
                            break;
                        case 3:
                            outputScaleName = "Фаренгейт";
                            result = result * 9 / 5 + 32;
                            break;
                    }

                    Console.WriteLine($"Вы выбрали: {inputScaleName}->{outputScaleName}");
                    Console.WriteLine($"Результат конвертации: {result:F1}");
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Попробуйте снова.");
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Введите число.");
            }
        }
        else
        {
            Console.WriteLine("Неверный ввод. Попробуйте снова.");
        }

        Console.ReadKey();
    }
}

//Задание 4.1. Файл.
 
namespace TestConcole
{
    class Program
    {
        static void File(string[] args)
        {
            string catalog = @"C:\Users\user\Desktop\Новый текстовый документ (3)";

            string fileName = "Файл.txt";

            
            foreach (string findedFile in Directory.EnumerateFiles(catalog, fileName,
SearchOption.AllDirectories))
            {
                FileInfo FI;
                try
                {
                   
                    FI = new FileInfo(findedFile);
                    
                    Console.WriteLine(FI.Name + " " + FI.FullName + " " + FI.Length + "_байт" +
" Создан: " + FI.CreationTime);

                }
                catch 
                {
                    continue;
                }

            }
        }

    }
}

//Задание 5 часть 1. Длина

static void Lenght()
{
    Console.Clear();
    Console.WriteLine("Введите предложение");
    string task = Console.ReadLine();
    string[] words = task.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string longestWord = "";
    foreach (string word in words)
    {
        if (word.Length > longestWord.Length)
        {
            longestWord = word;
        }
    }
    if (longestWord.Length > 0)
    {
        Console.WriteLine("Самое длинное слово " + longestWord);
        Console.ReadLine();
        Back();
    }
    else
    {
        Console.WriteLine("Нет слов в предложении");
        Console.ReadLine();
        Back();
    }
}

//Задание 6 часть 1. Перемножение массивов

static void MassiveMultiply()
{
    Console.Clear();
    Console.WriteLine("Введите количество чисел в массиве: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] arrayOne = new int[size];
    int[] arrayTwo = new int[size];
    Console.WriteLine("Массив 1: ");
    string[] inputOne = Console.ReadLine().Split(' ');
    if (inputOne.Length != size)
    {
        Console.WriteLine("Ты не правильно ввёл числа");
        Console.ReadLine();
        MassiveMultiply();
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            arrayOne[i] = Convert.ToInt32(inputOne[i]);
        }
    }
    Console.WriteLine("Введите через пробел элементы второго массива");
    string[] inputTwo = Console.ReadLine().Split(' ');
    if (inputTwo.Length != size)
    {
        Console.WriteLine("Ты не правильно ввёл числа");
        Console.ReadLine();
        MassiveMultiply();
    }
    else
    {
        for (int i = 0; i < size; i++)
        {
            arrayTwo[i] = Convert.ToInt32(inputTwo[i]);
        }
    }
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = arrayOne[i] * arrayTwo[i];
    }
    Console.WriteLine("Результат");
    foreach (int value in result)
    {
        Console.Write(value + " ");

    }
    Console.ReadLine();
    Back();



}

//Задание 1.7 MAX MIN 
{
    static void MaxNumber()
    {
        Console.Clear();
        Console.WriteLine("Введите числа: ");
        string Numbers = Console.ReadLine();
        string[] NumbersParts = Numbers.Split(new char[] { ' ' });
        string biggestNum = "-2147483647";
        string minNum = "2147483647";
        if (NumbersParts.Length != 5)
        {
            Console.WriteLine("Ошибка!");
            Console.ReadLine();
            MaxNumber();

        }
        else
        {
            foreach (string value in NumbersParts)
            {

                if (Convert.ToDouble(value) > Convert.ToDouble(biggestNum))
                {
                    biggestNum = value;


                }
                if (Convert.ToDouble(value) < Convert.ToDouble(minNum))
                {

                    minNum = value;
                }

            }
            Console.WriteLine($"biggest {biggestNum}");
            Console.WriteLine(($"smallest {minNum}"));
            Console.ReadLine();
            Back();


        }
    }
    //Задание 8.1 Пирамида
    void print ();

int altura;
Console.WriteLine("Dar altura: ");
altura = int.Parse(Console.ReadLine());
for (int i = 1; i <= altura; i++)
{
    string space = "";
    for (int j = 1; j <= i; j++)
    {
        space = space + Convert.ToString(j);
    }
    Console.WriteLine(space);
}
Console.ReadLine();

//Задание 2

Console.WriteLine("\ny/x |   1\t2\t3\t4\t5\t6\t7\t8\t9");
Console.Write("--------------------------------------------------------------------------");
Console.WriteLine();
for (int i = 1; i < 10; i++)
{
    Console.Write(i + "   |  ");
    for (int j = 1; j < 10; j++)
    {
        Console.Write("\t" + i * j);
    }
    Console.WriteLine("");
    Console.WriteLine("");
}
Console.ReadLine();

//Задание 3. Вариант 21

static void WholeNumber()
{
    float a, result;
    char sign;
    Console.Write("Введите целое число: ");
    a = Convert.ToSingle(Console.ReadLine());
    Console.Write("Введите знак действия: ");
    sign = Convert.ToChar(Console.ReadLine());
    if (sign == '+')
    {
        result = s;
        int a = int.Parse(Console.ReadLine());
        int s = 0;
        while (a > 0)
        {

            s = s + a % 10;
            a = a / 10;

        }
        Console.WriteLine(s);
    }
    else if (sign == '-')
    {
        result = s;
        int a = int.Parse(Console.ReadLine());
        int s = 0;
        while (a > 0)
        {

            s = s - a % 10;
            a = a / 10;

        }
        Console.WriteLine(s);
    }
    else if (sign == '*')
    {
        result = s;
        int a = int.Parse(Console.ReadLine());
        int s = 0;
        while (a > 0)
        {

            s = s * a % 10;
            a = a / 10;

        }
        Console.WriteLine(s);
    }

    else
    {
        Console.WriteLine("Ошибка. Неверный знак.");
        Console.WriteLine("Для выхода нажмите любую клавишу...");
        Console.ReadKey();


    }

}

    }