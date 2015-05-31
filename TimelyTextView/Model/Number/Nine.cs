using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Nine : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.80939226519337f, Y = 0.552486187845304f},
            new Point { X = 0.685082872928177f, Y = 0.751381215469613f},
            new Point { X = 0.298342541436464f, Y = 0.740331491712707f},
            new Point { X = 0.259668508287293f, Y = 0.408839779005525f},
            new Point { X = 0.232044198895028f, Y = 0.0441988950276243f},
            new Point { X = 0.81767955801105f, Y = -0.0441988950276243f},
            new Point { X = 0.850828729281768f, Y = 0.408839779005525f},
            new Point { X = 0.839779005524862f, Y = 0.596685082872928f},
            new Point { X = 0.712707182320442f, Y = 0.668508287292818f},
            new Point { X = 0.497237569060773f, Y = 0.994475138121547f},
            new Point { X = 0.497237569060773f, Y = 0.994475138121547f},
            new Point { X = 0.497237569060773f, Y = 0.994475138121547f},
            new Point { X = 0.497237569060773f, Y = 0.994475138121547f}
        };

        private static readonly Nine _instance = new Nine();

        public static Nine Instance { get { return _instance; } }

        protected Nine()
            : base(Points) { }
    }
}