using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program

    {
        static void Great(string name)
        {
            Console.Write("good morning"+name);
        }

        static float Average(int a, int b)
        {
            return (a + b) / 2;
        }
        static float Average(int a, int b, int c)
        {
            float sum = a + b + c;
            return sum / 3;
        }
        static void Main(string[] args)
        {
            //Operators in c#
            /*int a = Math.Max(32, 23);
            Console.WriteLine(a);
            Console.ReadLine();
            */

            /*   String hello = "how are you";
               Console.WriteLine(hello);
               Console.WriteLine(hello.ToUpper());
               Console.ReadLine();
            */

            //String name = Console.ReadLine();
            //String candies = Console.ReadLine();
            //Console.WriteLine($"your name is {name}. your have {candies}");
            //Console.ReadLine();

            //Console.WriteLine("enter your age");
            //String ageStr = Console.ReadLine();
            //int age = Convert.ToInt32(ageStr);
            //bool isBanned = true;

            //if(age<2 || isBanned)
            //{
            //    Console.WriteLine("you cannot drive you are banned");

            //}
            //    else if (age < 10)
            //{
            //    Console.WriteLine("finish your school");
            //}
            //    else if (age > 60)
            //{
            //    Console.WriteLine("renew your liscence");
            //}
            //else
            //{
            //    Console.WriteLine("you can drive");
            //}
            //Console.ReadLine();

            //int age = 30;
            //switch(age)
            //{
            //    case 18:
            //        Console.WriteLine("na");
            //        break;
            //    case 30:
            //        Console.WriteLine("enjoy");
            //        break;
            //    default:
            //        Console.WriteLine("hahha");
            //        break;
            //}
            //Console.ReadLine();


            //int i = 0;
            //while(i <10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();


            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i + 1);
            //    i++;
            //}
            //while (i<5)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //for (int i = 0; i < 5; i++)
            //{
            //    if (i == 0)
            //    {
            //        continue;
            //    }

            //    Console.WriteLine(i + 1);
            //}
            //Console.ReadLine();

            ////break and continue
            //Console.WriteLine(Average(3, 3, 5));
            //Great("miraj");
            //Console.WriteLine(Average(12,23));
            //Console.ReadLine();


            Player tommy = new Player();
            Console.WriteLine(tommy.getHealth());
          
            tommy.setHealth(100);
            Console.WriteLine(tommy.getHealth());
            Console.ReadLine();
        }
    }
}
