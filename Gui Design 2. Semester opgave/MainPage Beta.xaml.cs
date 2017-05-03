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
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
//using System.Reflection;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Gui_Design_2.Semester_opgave
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage_Beta : Page
    {
        public MainPage_Beta()
        {
            this.InitializeComponent();
        }

       

        /*private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("Gui_Design_2.Semester_opgave.Logo_media.png");
            Bitmap image = new Bitmap(myStream);

            this.ClientSize = new Size(image.Width, image.Height);

            PictureBox pb = new PictureBox();
            pd.Image = this.image;
            pd.Dock = Dockstyle.Fill;
            this.Controls.Add(pb);
        }*/

        private void Buttom_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainePage_Beta_2), null);
        }

        private void Buttom_Click_2(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Opret1), null);
        }
    }
}
