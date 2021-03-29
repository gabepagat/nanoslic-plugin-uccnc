using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugins
{
    class SprayParameters
    {
        public double x, y, z, passSpacing;
        public int numRepeats, spraySpeed, overSpray;

        // default constructor
        public SprayParameters() { }

        // real constructor
        public SprayParameters(double x, double y, double z, object overSpray, object passSpacing, object numRepeats, object spraySpeed)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.overSpray = (int) overSpray;
            this.passSpacing = (double) passSpacing;
            this.numRepeats = (int) numRepeats;
            this.spraySpeed = (int) spraySpeed;
        }
    }
}