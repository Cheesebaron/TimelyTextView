using System;
using System.Collections.Generic;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model.Number;

namespace DK.Ostebaronen.Droid.TimelyTextView.Model
{
    public class NumberUtils
    {
        public static IList<Point> GetControlPointsFor(int start)
        {
            switch (start)
            {
                case -1:
                    return Null.Instance.ControlPoints;
                case 0:
                    return Zero.Instance.ControlPoints;
                case 1:
                    return One.Instance.ControlPoints;
                case 2:
                    return Two.Instance.ControlPoints;
                case 3:
                    return Three.Instance.ControlPoints;
                case 4:
                    return Four.Instance.ControlPoints;
                case 5:
                    return Five.Instance.ControlPoints;
                case 6:
                    return Six.Instance.ControlPoints;
                case 7:
                    return Seven.Instance.ControlPoints;
                case 8:
                    return Eight.Instance.ControlPoints;
                case 9:
                    return Nine.Instance.ControlPoints;
                default:
                    throw new ArgumentOutOfRangeException("start", "Values between -1 and 9 are supported");
            }
        }
    }
}