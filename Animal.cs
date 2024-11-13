using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NC_Safari
{
    public abstract class Animal
    {
        public float WeightInKg;
        public Animal(float weight)
            { 
        this.WeightInKg = weight;}
        abstract public void MakeSound();
        
       
}
            
    }

