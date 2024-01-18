﻿using Practica7AESM.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practica7AESM.Modelo
{
    public class Mcategorias : BaseViewModel
    {
        public string descripcion {  get; set; }
        public int numeroItem {  get; set; }
        public string imagen { get; set; }

        //objetos que interactuan con la interfaz
        public string _backgroundColor;
        public string _textColor;
        public bool _selected;
        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }
        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }
        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
