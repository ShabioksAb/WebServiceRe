using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WebServiceRES
{
    class pCancion
    {
        public string action { get; set; }
        public pCancion()
        {
            action = "mostrar_canciones";
        }
    };

    class resultsCanciones
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string artista { get; set; }
        public int idGenero { get; set; }
        public string genero { get; set; }
        public override string ToString()
        {
            return String.Format("{0} - {1}", nombre, artista);
        }
    };
}