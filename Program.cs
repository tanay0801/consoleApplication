using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
           
               Console.WriteLine("Please enter your name:-");
               string UserName = Console.ReadLine();
               Console.WriteLine("hello,  "+ UserName);
           
            Console.WriteLine("please select the following one program:-");
              Console.WriteLine("(1) for number to words.");
              Console.WriteLine("(2) for hello world.");
              Console.WriteLine("(3) for percentage calculator");
            int p = int.Parse(Console.ReadLine());

            if (p == 1)
            {
                int num;
                Console.WriteLine("Please enter any number:-");
                num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("the number is one");
                }
                else if (num == 2)
                {
                    Console.WriteLine("the number is two");
                }
                else if (num == 3)
                {
                    Console.WriteLine("the number is three");
                }
                else
                {
                    Console.WriteLine("Enter number between 1 to 3");
                }
            }
            else if (p == 2)
            {
                int i = 1;
                while (i <= 5)

                {
                    Console.WriteLine("Hello World");
                    i++;
                }
            }
            else if(p==3)
            {
                int per, sub1, sub2, sub3;
                Console.WriteLine("Please Enter your marks for subject1:-");
                sub1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your marks for Subject2:-");
                sub2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your marks for Subject3:-");
                sub3 = int.Parse(Console.ReadLine());

                per = (sub1 + sub2 + sub3) / 3;

                Console.WriteLine("your percentage is " + per);
            }
            else
            {
                Console.WriteLine("Thanks for your visit");
            }
        }
    }
}
