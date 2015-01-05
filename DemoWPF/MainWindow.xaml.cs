using System;
using System.Windows;

namespace DemoWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MyButton.Content = "Salut";
            MyButton.Click += MyButtonOnClick;
        }

        private void MyButtonOnClick(object sender, RoutedEventArgs routedEventArgs)
        {
            Random r = new Random();
            MyButton.Content = r.Next(1000);
        }
    }
}
