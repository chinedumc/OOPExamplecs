using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExample
{
    public class Programmer : Creator
    {
        public override void Create()
        {
            if(base.CreativityLevel >=70 && base.EnergyLevel >= 80)
            {
                this.BrainstormSolution();
                this.PickMostOptimalSolution();
                this.WriteCode();
                this.TestCode();
            }
            else
            {
                throw new Exception("Cannot create a programme");
            }

        }

        private void BrainstormSolution()
        {
            base.CreativityLevel -= 15;
            base.EnergyLevel -= 10;
            Console.WriteLine("Brainstorming solutions");
        }

        private void PickMostOptimalSolution()
        {
            base.CreativityLevel -= 5;
            base.EnergyLevel -= 5;
            Console.WriteLine("Picking most optimal solutions");
        }

        private void WriteCode()
        {
            base.CreativityLevel -= 7;
            base.EnergyLevel -= 5;
            Console.WriteLine("Writing code");
        }

        private void TestCode()
        {
            base.CreativityLevel -= 3;
            base.EnergyLevel -= 3;
            Console.WriteLine("Testing code");
        }
    }
}
