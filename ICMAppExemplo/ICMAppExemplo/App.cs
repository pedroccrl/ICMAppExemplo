﻿using ICMAppExemplo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ICMAppExemplo
{
	public class App : Application
	{
		public App ()
		{
			Aplicativo.Init();
            MainPage = NavegacaoPage.Instance;
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
