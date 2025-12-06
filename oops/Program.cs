using oops.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace oops
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            //implicit_constructor imp = new implicit_constructor();
            //Console.WriteLine($"{imp.num} {imp.flag} {imp.text}");
            //Console.WriteLine("hello");

            //parameterizedconstructor constructor = new parameterizedconstructor(10);
            //Console.ReadKey();

            //userdefinedDefaultConstructor ud = new userdefinedDefaultConstructor();
            //ud.Display();

            //copyconstructor cp = new copyconstructor(10);
            //cp.Display();
            //copyconstructor dp = new copyconstructor(cp);
            //dp.Display();

            staticConstructor obj = new staticConstructor();  // Triggers static ctor implicitly
            Console.WriteLine("Main method executed");

        }
    }
}
