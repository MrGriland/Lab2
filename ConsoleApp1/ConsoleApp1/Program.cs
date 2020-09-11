using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 9;
            while (x != 0)
            {
                Console.WriteLine("Input number of task");
                x = Convert.ToInt16(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        Taskone();
                        break;
                    case 2:
                        Tasktwo();
                        break;
                    case 3:
                        Taskthree();
                        break;
                    default:
                        return;
                }
            }
        }
        static void Taskone()
        {
            bool q1 = true;
            byte q2 = 3;
            sbyte q3 = -3;
            char q4 = 'f';
            decimal q5 = 300;
            double q6 = 200.4;
            float q7 = 3.6f;
            int q8 = 255;
            uint q9 = 256;
            long q10 = 555;
            ulong q11 = 556;
            short q12 = 222;
            ushort q13 = 223;
            string q14 = "afsafa";
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}\n{10}\n{11}\n{12}\n{13}", q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14);
            int num1 = 2147;
            long bigNum1 = num1;
            float num2 = 134.45f;
            double bigNum2 = num2;
            byte num3 = 5;
            short bigNum3 = num3;
            long num4 = 87;
            decimal bigNum4 = num4;
            ushort num5 = 56;
            int bigNum5 = num5;
            int smallNum1 = (int)bigNum2;
            long smallNum2 = (long)bigNum4;
            decimal smallNum3 = (decimal)num2;
            short smallNum4 = (short)bigNum5;
            uint smallNum5 = (uint)bigNum1;
            int price = 39;
            Object obj = price;
            int price2 = (int)obj;
            var f = 0.34F;
            double? d1 = 3.3;
            var j = 3;
            //j = 0.34F;
        }
        static void Tasktwo()
        {

        }
        static void Taskthree()
        {

        }
        
    }
}
