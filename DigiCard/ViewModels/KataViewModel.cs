using DigiCard.Model;
using DigiCard.UtilityObjects;
using System.Windows;

namespace DigiCard.ViewModels
{
    public class KataViewModel : BindableBase
    {
        /// <summary>
        /// A reference to the Coding Katas class from the model
        /// </summary>
        private CodingKatas model;

        /// <summary>
        /// A FizzBuzz ViewModel
        /// </summary>
        public FizzBuzzViewModel fizzBuzzVM = new FizzBuzzViewModel();

        public string Header
        {
            get { return header; }
            set { SetProperty(ref header, value); }
        }
        private string header;

        public string Body
        {
            get { return body; }
            set { SetProperty(ref body, value); }
        }
        private string body;

        public Visibility IsVisible
        {
            get { return isVisible; }
            set { SetProperty(ref isVisible, value); }
        }
        private Visibility isVisible = Visibility.Collapsed;


        public KataViewModel(CodingKatas codingKatasArg)
        {
            model = codingKatasArg;
            Header = model.header;
            Body = model.body;
        }
    }
}