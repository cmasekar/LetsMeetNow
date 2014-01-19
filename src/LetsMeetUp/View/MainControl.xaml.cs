using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace LetsMeetUp.View
{
    public partial class MainControl : UserControl
    {
        public static readonly DependencyProperty OptionsCommandProperty = DependencyProperty.Register("OptionsCommand", typeof(ICommand), typeof(MainControl), new PropertyMetadata(null));
        public static readonly DependencyProperty ChatCommandProperty = DependencyProperty.Register("ChatCommand", typeof(ICommand), typeof(OptionsBar), new PropertyMetadata(null));

        public ICommand OptionsCommand
        {
            get { return (ICommand)GetValue(OptionsCommandProperty); }
            set { SetValue(OptionsCommandProperty, value); }
        }

        public ICommand ChatCommand
        {
            get { return (ICommand)GetValue(ChatCommandProperty); }
            set { SetValue(ChatCommandProperty, value); }
        }

        public MainControl()
        {
            InitializeComponent();
        }
    }
}
