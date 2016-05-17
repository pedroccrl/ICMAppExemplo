using ICMAppExemplo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace ICMAppExemplo.View
{
	public class FaculdadeDetailPage : ContentPage
	{
        Image foto = new Image
        {
            WidthRequest = 128,
            Aspect = Aspect.AspectFit
        };
        StackLayout content = new StackLayout { Spacing = 0 };
        Label lblNome = new Label
        {
            FontSize = 28,
            FontAttributes = FontAttributes.Italic
        };
        Label lblLocal = new Label
        {
            FontSize = 16,
            FontAttributes = FontAttributes.Bold
        };
        
		public FaculdadeDetailPage (Faculdade faculdade)
		{
            foto.SetBinding(Image.SourceProperty, "Foto");
            lblNome.SetBinding(Label.TextProperty, "Nome");
            lblLocal.SetBinding(Label.TextProperty, "Local");

            var map = new Map(
            MapSpan.FromCenterAndRadius(
                    new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            content = stack;
        }
	}
}
