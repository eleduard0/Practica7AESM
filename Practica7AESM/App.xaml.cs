﻿using Practica7AESM.Vistas;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica7AESM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PaginaCategoria();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
