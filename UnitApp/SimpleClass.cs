using System;

namespace UnitApp
{
    public class SimpleClass
    {
        public static bool IsEmpty(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Вы ничего не ввели!");
                return true;
            }

            return false;
        }

        public static bool IsDigital(string str)
        {
            foreach (char ch in str)
            {
                if (ch < '0' || ch > '9')
                {
                    Console.WriteLine("Вы ввели не цифры, как мы будем их складывать?!");
                    return false;
                }
            }
            return true;
        }

        public static bool IsLengthLessMaxInteger(string str)
        {
            int intLength = Int32.MaxValue.ToString().Length;
            // 2,147,483,647
            if (str.Length >= intLength - 1)
            {
                Console.WriteLine($"Вы ввели сильно длинное значение. Больше, чем {intLength - 1}");
                return false;
            }
            return true;
        }

        public static string CheckString()
        {
            string a;
            do
            {
                Console.WriteLine("Введите строку");
                a = Console.ReadLine();
            } while (IsEmpty(a) || !IsDigital(a) || !IsLengthLessMaxInteger(a));

            return a;
        }
    }
}