using System;
using System.IO;
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
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GwynethButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Storyboard wheelspinAnimation;
        Storyboard beeStingAnimation;

        public MainWindow() 
        {
            Random r = new Random();
            

            InitializeComponent();
            this.KeyUp += MainWindow_KeyUp;

            wheelspinAnimation = (Storyboard)Resources["wheelspin"];
            beeStingAnimation = (Storyboard)Resources["BeeSting"];

            Wheel.MouseLeftButtonUp += (s, e) =>
            {
                wheelspinAnimation.Begin();
            };

            /* wheelspinAnimation.Completed += (s, e) =>
             {
                 int rInt = r.Next(1, 3);
                 switch (rInt)
                 {
                     case 1:
                         beeStingAnimation.Begin();
                         break;
                     case 2:
                         wheelspinAnimation.Begin();
                         break;
                     case 3:

                         break;
                 }
             };
             */

            wheelspinAnimation.Completed += (s, e) =>
            {
                beeStingAnimation.Begin();
            };
            
        }
        private void MainWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                Application.Current.Shutdown();
            }
        }
    }
}
