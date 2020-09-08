using System;
using MVVMC.iOS.Scenes.Splash;
using UIKit;

namespace MVVMC.iOS.Scenes
{
    public class AppCoordinator : CoordinatorBase
    {
        private readonly UIWindow window;
        private readonly UINavigationController navigationController = new UINavigationController();

        public AppCoordinator(UIWindow window)
        {
            this.window = window;
        }

        public override void Start()
        {
            navigationController.NavigationBar.Hidden = true;
            window.RootViewController = navigationController;
            window.MakeKeyAndVisible();

            ShowSplash();
        }

        public override void Finish()
        {
        }

        private void ShowSplash()
        {
            var storyboard = UIStoryboard.FromName("Splash", null);
            var splashVc = storyboard.InstantiateViewController("SplashViewController");

            navigationController.ViewControllers = new[] { splashVc };
        }
    }
}
