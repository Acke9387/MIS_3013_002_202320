using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Cereal
{
    public class Cereal
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Calories { get; set; }
        public double Cups { get; set; }


        public Cereal()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Calories = 0;
            Cups = 0;
        }

        public Cereal(string name) : this()
        {
            Manufacturer = string.Empty;
            Calories = 0;
            Cups = 0;
            Name = name;
        }

        public Cereal(string manu, string name, double cups, double calories)
        {
            Manufacturer = manu;
            Name = name;
            Cups = cups;
            Calories = calories;
        }

        public override string ToString()
        {
            return $"{Name} made by {Manufacturer} has {Calories.ToString("N")} calories per {Cups.ToString("N")} cup(s)";


        }

    }
}
