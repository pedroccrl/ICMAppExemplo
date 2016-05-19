using ICMAppExemplo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ICMAppExemplo.ViewModel
{
    public class FaculdadeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

		public List<Faculdade> Faculdades 
		{
			get
			{
				return Aplicativo.Faculdades;
			}
		}

        public FaculdadeViewModel()
        {
            
        }

    }
}
