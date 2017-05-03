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
using Gui_Design_2.Semester_opgave.Models;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gui_Design_2.Semester_opgave
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainBurgerMenu : Page
    {
        public MainBurgerMenu()
        {
            this.InitializeComponent();
            this.Loaded += MainBurgerMenu_Loaded;
        }

        private void MainBurgerMenu_Loaded(object sender, RoutedEventArgs e)
        {
            MenuGrid_Tapped(null, null);
        }

        private void MenuGrid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (NavigationPane.IsPaneOpen)
                NavigationPane.IsPaneOpen = !NavigationPane.IsPaneOpen;

            MenuItem menu = LeftMenu.SelectedItem as MenuItem;
            if (menu != null)
            {
                if (menu.NavigateTo != null)
                    CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => { FrameContent.Navigate(menu.NavigateTo); });
            }
        }
    }
}
