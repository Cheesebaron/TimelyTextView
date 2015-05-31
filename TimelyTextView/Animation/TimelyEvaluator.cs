using Android.Animation;
using Object = Java.Lang.Object;

namespace DK.Ostebaronen.Droid.TimelyTextView.Animation
{
    public class Point : Object
    {
        public float X { get; set; }
        public float Y { get; set; }
    }

    public class TimelyEvaluator : Object, ITypeEvaluator
    {
        private Point[] _cachedPoints;

        public Object Evaluate(float fraction, Object startValue, Object endValue)
        {
            var start = startValue.ToArray<Point>();
            var end = endValue.ToArray<Point>();

            var pointsCount = start.Length;
            InitCache(pointsCount);

            for (var i = 0; i < pointsCount; i++)
            {
                var cachedPoint = _cachedPoints[i] ?? new Point();

                var startPoint = start[i];
                var endPoint = end[i];

                cachedPoint.X = startPoint.X + fraction * (endPoint.X - startPoint.X);
                cachedPoint.Y = startPoint.Y + fraction * (endPoint.Y - startPoint.Y);

                //_cachedPoints[i, 0] = start[i, 0] + fraction * (end[i, 0] - start[i, 0]);
                //_cachedPoints[i, 1] = start[i, 1] + fraction * (end[i, 1] - start[i, 1]);

                _cachedPoints[i] = cachedPoint;
            }

            return _cachedPoints;
        }

        private void InitCache(int pointsCount)
        {
            if (_cachedPoints == null || _cachedPoints.Length != pointsCount)
                _cachedPoints = new Point[pointsCount];
        }
    }
}