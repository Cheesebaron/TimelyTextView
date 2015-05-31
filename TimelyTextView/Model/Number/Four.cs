using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class Four : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.856353591160221f, Y = 0.806629834254144f},
            new Point { X = 0.856353591160221f, Y = 0.806629834254144f},
            new Point { X = 0.237569060773481f, Y = 0.806629834254144f},
            new Point { X = 0.237569060773481f, Y = 0.806629834254144f},
            new Point { X = 0.237569060773481f, Y = 0.806629834254144f},
            new Point { X = 0.712707182320442f, Y = 0.138121546961326f},
            new Point { X = 0.712707182320442f, Y = 0.138121546961326f},
            new Point { X = 0.712707182320442f, Y = 0.138121546961326f},
            new Point { X = 0.712707182320442f, Y = 0.806629834254144f},
            new Point { X = 0.712707182320442f, Y = 0.806629834254144f},
            new Point { X = 0.712707182320442f, Y = 0.806629834254144f},
            new Point { X = 0.712707182320442f, Y = 0.988950276243094f},
            new Point { X = 0.712707182320442f, Y = 0.988950276243094f}
        };

        private static readonly Four _instance = new Four();

        public static Four Instance { get { return _instance; } }

        protected Four()
            : base(Points) { }
    }
}