//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace oop.Abstraction
//{
//    //class Program
//    //{

//    //    //we are using abstract class and abstract methods to achieve the abstraction principle in C#. We can achieve 0 to 100%
//    //    //abstraction using the abstract class and abstract methods. 
//    //    static void Main(string[] args)
//    //    {
//    //        Console.WriteLine("Transaction doing SBI Bank");
//    //        IBank sbi = BankFactory.GetBankObject("SBI");
//    //        sbi.ValidateCard();
//    //        sbi.WithdrawMoney();
//    //        sbi.CheckBalanace();
//    //        sbi.BankTransfer();
//    //        sbi.MiniStatement();
//    //        Console.WriteLine("\nTransaction doing AXIX Bank");
//    //        IBank AXIX = BankFactory.GetBankObject("AXIX");
//    //        AXIX.ValidateCard();
//    //        AXIX.WithdrawMoney();
//    //        AXIX.CheckBalanace();
//    //        AXIX.BankTransfer();
//    //        AXIX.MiniStatement();
//    //        Console.Read();
//    //    }
//    //}
//    public abstract class IBank  //for abstract class we use abstract keyword 
//    {
//        public abstract void ValidateCard();   // for abstract methord also we use abstract keyword.
//        public abstract void WithdrawMoney();
//        public abstract void CheckBalanace();
//        public abstract void BankTransfer();
//        public abstract void MiniStatement();
//    }
//    public class BankFactory
//    {
//        public static IBank GetBankObject(string bankType)
//        {
//            IBank BankObject = null;
//            if (bankType == "SBI")
//            {
//                BankObject = new SBI();
//            }
//            else if (bankType == "AXIX")
//            {
//                BankObject = new AXIX();
//            }
//            return BankObject;
//        }
//    }
//    public class SBI : IBank
//    {
//        public override void BankTransfer()   // to use abstract class we have to use override key for overriding.
//        {
//            Console.WriteLine("SBI Bank Bank Transfer");
//        }
//        public override void CheckBalanace()
//        {
//            Console.WriteLine("SBI Bank Check Balanace");
//        }
//        public override void MiniStatement()
//        {
//            Console.WriteLine("SBI Bank Mini Statement");
//        }
//        public override void ValidateCard()
//        {
//            Console.WriteLine("SBI Bank Validate Card");
//        }
//        public override void WithdrawMoney()
//        {
//            Console.WriteLine("SBI Bank Withdraw Money");
//        }
//    }
//    public class AXIX : IBank
//    {
//        public override void BankTransfer()
//        {
//            Console.WriteLine("AXIX Bank Bank Transfer");
//        }
//        public override void CheckBalanace()
//        {
//            Console.WriteLine("AXIX Bank Check Balanace");
//        }
//        public override void MiniStatement()
//        {
//            Console.WriteLine("AXIX Bank Mini Statement");
//        }
//        public override void ValidateCard()
//        {
//            Console.WriteLine("AXIX Bank Validate Card");
//        }
//        public override void WithdrawMoney()
//        {
//            Console.WriteLine("AXIX Bank Withdraw Money");
//        }
//    }
//}
