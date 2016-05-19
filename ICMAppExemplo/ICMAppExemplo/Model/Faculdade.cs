using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
namespace ICMAppExemplo.Model
{
    public class Faculdade
    {
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string Local { get; set; }
		public Posicao Posicao { get; set; }
		public List<Usuario> Alunos { get; set; }
    }

	public class Posicao
	{
		public double Latitude { get; set; }
		public double Longitude { get; set; }
	}
}
