﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBRE.Settings
{
    public class LightmapConfig
    {
        public static float DownscaleFactor { get; set; }
        public static int PlaneMargin { get; set; }
        public static int TextureDims { get; set; }
        public static int BlurRadius { get; set; }

        public static int AmbientColorR { get; set; }
        public static int AmbientColorG { get; set; }
        public static int AmbientColorB { get; set; }

        public static float AmbientNormalX { get; set; }
        public static float AmbientNormalY { get; set; }
        public static float AmbientNormalZ { get; set; }

        static LightmapConfig()
        {
            DownscaleFactor = 10;
            PlaneMargin = 1;
            TextureDims = 2048;
            BlurRadius = 2;

            AmbientColorR = 30;
            AmbientColorG = 30;
            AmbientColorB = 30;

            AmbientNormalX = 1.0f;
            AmbientNormalY = 2.0f;
            AmbientNormalZ = 3.0f;
        }
    }
}
