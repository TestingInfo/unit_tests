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

        public static bool OloloInString(string str)
        {
            string a;
            string b;
            string c;
            if (str == "ololo")
            {
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



        public static string CheckString()
        {
            string a;
            do
            {
                Console.WriteLine("Введите строку");
                a = Console.ReadLine();
            } while (IsEmpty(a) || !IsLengthLessMaxInteger(a) || OloloInString(a));
                Console.WriteLine("Печатаем вашу строку консоль " + a);
            return a;
        }

        public static void Prog()
        {
            Console.WriteLine("Веедите строку");
            string str = Console.ReadLine();
            
            string a;
            string b;
            string c;
            
            if (OloloInString(str))
            {
                Console.WriteLine("Введите первое число");
                a = Console.ReadLine();
                Console.WriteLine("Введите второе число");
                b = Console.ReadLine();
                if(!IsEmpty(a) || !IsEmpty(b) || !IsLengthLessMaxInteger(a) || !IsLengthLessMaxInteger(b) || IsDigital(a) || IsDigital(b))
                {
                     c = Convert.ToString((Convert.ToInt32(a)) + (Convert.ToInt32(b)));
                                    Console.WriteLine("Сумма ваших чисел" + c);
                                    
                }
               
            }Console.WriteLine("Печатаем вашу строку консоль " + str);
        }
    }
}
