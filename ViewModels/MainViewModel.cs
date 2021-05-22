using Microsoft.Xaml.Behaviors.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace TransitioningContentControlTest001.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand LoadContent1Command { get; }
        public ICommand LoadContent2Command { get; }
        public ICommand LoadContent3Command { get; }

        public MainViewModel()
        {
            LoadContent1Command = new ActionCommand(() => Content = new Content1ViewModel());
            LoadContent2Command = new ActionCommand(() => Content = new Content2ViewModel());
            LoadContent3Command = new ActionCommand(() => Content = new Content3ViewModel());
        }

        public ViewModelBase Content
        {
            get => _Content;
            set
            {
                _Content = value;
                OnPropertyChanged();
            }
        }
        private ViewModelBase _Content = new Content1ViewModel();
    }
}
