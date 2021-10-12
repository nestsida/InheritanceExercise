using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
     {
       public Bird()
        {

        }
       public int Wings { get; set; }
       public bool AbleToFly { get; set; }
       public string Colour { get; set; }
       public string Country { get; set; }

      }
  
}
