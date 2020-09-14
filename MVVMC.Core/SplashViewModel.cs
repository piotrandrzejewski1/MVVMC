using System;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace MVVMC.Core
{
    public class SplashViewModel : ViewModelBase
    {
        private string sampleText;

        public string SampleText
        {
            get => sampleText;
            set => Set(ref sampleText, value);
        }

        public async Task ViewAppeared()
        {
            SampleText = "Doing";
            await Task.Delay(TimeSpan.FromSeconds(1));
            SampleText = "some";
            await Task.Delay(TimeSpan.FromSeconds(1));
            SampleText = "work";
            await Task.Delay(TimeSpan.FromSeconds(1));
            SplashPresentationFinished?.Invoke();
        }

        public Action SplashPresentationFinished { get; set; }
    }
}
