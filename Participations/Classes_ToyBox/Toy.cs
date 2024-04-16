using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ToyBox
{
    public class Toy
    {

        public string Manufacturer { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        private string Notes;

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Toy()
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = string.Empty;
        }

        public Toy(string name, string manu, double price, string note)
        {
            Manufacturer = manu;
            Name = name;
            Price = price;
            Notes = note;
        }

        public Toy(string note)
        {
            Manufacturer = string.Empty;
            Name = string.Empty;
            Price = 0;
            Notes = note;
        }

        public void SetNotes(string Notes)
        {
            if (Notes.Length < 5)
            {

            }
            else
            {
                this.Notes = Notes;
            }
        }

        public string GetNotes()
        {
            return this.Notes;
        }

        public string GetAisle()
        {
            string aisle = string.Empty;
            Random r = new Random();
            aisle = Manufacturer.ToUpper()[0].ToString() + r.Next(1, 25);

            return aisle;
        }


        public override string ToString()
        {
            return $"{Name} is made by {Manufacturer} and sells for {Price.ToString("C")}.\n{GetNotes()}";

            return "Banana";
            return base.ToString();
        }

    }

}
