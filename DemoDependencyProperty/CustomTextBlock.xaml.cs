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

namespace DemoDependencyProperty
{
    /// <summary>
    /// Interaction logic for CustomTextBlock.xaml
    /// </summary>
    public partial class CustomTextBlock : UserControl
    {
        public CustomTextBlock()
        {
            InitializeComponent();
            DataContext = this; 
        }

        public static DependencyProperty CustomTextProperty = DependencyProperty.Register("CustomTest", typeof (string),
            typeof (CustomTextBlock));

        public string CustomText
        {
            get { return (string) GetValue(CustomTextProperty);  }
            set { SetValue(CustomTextProperty, value);}
        }
    }
}
