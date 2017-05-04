using GalaSoft.MvvmLight;
using Gui_Design_2.Semester_opgave.Models;
using Gui_Design_2.Semester_opgave;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Gui_Design_2.Semester_opgave.Viewmodels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItem>(GetMenuItems());
            KnapItems = new ObservableCollection<OpretKnapItem>(GetKnapper());
            SelectedMenuItem = MenuItems.FirstOrDefault();
        }

        public ObservableCollection<MenuItem> MenuItems { get; set; }

        public ObservableCollection<OpretKnapItem> KnapItems { get; set; }

        //Nyt selescted(somethin)
        private OpretKnapItem selectedKnapItem;

        public OpretKnapItem SelectedKnapItem
        {
            get { return selectedKnapItem; }
            set { selectedKnapItem = value; RaisePropertyChanged(); }
        }
        //-----------------------------------------------------------------

        private MenuItem selectedMenuItem;

        public MenuItem SelectedMenuItem
        {
            get { return selectedMenuItem; }
            set { selectedMenuItem = value; RaisePropertyChanged(); }
        }

        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { Title = "Startside", NavigateTo = typeof(MainPage_Beta) });
            menuItems.Add(new MenuItem() { Title = "Påmindelser", NavigateTo = typeof(Påmindelser2) });
            menuItems.Add(new MenuItem() { Title = "Kalender", NavigateTo = typeof(Kalender1) });
            menuItems.Add(new MenuItem() { Title = "Historik", NavigateTo = typeof(Register1) });
            menuItems.Add(new MenuItem() { Title = "Opret Barn", NavigateTo = typeof(Opret1) });


            return menuItems;
        }

        private List<OpretKnapItem> GetKnapper()
        {
            List<OpretKnapItem> knappe = new List<OpretKnapItem>();
            knappe.Add(new OpretKnapItem() { Title = "Opret Barn", NavigateTo = (typeof(Opret1)) });

            return knappe;
        }
    }
}
