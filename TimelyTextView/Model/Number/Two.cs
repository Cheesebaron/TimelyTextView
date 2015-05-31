using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Two : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.30939226519337f, Y = 0.331491712707182f},
            new Point { X = 0.325966850828729f, Y = 0.0110497237569061f},
            new Point { X = 0.790055248618785f, Y = 0.0220994475138122f},
            new Point { X = 0.798342541436464f, Y = 0.337016574585635f},
            new Point { X = 0.798342541436464f, Y = 0.430939226519337f},
            new Point { X = 0.718232044198895f, Y = 0.541436464088398f},
            new Point { X = 0.596685082872928f, Y = 0.674033149171271f},
            new Point { X = 0.519337016574586f, Y = 0.762430939226519f},
            new Point { X = 0.408839779005525f, Y = 0.856353591160221f},
            new Point { X = 0.314917127071823f, Y = 0.977900552486188f},
            new Point { X = 0.314917127071823f, Y = 0.977900552486188f},
            new Point { X = 0.812154696132597f, Y = 0.977900552486188f},
            new Point { X = 0.812154696132597f, Y = 0.977900552486188f},
        };

        private static readonly Two _instance = new Two();

        public static Two Instance { get { return _instance; } }

        protected Two()
            : base(Points) { }
    }
}