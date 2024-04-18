using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_ToyBox
{
    public class ToyBox
    {

        public List<Toy> Toys { get; set; }
        public string Owner { get; set; }

        public string Location { get; set; }


        public ToyBox()
        {
            Toys = new List<Toy>();
            Owner = string.Empty;
            Location = string.Empty;
        }

        public Toy GetRandomToy()
        {
            Random r = new Random();
            int index = r.Next(0, Toys.Count);

            return Toys[index];
        }

    }
}
