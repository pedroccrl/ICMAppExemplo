using System;

using Xamarin.Forms;

namespace ICMAppExemplo
{
	public class AlunosDataTemplate : ViewCell
	{
		public AlunosDataTemplate ()
		{
			object obj = BindingContext;
			StackLayout stack = new StackLayout();
			Label lblNome = new Label();
			Label lblEmail = new Label();
			lblNome.SetBinding(Label.TextProperty, "Nome");
			lblEmail.SetBinding(Label.TextProperty, "Email");
			stack.Children.Add(lblNome);
			stack.Children.Add(lblEmail);

			View = stack;
		}
	}
}


