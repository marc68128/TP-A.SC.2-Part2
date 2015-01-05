using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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

namespace DemoProgessBar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Observable.Start(() => {
                var currentValue = 0;
                while (currentValue <= 100)
                {
                    Dispatcher.BeginInvoke(new Action<MainWindow>((sender) => { ProgressBar.Value = currentValue; }), this);
                    currentValue++;
                    Thread.Sleep(100);
                }
            });
        }
    }
}
