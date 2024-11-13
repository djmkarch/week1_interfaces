using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Tiger : PantheraBigCat, IMove
    {public void Move()
        {
            Console.WriteLine("Tiger is moving!");
           

        }
        public Tiger(float weight):base(weight) { }
        //public override void MakeSound(){ }
    }
    
    
}
