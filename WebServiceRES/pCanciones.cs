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
    class pCanciones
    {
        public string action { get; set; }
        public pCanciones()
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

    };
}