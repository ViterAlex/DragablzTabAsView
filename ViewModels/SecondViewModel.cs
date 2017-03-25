﻿using System.Windows;

namespace DragablzTabAsView.ViewModels
{
    public class SecondViewModel : ViewModelBase
    {

        public static readonly DependencyProperty ViewModelTextProperty = DependencyProperty.Register(
            "ViewModelText", typeof(string), typeof(SecondViewModel), new PropertyMetadata(default(string)));

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

        public SecondViewModel()
        {
            ViewModelText = "Второй View";
        }
    }
}