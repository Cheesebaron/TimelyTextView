using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Three : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.361878453038674f, Y = 0.298342541436464f},
            new Point { X = 0.348066298342541f, Y = 0.149171270718232f},
            new Point { X = 0.475138121546961f, Y = 0.0994475138121547f},
            new Point { X = 0.549723756906077f, Y = 0.0994475138121547f},
            new Point { X = 0.861878453038674f, Y = 0.0994475138121547f},
            new Point { X = 0.806629834254144f, Y = 0.530386740331492f},
            new Point { X = 0.549723756906077f, Y = 0.530386740331492f},
            new Point { X = 0.87292817679558f, Y = 0.530386740331492f},
            new Point { X = 0.828729281767956f, Y = 0.994475138121547f},
            new Point { X = 0.552486187845304f, Y = 0.994475138121547f},
            new Point { X = 0.298342541436464f, Y = 0.994475138121547f},
            new Point { X = 0.30939226519337f, Y = 0.828729281767956f},
            new Point { X = 0.312154696132597f, Y = 0.790055248618785f}
        };

        private static readonly Three _instance = new Three();

        public static Three Instance { get { return _instance; } }

        protected Three()
            : base(Points) { }
    }
}