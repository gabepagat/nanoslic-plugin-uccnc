using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plugins
{   
    class SprayParameters
    {
        public double x1, y1, x2, y2, passSpacing;
        public int numCoats, spraySpeed, overSpray;

        // real constructor
        public SprayParameters(double x1, double y1, double x2, double y2, object overSpray, object passSpacing, object numCoats, object spraySpeed)
        {
            this.overSpray = (int) overSpray;
            this.passSpacing = (double) passSpacing;
            this.numCoats = (int) numCoats;
            this.spraySpeed = (int) spraySpeed;

            this.x1 = x1 - this.overSpray;
            this.y1 = y1 - this.overSpray;
            this.x2 = x2 + this.overSpray;
            this.y2 = y2 + this.overSpray;
        }
    }
}