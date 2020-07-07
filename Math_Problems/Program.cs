using System;

namespace Math_Problems
{
    class Program
    {
        static void Main(string[] args)
        {
            string welcomeView = "\tMath Problems\n------------------------------\n1. START\n2. LEVELS\n3. RESTART\n4. EXIT\nPICK ACTION: ";
            Console.WriteLine(welcomeView);

            string userOption = Console.ReadLine();


            if (userOption.Equals("1"))
            {
                Console.WriteLine("Wybrałeś start");
            }
            else if(userOption.Equals("2"))
            {
                Console.WriteLine("Wybrałeś drugą opcję");
            }
            else if(userOption.Equals("3"))
            {
                Console.WriteLine("Wybrałeś trzecią opcję");
            }
            else if (userOption.Equals("4"))
            {
                Console.WriteLine("Wybrałeś czwartą opcję");
            }
            else
            {
                Console.WriteLine("Wybrałeś złą opcję, proszę wybrać numery 1-4");
            }
          


        }
    }
}
