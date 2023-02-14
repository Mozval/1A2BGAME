using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 題目1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1A2B 猜數字");
            int[]numbers=new int[4];
            numbers[0] = new Random().Next(0, 10);//產生亂數初始值
            numbers[1] = new Random().Next(0, 10);
            numbers[2] = new Random().Next(0, 10);
            numbers[3] = new Random().Next(0, 10);
            do
            {
                numbers[1] = new Random().Next(0, 10);
            } while (numbers[0] == numbers[1]);
            do
            {
                numbers[2] = new Random().Next(0, 10);
            } while (numbers[1] == numbers[2]|| numbers[0] == numbers[2] );
            do
            {
                numbers[3] = new Random().Next(0, 10);
            } while (numbers[0] == numbers[3] || numbers[3] == numbers[2] || numbers[3] == numbers[1] );

            Console.WriteLine($"答案{numbers[0]}{numbers[1]}{numbers[2]}{numbers[3]}");
            bool d = true;
            do
            {   


                Console.WriteLine("請輸入數字");
                string enter = Console.ReadLine();
                int[] ch = new int[4];

                int a = 0;
                int b = 0;
                int c = 0;
                foreach (char i in enter)
                {
                    ch[c++] = Convert.ToInt32(i - '0');
                }
                if (ch[0] == numbers[0])
                {
                    a += 1;

                }
                if (ch[1] == numbers[1])
                {
                    a += 1;
                }
                if (ch[2] == numbers[2])
                {
                    a += 1;
                }
                if (ch[3] == numbers[3])
                {
                    a += 1;
                }
                if (ch[1] == numbers[0] || ch[1] == numbers[2] || ch[1] == numbers[3])
                {
                    b += 1;

                }
                if (ch[0] == numbers[1] || ch[0] == numbers[2] || ch[0] == numbers[3])
                {
                    b += 1;

                }
                if (ch[2] == numbers[1] || ch[2] == numbers[3] || ch[2] == numbers[0])
                {
                    b += 1;

                }
                if (ch[3] == numbers[1] || ch[3] == numbers[2] || ch[3] == numbers[0])
                {
                    b += 1;

                }
                Console.WriteLine($"{a}A{b}B 恭喜你答對了");
                if (a == 4)
                {
                    d = false;
                    break;
                }

            } while (d); 

             
            Console.ReadLine();
        }

    }
}
