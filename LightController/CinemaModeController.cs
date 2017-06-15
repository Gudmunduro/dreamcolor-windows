using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightController
{
    class CinemaModeController
    {
        Light light;
        private bool cinemaModeEnabled = false;
        private bool lightEnabled = false;

        public CinemaModeController(Light light)
        {
            this.light = light;
        }

        public void disableWithoutChange()
        {
            cinemaModeEnabled = false;
        }

        public bool enabled
        {
            get { return cinemaModeEnabled; }
            set
            {
                cinemaModeEnabled = value;
                if (cinemaModeEnabled)
                {
                    light.dim(0);
                }
                else
                {
                    light.dim(10);
                }

            }
        }

        public bool lightOn
        {
            get { return lightEnabled; }
            set
            {
                lightEnabled = value;
                if (lightEnabled)
                {
                    light.rgb(0, 0, 255);
                }
                else
                {
                    light.dim(0);
                }
            }
        }
    }
}
