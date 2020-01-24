using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App30;
using App30.iOS;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(AppShell), typeof(MyShellRenderer))]
namespace App30.iOS
{
    public class MyShellRenderer : ShellRenderer
    {
        protected override IShellSectionRenderer CreateShellSectionRenderer(ShellSection shellSection)
        {
            var renderer = base.CreateShellSectionRenderer(shellSection);
            if (renderer != null)
            {
                (renderer as ShellSectionRenderer).NavigationBar.SetBackgroundImage(UIImage.FromFile("monkey.png"), UIBarMetrics.Default);
            }
            return renderer;
        }

        protected override IShellTabBarAppearanceTracker CreateTabBarAppearanceTracker()
        {
            return new CustomTabbarAppearance();
        }
    }

    public class CustomTabbarAppearance : IShellTabBarAppearanceTracker
    {
        public void Dispose()
        {

        }

        public void ResetAppearance(UITabBarController controller)
        {

        }

        public void SetAppearance(UITabBarController controller, ShellAppearance appearance)
        {
            UITabBar myTabBar = controller.TabBar;

            if (myTabBar.Items != null)
            {
                UITabBarItem itemOne = myTabBar.Items[0];

                itemOne.Image = UIImage.FromBundle("tab_about.png");
                itemOne.SelectedImage = UIImage.FromBundle("tab_feed.png");

                
                UITabBarItem itemTwo = myTabBar.Items[1];

                itemTwo.Image = UIImage.FromBundle("tab_feed.png");
                itemTwo.SelectedImage = UIImage.FromBundle("tab_about.png");

                //The same logic if you have itemThree, itemFour....
            }
            
        }

        public void UpdateLayout(UITabBarController controller)
        {
            
            UITabBar myTabBar = controller.TabBar;

            foreach (var barItem in myTabBar.Items)
            {
                barItem.ImageInsets = new UIEdgeInsets(8, 0, 0, 0);
                //barItem.TitlePositionAdjustment = new UIOffset(10, 0);
            }
        }
    }
}
