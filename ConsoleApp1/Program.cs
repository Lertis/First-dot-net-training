using System;
using System.Collections.Generic;
using ConsoleCat;
using ConsoleDigits;

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

            Cat cat = new Cat("Red");
            Console.WriteLine(cat);

            Digits digits = new Digits();
            List<int> list = digits.GetDigitsByLength(15);
            list.ForEach(i => Console.Write("{0}\t", i));
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
