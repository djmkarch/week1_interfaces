using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public abstract class PantheraBigCat: Mammal
    {public sealed override void MakeSound()
        {
            Console.WriteLine(this.GetType().Name + " roars!");
            
        }
        public PantheraBigCat(float weight):base(weight) { }
    }
}
