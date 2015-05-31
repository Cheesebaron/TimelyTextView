using System;
using System.Collections.Generic;
using System.Linq;
using Android.Animation;
using Android.Content;
using Android.Graphics;
using Android.Runtime;
using Android.Util;
using Android.Views;
using DK.Ostebaronen.Droid.TimelyTextView.Animation;
using DK.Ostebaronen.Droid.TimelyTextView.Model;
using Java.Lang;
using Object = Java.Lang.Object;
using Point = DK.Ostebaronen.Droid.TimelyTextView.Animation.Point;

namespace DK.Ostebaronen.Droid.TimelyTextView
{
    [Register("dk.ostebaronen.droid.timelytextview.TimelyView")]
    public class TimelyView : View
    {
        private const float Ratio = 1f;
        private Paint _paint;
        private Path _path;
        private IList<Point> _controlPoints;

        private static readonly TimelyViewProperty ControlPointsProperty =
            new TimelyViewProperty(Class.FromType(typeof(Object)), "ControlPoints");

        public IList<Point> ControlPoints
        {
            get { return _controlPoints; }
            set
            {
                _controlPoints = value;
                Invalidate();
            }
        }

        protected TimelyView(IntPtr javaReference, JniHandleOwnership transfer) 
            : base(javaReference, transfer) { }

        public TimelyView(Context context) 
            : this(context, null) { }

        public TimelyView(Context context, IAttributeSet attrs) 
            : this(context, attrs, 0) { }

        public TimelyView(Context context, IAttributeSet attrs, int defStyleAttr) 
            : base(context, attrs, defStyleAttr)
        {
            Init();
        }

        private void Init()
        {
            _paint = new Paint(PaintFlags.AntiAlias) {Color = Color.Black, StrokeWidth = 5.0f};
            _paint.SetStyle(Paint.Style.Stroke);
            _path = new Path();
        }

        public ObjectAnimator Animate(int start, int end)
        {
            var startPoints = NumberUtils.GetControlPointsFor(start).ToArray();
            var endPoints = NumberUtils.GetControlPointsFor(end).ToArray();

            return ObjectAnimator.OfObject(this, ControlPointsProperty, new TimelyEvaluator(), startPoints, endPoints);
        }

        public ObjectAnimator Animate(int end)
        {
            var startPoints = NumberUtils.GetControlPointsFor(-1).ToArray();
            var endPoints = NumberUtils.GetControlPointsFor(end).ToArray();

            return ObjectAnimator.OfObject(this, ControlPointsProperty, new TimelyEvaluator(), startPoints, endPoints);
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            if (ControlPoints == null) return;

            var length = ControlPoints.Count;

            var height = MeasuredHeight;
            var width = MeasuredWidth;

            var minDimen = height > width ? width : height;

            _path.Reset();
            _path.MoveTo(minDimen * ControlPoints[0].X, minDimen * ControlPoints[0].Y);
            for (var i = 1; i < length; i += 3)
            {
                _path.CubicTo(minDimen * ControlPoints[i].X, minDimen * ControlPoints[i].Y,
                    minDimen * ControlPoints[i + 1].X, minDimen * ControlPoints[i + 1].Y,
                    minDimen * ControlPoints[i + 2].X, minDimen * ControlPoints[i + 2].Y);
            }
            canvas.DrawPath(_path, _paint);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(widthMeasureSpec, heightMeasureSpec);

            var width = MeasuredWidth;
            var height = MeasuredHeight;

            var widthWithoutPadding = width - PaddingLeft - PaddingRight;
            var heightWithoutPadding = height - PaddingTop - PaddingBottom;

            var maxWidth = (int) (heightWithoutPadding * Ratio);
            var maxHeight = (int) (widthWithoutPadding / Ratio);

            if (widthWithoutPadding > maxWidth)
                width = maxWidth + PaddingLeft + PaddingRight;
            else
                height = maxHeight + PaddingTop + PaddingBottom;

            SetMeasuredDimension(width, height);
        }

        class TimelyViewProperty : Property
        {
            public TimelyViewProperty(IntPtr javaReference, JniHandleOwnership transfer)
                : base(javaReference, transfer)
            {
            }

            public TimelyViewProperty(Class type, string name)
                : base(type, name)
            {
            }

            public override Object Get(Object @object)
            {
                var view = @object.JavaCast<TimelyView>();
                return view.ControlPoints.ToArray();
            }

            public override void Set(Object @object, Object value)
            {
                var view = @object.JavaCast<TimelyView>();
                view.ControlPoints = value.ToArray<Point>().ToList();
            }
        }
    }
}