﻿using Messaging.ViewModels;
using Windows.UI.Xaml.Controls;

namespace Messaging.Views
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public MainPageViewModel ViewModel => this.DataContext as MainPageViewModel;
    }
}