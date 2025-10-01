using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    namespace UserInput
    {
        internal class UserInput
        {
            public static string StringInput(string query)
            {
                Console.Write(query);
                string input = Console.ReadLine();

                return input;
            }
            
        }
    }
}
