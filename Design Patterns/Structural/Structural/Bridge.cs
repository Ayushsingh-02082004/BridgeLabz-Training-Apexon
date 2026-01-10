using System;
using System.Collections.Generic;
using System.Text;

namespace Structural
{
    //It builds a bridge between abstraction and implementation so both can change independently.

    //Real-Life Example(Easiest) 📺
    //TV Remote & TV

    //Remote = what you use(buttons: ON/OFF, Volume)

    //TV = how it works(Sony, Samsung, LG)

    //Same remote can control different TVs

    //👉 Remote = Abstraction
    //👉 TV = Implementation
    //👉 Connection = Bridge

    //Implementation INterface

    interface ITV
    {
        void On();
        void off();
    }

    //Concrete Implementation

    class SonyTV: ITV
    {
        public void On() => Console.WriteLine("Sony TV ON"):
        public void off() => Console.WriteLine("Sony TV OFF):

    }

    class SamsungTv : ITV
    {
        public void On() => Console.WriteLine("Samsung TV ON");
        public void Off() => Console.WriteLine("Samsung TV OFF");
    }

    //Abstraction
    abstract class RemoteControl
    {
        protected ITV tv;

        protected RemoteControl(ITV tv)
        {
            this.tv = tv;
        }

        public abstract void TurnOn();
        public abstract void TurnOff();
    }

    //REfined Abstraction
    class BasicRemote : RemoteControl
    {
        public BasicRemote(ITV tv) : base(tv) { }

        public override void TurnOn()
        {
            tv.On();
        }

        public override void TurnOff()
        {
            tv.Off();
        }
    }

    class Program
    {
        static void Main()
        {
            RemoteControl remote1 = new BasicRemote(new SonyTV());
            remote1.TurnOn();

            RemoteControl remote2 = new BasicRemote(new SamsungTV());
            remote2.TurnOff();
        }


        //What is happening?

        //Remote does not know TV details

        //TV does not know remote details

        //Both can change independently
        //    }



}