using System;
using System.Collections.Generic;
using System.Text;

namespace Structural
{
    //Proxy pattern means : use a middle object (proxy) to control access to a real object.'
        //Real-Life Example(Easiest) 🛂
        //Security Guard

        //You want to enter a building

        //You don’t go directly inside

        //A security guard checks your ID

        //If allowed → you can enter

        //👉 Security guard = Proxy
        //👉 Building = Real object

    interface IDatabase
    {
        void Access();
    }

    class RealDataBase: IDatabase
    {
        public void Access()
        {
            Console.WriteLine("Accessing REal DataBAse");
        }
    }

    class DatabaseProxy : IDatabase
    {
        private RealDataBase realDatabase;
        private bool isAdmin;

        public DatabaseProxy(bool isAdmin)
        {
            this.isAdmin = isAdmin;
        }

        public void Access()
        {
            if (isAdmin)
            {
                if (realDatabase == null)
                    realDatabase = new RealDatabase();

                realDatabase.Access();
            }
            else
            {
                Console.WriteLine("Access denied!");
            }
        }

        //static void Main()  //client code
        //{
        //    IDatabase db1 = new DatabaseProxy(true);
        //    db1.Access();

        //    IDatabase db2 = new DatabaseProxy(false);
        //    db2.Access();
        //}
    }
}
