using System.Windows;

namespace DragablzTabAsView.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {

        public static readonly DependencyProperty ViewModelTextProperty = DependencyProperty.Register(
            "ViewModelText", typeof(string), typeof(FirstViewModel), new PropertyMetadata(default(string)));

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

        public FirstViewModel()
        {
            ViewModelText = "Первый View";
        }
    }
}