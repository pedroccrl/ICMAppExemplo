using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

using ICMAppExemplo.Model;
namespace ICMAppExemplo
{
	public partial class FaculDetailPage : ContentPage
	{
		public FaculDetailPage (Faculdade faculdade)
		{
			InitializeComponent();
			BindingContext = faculdade;
			var map = new Map(
				MapSpan.FromCenterAndRadius(
					new Position(faculdade.Posicao.Latitude, faculdade.Posicao.Longitude), Distance.FromMiles(0.3))) {
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};
			grid.Children.Add(map);
		}

		public FaculDetailPage ()
		{
			
		}

		protected override void OnAppearing ()
		{
			base.OnAppearing();
		}
	}
}

