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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        int counter = 0;
        public Window3()
        {
            InitializeComponent();
        }

        private void sky_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock text = new TextBlock()
            {
                Foreground = new SolidColorBrush(Colors.Black),
                FontFamily = new FontFamily("Arial Black"),
                FontSize = 24,
                Text = (++counter).ToString()
            };
            Canvas.SetLeft(text, e.GetPosition(this).X);
            Canvas.SetTop(text, e.GetPosition(this).Y);
            Canvas myCanvas = (Canvas)this.FindName("Sky");
            myCanvas.Children.Add(text);   //this.Controls.Add(b1);        
            //MediaElement 
        }
    }
}
