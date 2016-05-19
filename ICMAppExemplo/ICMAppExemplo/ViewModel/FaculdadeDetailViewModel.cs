using System;
using System.ComponentModel;
using Xamarin.Forms;
using ICMAppExemplo.Model;
namespace ICMAppExemplo
{
	public class FaculdadeDetailViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public Faculdade Faculdade { get; set; }
		public FaculdadeDetailViewModel (Faculdade facul)
		{
			this.Faculdade = facul;
		}
	}
}


