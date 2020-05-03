using System;

namespace FormattingUsagePractice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double num1, num2, result;
            num1 = 10.0;
            num2 = 3.0; 
            result = num1 / num2;
            Console.WriteLine("Деление 10/3 дает: (0:#.##)" + result); // моя интерпреация
            //Console.WriteLine("Деление 10/3 дает: (0:#.##)", 10.0 / 3.0); //так было в учебнике

            Console.WriteLine("{0:###,###.##}", 123456.56);//работает как надо

            decimal balance;
            balance = 12323.09m;
            Console.WriteLine("Текущий баланс равен {0:С}", balance);// не работает как надо 
        }
    }
}
