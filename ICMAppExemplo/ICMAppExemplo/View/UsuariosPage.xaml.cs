using ICMAppExemplo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ICMAppExemplo.View
{
	public partial class UsuariosPage : ContentPage
	{
        UsuarioViewModel ViewModel;
		public UsuariosPage ()
		{
			InitializeComponent ();
            ViewModel = new UsuarioViewModel();

            BindingContext = ViewModel;
		}
	}
}
