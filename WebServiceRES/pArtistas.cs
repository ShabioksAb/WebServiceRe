﻿using System;
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
    class pArtistas
    {
        public string action { get; set; }
        public pArtistas()
        {
            action = "mostrar_artistas";
        }
    }

    class resultArtistas
    {

        public string artista { get; set; }

    };
}