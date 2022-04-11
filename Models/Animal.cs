using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Animal
    {
        protected char eye;
        protected int eyeColor;
        protected int color;
        protected string name;

        public Animal(string catName, char catEye = '0', int catEyeColor = 10, int catColor = 5)
        {
            this.eye = catEye;
            this.eyeColor = catEyeColor;
            this.color = catColor;
            this.name = catName;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Render()
        {
            Console.WriteLine("I'm an animal");
        }
    }
}
