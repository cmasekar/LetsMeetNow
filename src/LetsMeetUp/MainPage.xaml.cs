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
using System.Windows.Media.Animation;

namespace LetsMeetUp
{
    public partial class MainPage : PhoneApplicationPage
    {
        public static readonly DependencyProperty OptionsCommandProperty = DependencyProperty.Register("OptionsCommand", typeof(ICommand), typeof(MainPage), new PropertyMetadata(null));
        public static readonly DependencyProperty ChatCommandProperty = DependencyProperty.Register("ChatCommand", typeof(ICommand), typeof(MainPage), new PropertyMetadata(null));

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
        
        void sadf(object o)
        {
            Cntrl.Visibility = System.Windows.Visibility.Collapsed;
        }

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            OptionsCommand = new DelegateCommand(sadf);

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}