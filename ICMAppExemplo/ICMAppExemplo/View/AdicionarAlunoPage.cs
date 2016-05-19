using System;
using ICMAppExemplo.Model;
using Xamarin.Forms;

namespace ICMAppExemplo
{
	public class AdicionarAlunoPage : ContentPage
	{
		public AdicionarAlunoPage (Faculdade facul)
		{
			StackLayout stack = new StackLayout {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Padding = 12
			};
			Title= "Aluno";
			Label lbl = new Label
			{
				Text = "Adicionar um Aluno:\n",
				Margin = 12
			};
			Entry lblNome = new Entry {
				Placeholder = "Nome"
			};
			Entry lblEmail = new Entry {
				Placeholder = "Email"
			};

			Button btnConfir = new Button {
				BackgroundColor = Color.Blue,
				Text = "Confirmar",
				TextColor = Color.White,
				FontSize = 18
			};
			btnConfir.Clicked+= (object sender, EventArgs e) => 
			{
				
			};
			lblNome.SetBinding(Label.TextProperty, "Nome");
			lblEmail.SetBinding(Label.TextProperty,"Email");

			stack.Children.Add(lbl);
			stack.Children.Add(lblNome);
			stack.Children.Add(lblEmail);
			stack.Children.Add(btnConfir);

			Content = stack;
		}
	}
}


