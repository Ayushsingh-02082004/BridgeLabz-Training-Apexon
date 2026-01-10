using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern
{
    //Throughout the program, only ONE object of a Singleton class is created and that same object is shared among all parts of the program.

    class MusicPlayer
    {
        public static MusicPlayer instance;

        public MusicPlayer() { }

        public static MusicPlayer GetInstance()
        {
            if(instance == null)
            {
                instance = new MusicPlayer();
            }
            return instance;
        }

        public void Play()
        {
            Console.WriteLine("Music is Playing");
        }
    }

    class Program
    {
        //static void Main(string[] args)

        //{
        //    MusicPlayer player1 = MusicPlayer.GetInstance();
        //    MusicPlayer player2 = MusicPlayer.GetInstance();

        //    player1.Play();

        //    Console.WriteLine(player1 == player2);
        //}

        //What is happening internally?

        //First call → object is created

        //Second call → same object returned

        //No new object is created
    }
}
