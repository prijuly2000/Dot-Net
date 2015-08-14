using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DoubleAnimation da1 = new DoubleAnimation();
            da1.From = 0;
            da1.To = 113;
            da1.Duration = new Duration(TimeSpan.FromSeconds(1));
            da1.AutoReverse = true;
            da1.RepeatBehavior = RepeatBehavior.Forever;
            ellipse1.BeginAnimation(Ellipse.WidthProperty, da1);

            DoubleAnimation da2 = new DoubleAnimation();
            da2.From = 0;
            da2.To = 113;
            da2.Duration = new Duration(TimeSpan.FromSeconds(2));
            da2.AutoReverse = true;
            da2.RepeatBehavior = RepeatBehavior.Forever;
            ellipse2.BeginAnimation(Ellipse.WidthProperty, da2);

            DoubleAnimation da3 = new DoubleAnimation();
            da3.From = 0;
            da3.To = 113;
            da3.Duration = new Duration(TimeSpan.FromSeconds(3));
            da3.AutoReverse = true;
            da3.RepeatBehavior = RepeatBehavior.Forever;
            ellipse3.BeginAnimation(Ellipse.WidthProperty, da3);
            
        }
    }
}
