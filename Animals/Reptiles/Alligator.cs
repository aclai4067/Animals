using System;
using System.Collections.Generic;
using System.Text;

namespace Animals.Reptiles
{
    internal class Alligator
    {
        public bool isAquatic { get; set; }
        private int _stepGoal;
        private int _stepCount;

        public Alligator(int stepGoal)
        {
            isAquatic = true;
            _stepGoal = stepGoal;
        }

        public void Grunt()
        {
            if (isAquatic)
            {
                Console.WriteLine("GRRRRRR!");
            }
            else
            {
                Console.WriteLine("hiss");
            }
        }

        public void Run(int steps)
        {
            _stepCount += steps;

            Console.WriteLine($"You took {steps} steps");

            if (_stepCount >= _stepGoal)
            {
                Console.WriteLine($"Congrats!  You met your goal!");
            }
            Console.ReadKey();
        }
    }
}
