using System;

namespace CompositionInterfaces
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Penguin oldPenguin = new Penguin();
            PrintSwim(oldPenguin);
            PrintWalker(oldPenguin);
        }

        public static void PrintSwim(IWalker walk)
        {
            walk.Walk();
        }

        public static void PrintWalker(ISwimmer swimmer)
        {
            swimmer.Swim();

        }

    }
}
