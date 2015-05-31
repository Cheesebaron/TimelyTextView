using Android.Animation;
using Android.App;
using Android.OS;
using Android.Widget;
using DK.Ostebaronen.Droid.TimelyTextView;

namespace Sample
{
    [Activity(Label = "Sample", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/AppTheme")]
    public class MainActivity : Activity
    {
        public static int Duration = 1000;
        public static int NoValue = -1;
        private Spinner _fromSpinner;
        private SeekBar _seekBar;
        private TimelyView _timelyView;
        private Spinner _toSpinner;
        private volatile ObjectAnimator _objectAnimator;
        private volatile int _from = NoValue;
        private volatile int _to = NoValue;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _timelyView = FindViewById<TimelyView>(Resource.Id.textView1);
            _seekBar = FindViewById<SeekBar>(Resource.Id.seekBar);
            _fromSpinner = FindViewById<Spinner>(Resource.Id.fromSpinner);
            _toSpinner = FindViewById<Spinner>(Resource.Id.toSpinner);

            var adapter = ArrayAdapter<string>.CreateFromResource(this, Resource.Array.from_numbers_array,
                Android.Resource.Layout.SimpleSpinnerItem);
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleSpinnerDropDownItem);
            _fromSpinner.Adapter = adapter;
            _toSpinner.Adapter = adapter;

            _fromSpinner.ItemSelected += (sender, args) =>
            {
                _from = args.Position - 1;
                if (_from != NoValue && _to != NoValue)
                {
                    _objectAnimator = _timelyView.Animate(_from, _to);
                    _objectAnimator.SetDuration(Duration);
                }
                else
                {
                    _objectAnimator = null;
                }
            };

            _toSpinner.ItemSelected += (sender, args) =>
            {
                _to = args.Position - 1;
                if (_from != NoValue && _to != NoValue)
                {
                    _objectAnimator = _timelyView.Animate(_from, _to);
                    _objectAnimator.SetDuration(Duration);
                }
                else
                {
                    _objectAnimator = null;
                }
            };

            _seekBar.Max = Duration;
            _seekBar.ProgressChanged += (sender, args) =>
            {
                if (_objectAnimator != null)
                    _objectAnimator.CurrentPlayTime = args.Progress;
            };
        }
    }
}