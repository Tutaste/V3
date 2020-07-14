using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace V3.Models
{
    public class Konut : INotifyPropertyChanged
    {
        public int Alan
        {
            get; set;
        }

        public int Fiyat
        {
            get; set;
        }

        public int bahceAlan
        {
            get; set;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
