using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Eight : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.558011049723757f, Y = 0.530386740331492f},
            new Point { X = 0.243093922651934f, Y = 0.524861878453039f},
            new Point { X = 0.243093922651934f, Y = 0.104972375690608f},
            new Point { X = 0.558011049723757f, Y = 0.104972375690608f},
            new Point { X = 0.850828729281768f, Y = 0.104972375690608f},
            new Point { X = 0.850828729281768f, Y = 0.530386740331492f},
            new Point { X = 0.558011049723757f, Y = 0.530386740331492f},
            new Point { X = 0.243093922651934f, Y = 0.530386740331492f},
            new Point { X = 0.198895027624309f, Y = 0.988950276243094f},
            new Point { X = 0.558011049723757f, Y = 0.988950276243094f},
            new Point { X = 0.850828729281768f, Y = 0.988950276243094f},
            new Point { X = 0.850828729281768f, Y = 0.530386740331492f},
            new Point { X = 0.558011049723757f, Y = 0.530386740331492f}
        };

        private static readonly Eight _instance = new Eight();

        public static Eight Instance { get { return _instance; } }

        protected Eight()
            : base(Points) { }
    }
}