using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Six : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.607734806629834f, Y = 0.110497237569061f},
            new Point { X = 0.607734806629834f, Y = 0.110497237569061f},
            new Point { X = 0.607734806629834f, Y = 0.110497237569061f},
            new Point { X = 0.607734806629834f, Y = 0.110497237569061f},
            new Point { X = 0.392265193370166f, Y = 0.43646408839779f},
            new Point { X = 0.265193370165746f, Y = 0.50828729281768f},
            new Point { X = 0.25414364640884f, Y = 0.696132596685083f},
            new Point { X = 0.287292817679558f, Y = 1.13017127071823f},
            new Point { X = 0.87292817679558f, Y = 1.06077348066298f},
            new Point { X = 0.845303867403315f, Y = 0.696132596685083f},
            new Point { X = 0.806629834254144f, Y = 0.364640883977901f},
            new Point { X = 0.419889502762431f, Y = 0.353591160220994f},
            new Point { X = 0.295580110497238f, Y = 0.552486187845304f}
        };

        private static readonly Six _instance = new Six();

        public static Six Instance { get { return _instance; } }

        protected Six()
            : base(Points) { }
    }
}