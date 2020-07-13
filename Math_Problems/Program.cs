using System;

namespace Math_Problems
{
    class Program
    {

        static Logic logic = new Logic();
        static User_Interfejs ui = new User_Interfejs();

        static string menuView = "\tMath Problems\n------------------------------\n1. START\n2. LEVELS\n3. RESTART\n4. EXIT\nPICK ACTION: ";
        static string question = "2+2*2=?\npodaj odpowiedz\nwpiz b by wrocic do menu";
        static string progress = "zad 1 R\nzad 2 W\nzad 3\n wybierz poziom: \nwpisz b by wrocic do menu\n";
        static string answare;

        enum state
        {
            Menu,
            Question,
            Level,
            Exit
        };

        static void Main(string[] args)
        {

            state st = state.Menu;

            while (st != state.Exit)
            {

                if (st == state.Menu)
                {
                    Console.WriteLine(menuView);
                }
                // Dopisz elsy

                answare = Console.ReadLine();

                if (st == state.Menu)
                {
                    if (answare.Equals("1"))
                    {
                        st = state.Question;
                    }
                }

            }
            /*
            Boolean END_PROGRAM = false;
            while (!END_PROGRAM)
            {

                answare = ui.view_and_get(currentView);
               //currentView = logic.process(answare);


            }

                string welcomeView = "\tMath Problems\n------------------------------\n1. START\n2. LEVELS\n3. RESTART\n4. EXIT\nPICK ACTION: ";
            string zadanie_ONE = "2 + 2 * 2 = ?\nPodaj odpowiedź:\n";

            while (!END_PROGRAM)
            {
                Console.WriteLine(welcomeView);

                string userOption = Console.ReadLine();


                if (userOption.Equals("1"))
                {
                    Console.WriteLine(zadanie_ONE);
                    string ANSWER = Console.ReadLine();
                    if (ANSWER.Equals("6"))
                    {
                        Console.WriteLine("BRAWO!");
                    }
                    else
                    {
                        Console.WriteLine("ZŁA ODPOWIEDŹ ");
                    }
                }
                else if (userOption.Equals("2"))
                {
                    Console.WriteLine("Wybrałeś drugą opcję");
                }
                else if (userOption.Equals("3"))
                {
                    Console.WriteLine("Wybrałeś trzecią opcję");
                }
                else if (userOption.Equals("4"))
                {
                    Console.WriteLine("Wybrałeś czwartą opcję");
                    END_PROGRAM = true;
                }
                else
                {
                    Console.WriteLine("Wybrałeś złą opcję, proszę wybrać numery 1-4");
                }
            }

            */
        }
       
    }
}
