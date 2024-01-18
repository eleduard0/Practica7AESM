using Practica7AESM.Modelo;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Practica7AESM.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/m07K8X4/cena.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Hotel",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/pfJJggj/hotel.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Fiesta",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/0KmHM84/fiesta.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Flores",
                    numeroItem = 4512,
                    imagen = "https://i.ibb.co/fNHxKYv/flores.png",
                    backgroundColor = "#EAEDF6",
                    textColor = "#000000"
                },
            };
        }
    }
}
