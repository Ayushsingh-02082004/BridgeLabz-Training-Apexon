using C_BasicConcepts.ConditionalStatements;
using C_BasicConcepts.DataType;
using C_BasicConcepts.DataTypes;
using C_BasicConcepts.Loops;
using System.Diagnostics;

namespace C_BasicConcepts
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            //Datatypes dt=new Datatypes();
            //dt.data();

            //CoinsProblem cp = new CoinsProblem();
            //int flips = int.Parse(Console.ReadLine());
            //cp.CP(flips);


            //PowerOf2 sq = new PowerOf2();
            //int x = int.Parse(Console.ReadLine());
            //sq.power2(x);

            //leapyear leyr = new leapyear();
            //int year = int.Parse(Console.ReadLine());
            //leyr.ly(year);

            //harmonicnumber hm = new harmonicnumber();
            //int n = int.Parse(Console.ReadLine());
            //hm.hrno(n);

            //factors fc = new factors();
            //int n = int.Parse(Console.ReadLine());
            //fc.fact(n);

            //QuotientandRemainder qr = new QuotientandRemainder();
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //qr.QandR(x, y);

            //swaptwonumber sp = new swaptwonumber();
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //sp.swap(x, y);

            //oddeven odev = new oddeven();
            //int num = int.Parse(Console.ReadLine());
            //odev.oe(num);

            //vovelConsonent vc = new vovelConsonent();
            //char ch = Convert.ToChar(Console.ReadLine());
            //vc.VovelorConsonent(ch);

            //maxofthreenumber m3 = new maxofthreenumber();
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());
            //m3.mthree(x, y, z);

            //Fibo fibo = new Fibo();
            //int x = int.Parse(Console.ReadLine());
            //fibo.fibonacci(x);

            //PerfectNumber pf = new PerfectNumber();
            //int num = int.Parse(Console.ReadLine());
            //pf.perfectnum(num);

            //PrimeNumber prno = new PrimeNumber();
            //int num = int.Parse(Console.ReadLine());
            //prno.primenum(num);

            //Reverse rev = new Reverse();
            //int nm = int.Parse(Console.ReadLine());
            //rev.reversenum(nm);

            //CountRandom Coupon = new CountRandom();
            //Console.WriteLine("enter a number");
            //int n = int.Parse(Console.ReadLine());
            //Coupon.CouponsNumber(n);

            //myStopWatch time = new myStopWatch();
            //time.stwatch();

            //Console.WriteLine("Enter the students grade :");
            //StudentScore SC = new StudentScore();
            //int SCORE = int.Parse(Console.ReadLine());
            //SC.score(SCORE);

            celsiusFahrenheit changtemp = new celsiusFahrenheit();
            Console.WriteLine("Enter 0 for celsius or  1 for Fahrenheit  ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the temperature");
            int temp = int.Parse(Console.ReadLine());
            changtemp.changetemperature(x, temp);

        }
    }
}
