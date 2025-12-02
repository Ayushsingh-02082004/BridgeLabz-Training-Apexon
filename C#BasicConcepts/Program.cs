using C_BasicConcepts.ConditionalStatements;
using C_BasicConcepts.DataType;
using C_BasicConcepts.Loops;

namespace C_BasicConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Datatypes dt=new Datatypes();
            //dt.data();

            //CoinsProblem cp = new CoinsProblem();
            //int flips = int.Parse(Console.ReadLine());
            //cp.CP(flips);


            PowerOf2 sq = new PowerOf2();
            int x = int.Parse(Console.ReadLine());
            sq.power2(x);

        }
    }
}
