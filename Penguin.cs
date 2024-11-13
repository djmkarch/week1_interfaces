using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public class Penguin : Bird, IMove
    {
        public void Move()
        {
            Console.WriteLine("Penguin is moving!");

        }
        public Penguin(float weight) : base(weight) { }
        public override void MakeSound()
        {
            Console.WriteLine("sqwark!!");
        }
    }
}
