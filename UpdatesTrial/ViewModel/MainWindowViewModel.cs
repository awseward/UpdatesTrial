using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using UpdatesTrial.Properties;

namespace UpdatesTrial.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged == null) { return; }

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public String VersionString
        {
            get { return VersionHelper.VersionString; }
        }
    }
}
