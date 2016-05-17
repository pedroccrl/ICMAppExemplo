using ICMAppExemplo.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ICMAppExemplo.ViewModel
{
    public class UsuarioViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Usuario> _usuarios;

        public ObservableCollection<Usuario> Usuarios
        {
            get { return _usuarios; }
            set { _usuarios = value; NotifyPropertyChanged("Usuarios"); }
        }

        public UsuarioViewModel()
        {
            Usuarios = new ObservableCollection<Usuario>();
            Usuarios.CollectionChanged += Usuarios_CollectionChanged;
            Usuarios.Add(new Usuario
            {
                Nome = "Pedro Câmara",
                Email = "pedroccrl@hotmail.com"
            });
            Usuarios.Add(new Usuario
            {
                Nome = "Victor Santos",
                Email = "@hotmail.com"
            });
            Usuarios.Add(new Usuario
            {
                Nome = "Caio Falco",
                Email = "l@hotmail.com"
            });
            Usuarios.Add(new Usuario
            {
                Nome = "Matheus Valente",
                Email = "pedroccrl@hotmail.com"
            });

        }

        private void Usuarios_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            NotifyPropertyChanged("Usuarios");
        }

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
