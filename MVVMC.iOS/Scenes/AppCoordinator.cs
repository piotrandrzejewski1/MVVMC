using System;
using Autofac;
using MVVMC.Core;
using MVVMC.iOS.Scenes.Home;
using MVVMC.iOS.Scenes.Splash;
using UIKit;

namespace MVVMC.iOS.Scenes
{
    public class AppCoordinator : CoordinatorBase
    {
        private IContainer iocContainer;

        public AppCoordinator(IContainer iocContainer, UINavigationController navigationController)
            : base(navigationController)
        {
            this.iocContainer = iocContainer;
        }

        public override void Start()
        {
            var splashCoordinator = new SplashCoordinator(iocContainer, navigationController);
            splashCoordinator.Start();
        }
    }
}
