using ICMAppExemplo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms.Maps;
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
        StackLayout content = new StackLayout 
		{ 
			Spacing = 5,
			Padding = 12
		};
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
		Map map;


		Grid grid = new Grid
		{
			RowDefinitions = new RowDefinitionCollection
			{
				new RowDefinition
				{
					Height = new GridLength(1, GridUnitType.Star)
				},
				new RowDefinition
				{
					Height = new GridLength(1, GridUnitType.Star)
				}
			}
		};

		ListView lvAlunos = new ListView
		{
			
			HasUnevenRows = true
		};

		FaculdadeDetailViewModel ViewModel;
		public FaculdadeDetailPage (Faculdade faculdade)
		{
			
			ViewModel = new FaculdadeDetailViewModel(faculdade);
			BindingContext = faculdade;

			map = new Map(
				MapSpan.FromCenterAndRadius(
					new Position(faculdade.Posicao.Latitude, faculdade.Posicao.Longitude), Distance.FromMiles(0.3))) {
				IsShowingUser = true,
				HeightRequest = 100,
				WidthRequest = 960,
				VerticalOptions = LayoutOptions.FillAndExpand
			};

			map.HasZoomEnabled = true;

			ToolbarItem addUsr = new ToolbarItem 
			{
				Text = "Adicionar",
				Order = ToolbarItemOrder.Primary
			};
			addUsr.Clicked += (object sender, EventArgs e) => 
			{
				NavegacaoPage.Instance.PushAsync(new AdicionarAlunoPage(faculdade));
			};
			ToolbarItems.Add(addUsr);


			foto.SetBinding(Image.SourceProperty, "Foto");
            lblNome.SetBinding(Label.TextProperty, "Nome");
            lblLocal.SetBinding(Label.TextProperty, "Local");

			var alunosDataTemplate = new DataTemplate (() => {
				StackLayout stack = new StackLayout();
				Label lblNome = new Label();
				Label lblEmail = new Label();
				lblNome.SetBinding(Label.TextProperty, "Nome");
				lblEmail.SetBinding(Label.TextProperty, "Email");
				stack.Children.Add(lblNome);
				stack.Children.Add(lblEmail);

				return new ViewCell{View = stack};
			});

			lvAlunos.ItemsSource = faculdade.Alunos;
            lvAlunos.ItemTemplate = new DataTemplate(typeof(AlunosDataTemplate));
//			lvAlunos.SetBinding(ListView.ItemsSourceProperty,"Alunos");

			ScrollView scroll = new ScrollView();
			StackLayout sAlunos = new StackLayout();

			foreach (var item in faculdade.Alunos)
			{
				StackLayout stacka = new StackLayout {
					Padding = 8
				};
				Label lblNome = new Label {
					Text = item.Nome
				};
				Label lblEmail = new Label {
					Text = item.Email
				};
				stacka.Children.Add(lblNome);
				stacka.Children.Add(lblEmail);
				sAlunos.Children.Add(stacka);
			}
			scroll.Content = sAlunos;
			grid.Children.Add(scroll,0,0);
			if (Device.OS == TargetPlatform.iOS)
			{
				grid.Children.Add(map,0,1);
			}

			content.Children.Add(foto);
			content.Children.Add(lblNome);
			content.Children.Add(lblLocal);
			content.Children.Add(grid);

            Title = faculdade.Nome;

			Content = content;
        }
			
	}
}
