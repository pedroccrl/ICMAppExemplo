using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ICMAppExemplo.View
{
    public class HomePage : TabbedPage
    {
        public HomePage()
        {
            Title = "Intro. Comp. Móvel";

            Children.Add(new FaculdadesPage());
        }
    }
}
