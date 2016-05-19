using ICMAppExemplo.Model;
using ICMAppExemplo.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ICMAppExemplo.View
{
	public partial class FaculdadesPage : ContentPage
	{
        FaculdadeViewModel ViewModel;
		public FaculdadesPage ()
		{
			InitializeComponent ();
            ViewModel = new FaculdadeViewModel();
            lvFaculdades.ItemSelected += LvFaculdades_ItemSelected;
            BindingContext = ViewModel;
			Label l;

		}

        private void LvFaculdades_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null) return;
			Faculdade f = (Faculdade)e.SelectedItem;
			Faculdade f2 = Aplicativo.Faculdades.Find(fa=> fa.Nome == f.Nome);
			NavegacaoPage.Instance.PushAsync(new FaculdadeDetailPage(f2));
        }
    }
}
