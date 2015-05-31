using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Seven : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.259668508287293f, Y = 0.116022099447514f},
            new Point { X = 0.259668508287293f, Y = 0.116022099447514f},
            new Point { X = 0.87292817679558f, Y = 0.116022099447514f},
            new Point { X = 0.87292817679558f, Y = 0.116022099447514f},
            new Point { X = 0.87292817679558f, Y = 0.116022099447514f},
            new Point { X = 0.7f, Y = 0.422099447513812f},
            new Point { X = 0.7f, Y = 0.422099447513812f},
            new Point { X = 0.7f, Y = 0.422099447513812f},
            new Point { X = 0.477348066298343f, Y = 0.733149171270718f},
            new Point { X = 0.477348066298343f, Y = 0.733149171270718f},
            new Point { X = 0.477348066298343f, Y = 0.733149171270718f},
            new Point { X = 0.25414364640884f, Y = 1f},
            new Point { X = 0.25414364640884f, Y = 1f}
        };

        private static readonly Seven _instance = new Seven();

        public static Seven Instance { get { return _instance; } }

        protected Seven()
            : base(Points) { }
    }
}