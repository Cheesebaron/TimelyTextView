using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Five : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.806629834254144f, Y = 0.110497237569061f},
            new Point { X = 0.502762430939227f, Y = 0.110497237569061f},
            new Point { X = 0.502762430939227f, Y = 0.110497237569061f},
            new Point { X = 0.502762430939227f, Y = 0.110497237569061f},
            new Point { X = 0.397790055248619f, Y = 0.430939226519337f},
            new Point { X = 0.397790055248619f, Y = 0.430939226519337f},
            new Point { X = 0.397790055248619f, Y = 0.430939226519337f},
            new Point { X = 0.535911602209945f, Y = 0.364640883977901f},
            new Point { X = 0.801104972375691f, Y = 0.469613259668508f},
            new Point { X = 0.801104972375691f, Y = 0.712707182320442f},
            new Point { X = 0.773480662983425f, Y = 1.01104972375691f},
            new Point { X = 0.375690607734807f, Y = 1.0939226519337f},
            new Point { X = 0.248618784530387f, Y = 0.850828729281768f}
        };

        private static readonly Five _instance = new Five();

        public static Five Instance { get { return _instance; } }

        protected Five()
            : base(Points) { }
    }
}