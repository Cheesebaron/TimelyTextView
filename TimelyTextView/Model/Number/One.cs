using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Core;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Number
{
    public class One : Figure
    {
        public static List<Point> Points = new List<Point>
        {
            new Point { X = 0.425414364640884f, Y = 0.113259668508287f},
            new Point { X = 0.425414364640884f, Y = 0.113259668508287f},
            new Point { X = 0.577348066298343f, Y = 0.113259668508287f},
            new Point { X = 0.577348066298343f, Y = 0.113259668508287f},
            new Point { X = 0.577348066298343f, Y = 0.113259668508287f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f},
            new Point { X = 0.577348066298343f, Y = 1f}
        };

        private static readonly One _instance = new One();

        public static One Instance { get { return _instance; } }

        protected One()
            : base(Points) { }
    }
}