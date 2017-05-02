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
            SelectedMenuItem = MenuItems.FirstOrDefault();
        }

        public ObservableCollection<MenuItem> MenuItems { get; set; }

        private MenuItem selectedMenuItem;

        public MenuItem SelectedMenuItem
        {
            get { return selectedMenuItem; }
            set { selectedMenuItem = value; RaisePropertyChanged(); }
        }

        private List<MenuItem> GetMenuItems()
        {
            List<MenuItem> menuItems = new List<MenuItem>();
            menuItems.Add(new MenuItem() { Title = "Påmindelser", NavigateTo = typeof(Påmindelser) });
            menuItems.Add(new MenuItem() { Title = "Kalender", NavigateTo = typeof(Kalender1) });
            menuItems.Add(new MenuItem() { Title = "Historik", NavigateTo = typeof(Register1) });
            menuItems.Add(new MenuItem() { Title = "Bruger", NavigateTo = typeof(Brugere1) });

            return menuItems;
        }
    }
}
