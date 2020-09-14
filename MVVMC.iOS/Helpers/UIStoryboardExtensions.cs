using System;
using UIKit;

namespace MVVMC.iOS.Helpers
{
    public static class UIStoryboardExtensions
    {
        public static T InstantiateViewController<T>(this UIStoryboard storyboard)
            where T : UIViewController
        {
            var name = typeof(T).Name;
            return storyboard.InstantiateViewController(name) as T;
        }
    }
}
