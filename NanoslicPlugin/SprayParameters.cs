using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugins
{   
    enum Quadrant { first, second, third, fourth };
    class SprayParameters
    {
        public double x, y, z, passSpacing;
        public int numCoats, spraySpeed, overSpray;
        public Quadrant quadrant;

        // default constructor
        public SprayParameters() { }

        // real constructor
        public SprayParameters(double x, double y, double z, object overSpray, object passSpacing, object numCoats, object spraySpeed)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.overSpray = (int) overSpray;
            this.passSpacing = (double) passSpacing;
            this.numCoats = (int) numCoats;
            this.spraySpeed = (int) spraySpeed;
            this.quadrant = x < 0 ? (y < 0 ? Quadrant.third : Quadrant.second) : (y < 0 ? Quadrant.fourth : Quadrant.first);
        }
    }
}