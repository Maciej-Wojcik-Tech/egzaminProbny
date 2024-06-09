using Android.App;
using Android.OS;

using Android.Widget;

namespace karuzelaZdjec
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]

    public class MainActivity : Activity
    {
        private int[] Koty =
        {
            Resource.Drawable.kot1,
            Resource.Drawable.kot2,
            Resource.Drawable.kot3,
                Resource.Drawable.kot4

        };
        private int currentIndex = 0;
        private ImageView imageView;


        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            imageView = FindViewById<ImageView>(Resource.Id.imageView1);
            Button buttonPrevious = FindViewById<Button>(Resource.Id.button1);
            Button buttonNext = FindViewById<Button>(Resource.Id.button2);
            buttonNext.Click+=(sender, e) => ShowPreviousImage();
            buttonPrevious.Click +=(sender, e) => ShowNextImage();
            UpdateImage();

        }
        private void ShowPreviousImage()
        {
            currentIndex--;
            if(currentIndex<0)
            {
                currentIndex = Koty.Length - 1;
            }
            UpdateImage();
        }
        private void ShowNextImage()
        {
            currentIndex++;
            if(currentIndex>Koty.Length)
            {
                currentIndex = 0;
            }
            UpdateImage();
        }
        private void UpdateImage()
        {
            imageView.SetImageResource(Koty[currentIndex]);
        }
    }
}