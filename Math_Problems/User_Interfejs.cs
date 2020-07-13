using System;
using System.Collections.Generic;
using System.Text;

namespace Math_Problems
{
    class User_Interfejs
    {

        public string view_and_get(string view)
        {
            Console.WriteLine(view);
            string userOption = Console.ReadLine();
            return userOption;
        }
    }
}
