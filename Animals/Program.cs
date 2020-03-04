using System;
using Animals.Reptiles;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var americanAlligator = new Alligator(6000);
            americanAlligator.isAquatic = true;

            var fictionalAlligator = new Alligator(200);
            fictionalAlligator.isAquatic = false;

            americanAlligator.Grunt();
            fictionalAlligator.Grunt();

            americanAlligator.Run(80);
            fictionalAlligator.Run(500);
            americanAlligator.Run(5930);
        }
    }
}
