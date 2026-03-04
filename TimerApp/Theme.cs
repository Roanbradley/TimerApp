using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimerApp;

namespace TimerApp
{
    public sealed class Theme
    {
        
    public static Theme Dark = new {AppTheme.Dark, "dark mode"};
    public static Theme Light = new {AppTheme.Light, "Light mode"};
    public static Theme System = new {AppTheme.Unspecified, "default mode"};

    public static List<Theme> AvailableThemes {get; } = new ()
    {
        Dark,
        Light,
        Unspecified
    };

    public AppTheme AppTheme {get;}
    public string DisplayName {get;}


    private Theme (AppTheme Theme, string _DisplayName)
    {
        AppTheme = Theme;
        DisplayName = _DisplayName;
    }

    }
}