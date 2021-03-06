using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Graphics.Drawables.Shapes;

namespace JoystickControl
{
    public class OverallView : View, View.IOnTouchListener
    {
        private readonly ShapeDrawable _shape;

        public OverallView(Context context) : base(context)
        {
            SetOnTouchListener(this);
            SetBackgroundColor(Color.White);

            var paint = new Paint();
            paint.SetARGB(255, 200, 255, 0);
            paint.SetStyle(Paint.Style.Stroke);
            paint.StrokeWidth = 4;

            _shape = new ShapeDrawable(new OvalShape());
            _shape.Paint.Set(paint);

            //_shape.SetBounds(20, 20, 300, 200);
        }

        public bool OnTouch(View v, MotionEvent e)
        {
            Toast.MakeText(this.Context, "Screen was touched", ToastLength.Long).Show();
            switch (e.Action)
            {
                case MotionEventActions.Down:
                    //var _viewX = e.GetX();
                    break;
                case MotionEventActions.Move:
                    //var left = (int)(e.RawX - _viewX);
                    //var right = (int)(left + v.Width);
                    //v.Layout(left, v.Top, right, v.Bottom);
                    break;
            }
            return true;
        }

        protected override void OnDraw(Canvas canvas)
        {
            _shape.Draw(canvas);
        }
    }
}