using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gui_Design_2.Semester_opgave
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Opret1 : Page
    {
        public Opret1()
        {
            this.InitializeComponent();
        }

        private void Buttom_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }

        private void Buttom_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage2), null);
        }

        private void Buttom_Click_3(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Påmindelser), null);
        }
    }
}
