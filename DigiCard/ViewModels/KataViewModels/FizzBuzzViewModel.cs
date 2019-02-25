using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    public class FizzBuzzViewModel : BindableBase
    {


        public int Result
        {
            get;
            set;
        }

        public Visibility IsVisible
        {
            get { return isVisible; }
            set { SetProperty(ref isVisible, value); }
        }
        private Visibility isVisible = Visibility.Collapsed;

        public FizzBuzzViewModel()
        { 
        }
    }
}