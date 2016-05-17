using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ICMAppExemplo.View
{
    public class NavegacaoPage : NavigationPage
    {
        private static NavegacaoPage _instance;

        public static NavegacaoPage Instance
        {
            get
            {
                if (_instance == null) _instance = new NavegacaoPage();
                return _instance;
            }
        }


        private NavegacaoPage()
        {
            Title = "Intro. Comp. Móvel";
            BarTextColor = Color.White;
            BarBackgroundColor = Color.FromHex("#3F51B5");
            PushAsync(new HomePage()).Wait();
        }
    }
}
