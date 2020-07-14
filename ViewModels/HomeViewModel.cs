using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using V3.Models;

namespace V3.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ObservableCollection<Konut> Konutlar { get; set; }

        public HomeViewModel()
        {
            Konutlar = new ObservableCollection<Konut>
            {
                new Konut{Alan = 500, Fiyat = 800, bahceAlan = 200},
                new Konut{Alan = 400, Fiyat = 750, bahceAlan = 100},
                new Konut{Alan = 450, Fiyat = 600, bahceAlan = 150},
                new Konut{Alan = 600, Fiyat = 900, bahceAlan = 300}
            };
        }

    }
}
