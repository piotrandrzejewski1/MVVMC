using Autofac;
using Foundation;
using MVVMC.Core;
using MVVMC.iOS.Scenes;
using MVVMC.iOS.Scenes.Home;
using UIKit;

namespace MVVMC.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : UIResponder, IUIApplicationDelegate
    {
        private AppCoordinator appCoordinator;

        [Export("window")]
        public UIWindow Window { get; set; }

        [Export("application:didFinishLaunchingWithOptions:")]
        public bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var iocContainer = PrepareIocContrainer();
            var navigationController = new UINavigationController();

            appCoordinator = new AppCoordinator(iocContainer, navigationController);
            appCoordinator.Start();

            Window = new UIWindow(UIScreen.MainScreen.Bounds);
            Window.RootViewController = navigationController;
            Window.MakeKeyAndVisible();

            return true;
        }

        private IContainer PrepareIocContrainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<SplashViewModel>();
            return builder.Build();
        }
    }
}

