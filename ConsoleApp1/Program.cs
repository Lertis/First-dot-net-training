using System;

namespace ConsoleApplication
{

    class InnerClass
    {
        static void Main()
        {
            Lion lion = new Lion();
            lion.LionVoice();

            Bear bear = new Bear();
            bear.BearVoice();
            bear.Voice();
        }
    }

    abstract class Animal
    {
        public virtual void Voice()
        {
            Console.WriteLine("VOICE");
        }
    }

    class Lion
    {
        public void LionVoice()
        {
            Console.WriteLine("LION VOICE");
        }

        ~Lion()
        {
            Console.WriteLine("Lion class destructor has been called.");
        }
    }

    class Bear: Animal
    {
        public void BearVoice()
        {
            Console.WriteLine("BEAR VOICE");
        }

        public override void Voice()
        {
            Console.WriteLine("VOICE??");
        }
    }
}
