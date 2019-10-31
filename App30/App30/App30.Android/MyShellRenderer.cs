using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using Android.Widget;
using App30;
using App30.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(AppShell), typeof(MyShellRenderer))]
namespace App30.Droid
{
    public class MyShellRenderer : ShellRenderer
    {
        public MyShellRenderer(Context context) : base(context)
        {
        }

        protected override IShellBottomNavViewAppearanceTracker CreateBottomNavViewAppearanceTracker(ShellItem shellItem)
        {
            return new CustomBottomNavAppearance();
        }
    }

    public class CustomBottomNavAppearance : IShellBottomNavViewAppearanceTracker
    {
        public void Dispose()
        {

        }

        public void ResetAppearance(BottomNavigationView bottomView)
        {

        }

        public void SetAppearance(BottomNavigationView bottomView, ShellAppearance appearance)
        {
            IMenu myMenu = bottomView.Menu;

            IMenuItem myItemOne = myMenu.GetItem(0);

            if (myItemOne.IsChecked)
            {
                myItemOne.SetIcon(Resource.Drawable.tab_about);
            }
            else
            {
                myItemOne.SetIcon(Resource.Drawable.tab_feed);
            }

            //The same logic if you have myItemTwo, myItemThree....

        }
    }
}