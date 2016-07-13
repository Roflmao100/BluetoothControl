using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace JoystickControl
{
    [Activity(Label = "JoystickControl", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen", 
        ScreenOrientation = Android.Content.PM.ScreenOrientation.Landscape, MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        // Screen metrics in dp
        public static float m_ScreenWidth;
        public static float m_ScreenHeight;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            //SetContentView(Resource.Layout.Main);
            SetContentView(new OverallView(this));

            var metrics = Resources.DisplayMetrics;
            m_ScreenWidth = metrics.WidthPixels;//ConvertPixelsToDp(metrics.WidthPixels);
            m_ScreenHeight = metrics.HeightPixels;//ConvertPixelsToDp(metrics.HeightPixels);
            Toast.MakeText(this, "Width: " + m_ScreenWidth + ", Height: " + m_ScreenHeight, ToastLength.Long).Show();

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);
            //button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }

        private int ConvertPixelsToDp(float pixelValue)
        {
            var dp = (int)((pixelValue) / Resources.DisplayMetrics.Density);
            return dp;
        }
    }
}

