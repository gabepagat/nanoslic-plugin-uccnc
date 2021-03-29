using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugins
{   
    class SprayParameters
    {
        public double x1, y1, z1, x2, y2, z2, passSpacing;
        public int numCoats, spraySpeed, overSpray;

        // default constructor
        public SprayParameters() { }

        // real constructor
        public SprayParameters(double x1, double y1, double z1, double x2, double y2, double z2, object overSpray, object passSpacing, object numCoats, object spraySpeed)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.z1 = z1;
            this.x2 = x2;
            this.y2 = y2;
            this.z2 = z2;
            this.overSpray = (int) overSpray;
            this.passSpacing = (double) passSpacing;
            this.numCoats = (int) numCoats;
            this.spraySpeed = (int) spraySpeed;
        }
    }
}