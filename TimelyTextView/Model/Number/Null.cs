using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Null : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f},
            new Point { X = 0.5f, Y = 0.5f}
        };

        private static readonly Null _instance = new Null();

        public static Null Instance { get { return _instance; } }

        protected Null()
            : base(Points) { }
    }
}