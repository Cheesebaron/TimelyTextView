using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model.Core
{
    public abstract class Figure
    {
        public const int NoValue = -1;

        protected int PointsCount { get; set; }

        public IList<Point> ControlPoints { get; set; }

        protected Figure(IList<Point> controlPoints)
        {
            ControlPoints = controlPoints;
            PointsCount = (controlPoints.Count + 2) / 3;
        }
    }
}