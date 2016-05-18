using ICMAppExemplo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

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
            Title = faculdade.Nome;
            Content = new StackLayout();
        }
	}
}
