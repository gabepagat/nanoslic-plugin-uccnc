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
        public String correctionMessage = "";

        // real constructor
        public SprayParameters(double x1, double y1, double x2, double y2, object overSpray, object passSpacing, object numCoats, object spraySpeed)
        {
            this.overSpray = (int) overSpray;
            this.passSpacing = (double) passSpacing;
            this.numCoats = (int) numCoats;
            this.spraySpeed = (int) spraySpeed;

            double trueOverspray = Math.Floor(this.overSpray / this.passSpacing) * this.passSpacing;

            if (trueOverspray != this.overSpray)
            {
                this.correctionMessage = String.Format("Overspray amount corrected to {0:F} due to pass spacing of {1:F} mm.", trueOverspray, this.passSpacing);
            }

            this.x1 = x1 - trueOverspray;
            this.y1 = y1 - trueOverspray;
            this.x2 = x2 + trueOverspray;
            this.y2 = y2 + trueOverspray;
        }
    }
}