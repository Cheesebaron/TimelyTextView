using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Zero : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.24585635359116f, Y = 0.552486187845304f},
            new Point { X = 0.24585635359116f, Y = 0.331491712707182f},
            new Point { X = 0.370165745856354f, Y = 0.0994475138121547f},
            new Point { X = 0.552486187845304f, Y = 0.0994475138121547f},
            new Point { X = 0.734806629834254f, Y = 0.0994475138121547f},
            new Point { X = 0.861878453038674f, Y = 0.331491712707182f},
            new Point { X = 0.861878453038674f, Y = 0.552486187845304f},
            new Point { X = 0.861878453038674f, Y = 0.773480662983425f},
            new Point { X = 0.734806629834254f, Y = 0.994475138121547f},
            new Point { X = 0.552486187845304f, Y = 0.994475138121547f},
            new Point { X = 0.370165745856354f, Y = 0.994475138121547f},
            new Point { X = 0.24585635359116f, Y = 0.773480662983425f},
            new Point { X = 0.24585635359116f, Y = 0.552486187845304f}
        };

        private static readonly Zero _instance = new Zero();

        public static Zero Instance { get { return _instance; } }

        protected Zero()
            : base(Points) { }
    }
}