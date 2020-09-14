using System;
using Autofac;
using MVVMC.Core;
using UIKit;
using MVVMC.iOS.Helpers;
using MVVMC.iOS.Scenes.Home;

namespace MVVMC.iOS.Scenes.Splash
{
    public class SplashCoordinator : CoordinatorBase
    {
        private readonly IContainer container;
   
        public SplashCoordinator(IContainer container, UINavigationController navigationController)
            : base(navigationController)
        {
            this.container = container;
        }

        public override void Start()
        {
            ShowSplash();
        }

        private void ShowSplash()
        {
            var storyboard = UIStoryboard.FromName("Splash", null);
            var splashVc = storyboard.InstantiateViewController<SplashViewController>();
            var splashVm = container.Resolve<SplashViewModel>();

            splashVm.SplashPresentationFinished = ShowHome; //refactor to use events

            splashVc.SetViewModel(splashVm);
            navigationController.NavigationBarHidden = true;
            navigationController.ViewControllers = new[] { splashVc };
        }

        private void ShowHome()
        {
            var homeCoordinator = new HomeCoordinator(container, navigationController, this);
            homeCoordinator.Start();
        }
    }
}
