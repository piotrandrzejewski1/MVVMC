using System;
using Autofac;
using UIKit;
using MVVMC.iOS.Helpers;

namespace MVVMC.iOS.Scenes.Home
{
    public class HomeCoordinator : CoordinatorBase
    {
        private readonly IContainer container;
        private readonly ICoordinator parentCoordinator;

        public HomeCoordinator(
            IContainer container,
            UINavigationController navigationController,
            ICoordinator parentCoordinator)
            : base(navigationController)
        {
            this.container = container;
            this.parentCoordinator = parentCoordinator;
        }

        public override void Start()
        {
            var storyboard = UIStoryboard.FromName("Home", null);
            var homeVc = storyboard.InstantiateViewController<HomeViewController>();
            //var splashVm = container.Resolve<HomeViewModel>();

            //splashVm.SplashPresentationFinished = ShowHome; //refactor to use events

            //splashVc.SetViewModel(splashVm);
            navigationController.ViewControllers = new[] { homeVc };
        }
    }
}
