using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicConcepts.ConditionalStatements
{
    internal class loginsystem
    {
        public void  login(String name, String passkey)
        {
            String uname = "Ayush";
            String Password = "Ayush@0346";
            if (uname.Length != name.Length)
            {
                Console.WriteLine("user Not Found");
            }
            if (passkey.Length != Password.Length)
            {
                Console.WriteLine("password not found");
            }

            for (int i = 0; i < uname.Length; i++)
            {
                if (uname[i] != name[i])
                {
                    Console.WriteLine("incorrect username");
                    return;
                }
            }

            for (int i = 0; i < uname.Length; i++)
            {
                if (Password[i] != passkey[i])
                {
                    Console.WriteLine("incorrect password");
                    return;
                }
            }

            Console.WriteLine("Successful Login");
        }
    }
}
