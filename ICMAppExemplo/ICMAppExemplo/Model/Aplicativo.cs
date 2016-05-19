using System;
using System.Collections.Generic;
using ICMAppExemplo.Model;
using Xamarin.Forms;

namespace ICMAppExemplo
{
	public static class Aplicativo
	{
		public static List<Faculdade> Faculdades { get; set; } 

		public static void Init()
		{
			Faculdades = new List<Faculdade>();
			Faculdade ro = new Faculdade {
				Nome = "UFF",
				Foto = "http://www.uff.br/dalicenca/images/stories/logos/uff.jpg",
				Local = "Rio das Ostras",
				Posicao = new Posicao
				{
					Latitude = -22.50817,
					Longitude = -41.91525
				}
			};
			ro.Alunos = new List<Usuario>();
			List<Usuario> alunos1 = new List<Usuario>();
			for (int i = 0; i < 10; i++)
			{
				alunos1.Add(new Usuario
				{
					Nome = $"Aluno {i}",
					Email = $"Email {i}"
				});
			}

			ro.Alunos = alunos1;

			Faculdade niteroi = new Faculdade {
				Nome = "UFF",
				Foto = "http://www.uff.br/dalicenca/images/stories/logos/uff.jpg",
				Local = "Niterói",
				Posicao = new Posicao
				{
					Latitude = -22.89836,
					Longitude = -43.13205
				}
			};
			niteroi.Alunos = new List<Usuario>();
			List<Usuario> alunos2 = new List<Usuario>();
			for (int i = 0; i < 10; i++)
			{
				alunos1.Add(new Usuario
				{
					Nome = $"Aluno {i}",
					Email = $"Email {i}"
				});
			}


			niteroi.Alunos = alunos2;

			Faculdade voltaco = new Faculdade {
				Nome = "UFF",
				Foto = "http://www.uff.br/dalicenca/images/stories/logos/uff.jpg",
				Local = "Volta Redonda",
				Posicao = new Posicao
				{
					Latitude = -22.5062853,
					Longitude = -44.0867804
				}
			};
			voltaco.Alunos = new List<Usuario>();
			List<Usuario> alunos3 = new List<Usuario>();
			for (int i = 0; i < 10; i++)
			{
				alunos1.Add(new Usuario
				{
					Nome = $"Aluno {i}",
					Email = $"Email {i}"
				});
			}

			voltaco.Alunos = alunos3;

			Faculdades.Add(ro);
			Faculdades.Add(niteroi);
			Faculdades.Add(voltaco);
		}

	}


}
