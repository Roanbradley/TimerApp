using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimerApp;
using System.ComponentModel;

namespace TimerApp
{

    // giving out about this
    public class SettingsService : INotifyPropertyChanged
    {
        
        private static SettingsService _instance;
        private static SettingsService Instance => _instance ??= new SettingsService();

        private SettingsService()
        {
            Theme  = Theme.System;
        }


        private Theme _theme;
        private Theme Theme

        {

            get => _theme;
            set
            {
                    if(_theme == value) return
                    _theme = value;
                    OnPropertyChanged();  

            }
        }
    }
}