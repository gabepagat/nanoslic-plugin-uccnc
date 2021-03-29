using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugins
{
    class SprayParameters
    {
        public double x, y, z, overSpray, passSpacing;
        public int numRepeats, spraySpeed;

        // default constructor
        public SprayParameters() { }

        // real constructor
        public SprayParameters(double x, double y, double z, double overSpray, double passSpacing, int numRepeats, int spraySpeed)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.overSpray = overSpray;
            this.passSpacing = passSpacing;
            this.numRepeats = numRepeats;
            this.spraySpeed = spraySpeed;
        }
    }
}
