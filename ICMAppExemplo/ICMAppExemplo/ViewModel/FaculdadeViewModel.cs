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

        private ObservableCollection<Faculdade> _faculdades;

        public ObservableCollection<Faculdade> Faculdades
        {
            get { return _faculdades; }
            set { _faculdades = value; NotifyPropertyChanged("Faculdades"); }
        }

        public FaculdadeViewModel()
        {
            Faculdades = new ObservableCollection<Faculdade>();
            Faculdades.CollectionChanged += Faculdades_CollectionChanged;

            Faculdades.Add(new Faculdade
            {
                Nome = "UFF",
                Local = "Rio das Ostras",
                Foto = "http://www.uff.br/dalicenca/images/stories/logos/uff.jpg"
            });
            Faculdades.Add(new Faculdade
            {
                Nome = "UFF",
                Local = "Niteroi",
                Foto = "http://www.uff.br/dalicenca/images/stories/logos/uff.jpg"
            });
            Faculdades.Add(new Faculdade
            {
                Nome = "UFF",
                Local = "Volta Redonda",
                Foto = "http://www.uff.br/dalicenca/images/stories/logos/uff.jpg"
            });
        }

        private void Faculdades_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Faculdades");
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
