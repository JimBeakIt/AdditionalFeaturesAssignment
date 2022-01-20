using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeaturesAssignment
{
    public class mySampleClass
    {
        
      public mySampleClass()
        {
            Console.WriteLine("6");
        }
        
        public mySampleClass(int x): this()
        {
            Console.WriteLine("James");
        }

        public mySampleClass (int x, string y): this(10)
        {
            Console.WriteLine("3");
        }
        
        

    }
}
