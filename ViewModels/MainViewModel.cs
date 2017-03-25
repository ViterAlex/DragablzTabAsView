using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;

using DragablzTabAsView.Commands;
using DragablzTabAsView.Views;

namespace DragablzTabAsView.ViewModels
{
    public class MainViewModel : ViewModelBase
    {

        public ObservableCollection<ViewModelBase> Views { get; set; }

        private DelegateCommand<int> _addViewCommand;

        public ICommand AddViewCommand
        {
            get
            {
                if (_addViewCommand == null)
                {
                    _addViewCommand = new DelegateCommand<int>(AddView);
                }
                return _addViewCommand;
            }
        }

        private void AddView(int i)
        {
            if (Views == null)
            {
                Views = new ObservableCollection<ViewModelBase>();
            }
            switch (i)
            {
                case 1:
                    if (!Views.Any(x => x.GetType() == typeof(FirstViewModel)))
                        Views.Add(new FirstViewModel());
                    break;
                case 2:
                    if (!Views.Any(x => x.GetType() == typeof(SecondViewModel)))
                        Views.Add(new SecondViewModel());
                    break;
                case 3:
                    if (!Views.Any(x => x.GetType() == typeof(ThirdViewModel)))
                        Views.Add(new ThirdViewModel());
                    break;
            }
            OnPropertyChanged("Views");
        }

        #region Constructor

        public MainViewModel()
        {
            // Blank
        }

        #endregion

    }
}
