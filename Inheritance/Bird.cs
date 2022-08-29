using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            IsAlive = true;
            Legs = 2;
            LandSeaAir = "Air";
            Age = 0;
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool Migrate { get; set; }
        public double BeakLength { get; set; }

    }
}
