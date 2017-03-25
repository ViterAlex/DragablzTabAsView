using System.Windows;

namespace DragablzTabAsView.ViewModels
{
    public class ThirdViewModel : ViewModelBase
    {

        public static readonly DependencyProperty ViewModelTextProperty = DependencyProperty.Register(
            "ViewModelText", typeof(string), typeof(ThirdViewModel), new PropertyMetadata(default(string)));

        public string ViewModelText
        {
            get
            {
                return (string) GetValue(ViewModelTextProperty);
            }
            set
            {
                SetValue(ViewModelTextProperty, value);
            }
        }

        public ThirdViewModel()
        {
            ViewModelText = "Третий View";
        }
    }
}