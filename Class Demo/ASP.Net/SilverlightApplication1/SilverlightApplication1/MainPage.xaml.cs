using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace SilverlightApplication1
{
    public partial class MainPage : UserControl
    {
        int counter = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        
        private void Sky_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
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
        }
    }
}
