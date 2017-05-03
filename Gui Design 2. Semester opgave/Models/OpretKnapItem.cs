using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using Windows.UI.Xaml.Controls;

namespace Gui_Design_2.Semester_opgave.Models
{
    public class OpretKnapItem : ViewModelBase
    {
        public string Title { get; set; }

        public Type NavigateTo { get; set; }
    }
}
