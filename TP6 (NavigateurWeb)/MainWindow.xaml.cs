using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TP6__NavigateurWeb_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Frame.Navigating += FrameOnNavigating;
            Frame.Navigated += FrameOnNavigated;

            RoutedCommand myCommand = new RoutedCommand("myCommand", typeof(MainWindow), new InputGestureCollection() { new KeyGesture(Key.F8) });
            CommandBinding customCommandBinding = new CommandBinding(myCommand, ExecutedCustomCommand, CanExecuteCustomCommand);
            this.CommandBindings.Add(customCommandBinding);
        }

        private void ExecutedCustomCommand(object sender, ExecutedRoutedEventArgs e)
        {
            Frame.Refresh();
        }

        private void CanExecuteCustomCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            Control target = e.Source as Control;

            if (target != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        private void FrameOnNavigating(object sender, NavigatingCancelEventArgs navigatingCancelEventArgs)
        {
            ProgressBar.Visibility = Visibility.Visible;
        }

        private void FrameOnNavigated(object sender, NavigationEventArgs navigationEventArgs)
        {
            NavigationTextBox.Text = navigationEventArgs.Uri.ToString();
            ProgressBar.Visibility = Visibility.Collapsed;
        }

        private void GoClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new Uri(NavigationTextBox.Text)); 
        }
    }
}
