using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace XAMLAdvanced
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;

            var storyboard = new Storyboard();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void ClickedChangeOpacity(object sender, RoutedEventArgs e)
        {
            StoryboardChangeOpacity.Begin();      
        }

        private void ClickedMoveLeft(object sender, RoutedEventArgs e)
        {
            StoryboardMoveToLeft.Begin();
        }

        private void ClickedMoveRight(object sender, RoutedEventArgs e)
        {
            StoryboardMoveToRight.Begin();
        }

        private void ClickedMoveToCenter(object sender, RoutedEventArgs e)
        {
            StoryboardMoveToCenter.Begin();
        }

        private void ClickedRotate(object sender, RoutedEventArgs e)
        {
            if(TBButtonRotate.Text == "Obracaj")
            {
                StoryboardRotate.Begin();
                TBButtonRotate.Text = "Stop";
            }
            else if(TBButtonRotate.Text == "Stop")
            {
                StoryboardStopRotating.Begin();
                TBButtonRotate.Text = "Obracaj";
            }
        }

    }

}
