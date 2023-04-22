using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPExample
{
    public class Youtuber : Creator
    {
        public override void Create()
        {
            if (base.CreativityLevel >= 50 && base.EnergyLevel >= 50)
            {
                this.BrainstormVideoIdeas();
                this.CreateScript();
                this.VideotapeScript();
                this.EditingVideo();
                this.RenderingVideo();               
            }
            else
            {
                throw new Exception("Cannot create a video");
            }

        }

        private void BrainstormVideoIdeas()
        {
            base.CreativityLevel -= 5;
            base.EnergyLevel -= 5;
            Console.WriteLine("Brainstorming video ideas");
        }

        private void CreateScript()
        {
            base.CreativityLevel -= 5;
            base.EnergyLevel -= 5;
            Console.WriteLine("Create a video script");
        }

        private void VideotapeScript()
        {
            base.CreativityLevel -= 1;
            base.EnergyLevel -= 10;
            Console.WriteLine("Executing script");
        }

        private void EditingVideo()
        {
            base.CreativityLevel -= 5;
            base.EnergyLevel -= 5;
            Console.WriteLine("Editing video");
        }

        private void RenderingVideo()
        {
            base.CreativityLevel -= 1;
            base.EnergyLevel -= 1;
            Console.WriteLine("Rendering video");
        }
    }
}

