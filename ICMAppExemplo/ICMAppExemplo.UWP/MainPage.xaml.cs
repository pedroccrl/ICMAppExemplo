using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace ICMAppExemplo.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            Xamarin.FormsMaps.Init("2vMptUP2OAmkGShUjALw~SrMuB-Kd-79zozdAOlaqkQ~Ajrf8iOj_smhgEVtKnZgZWDgjV3SKpHmxoTjyj_4ZlCFgizBeet7Og8IFg4FZkY4");
            LoadApplication(new ICMAppExemplo.App());
        }
    }
}
