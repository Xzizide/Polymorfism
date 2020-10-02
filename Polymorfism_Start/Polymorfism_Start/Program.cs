using System;

namespace Polymorfism_Start
{
    class Aliens //basklassen
    {
        virtual public void alienSound()
        {
            Console.WriteLine("Alien say WOOOOOOO");
        }
    }

    class Marsian : Aliens //klass som ärver från basklassen
    {
        override public void alienSound()
        {
            Console.WriteLine("Marsian say Skrrrt");
        }
    }
    class Earthean : Aliens //klass som ärver från basklassen
    {
        override public void alienSound()
        {
            Console.WriteLine("Earhtean say Hello");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Aliens[] aliens = {new Earthean(), new Marsian(), new Aliens() }; //array med aliens

            foreach(var i in aliens)
            {
                i.alienSound(); //skriver ut olika alienSounds på grund av virtual och override funktioner
            }
        }
    }
}
