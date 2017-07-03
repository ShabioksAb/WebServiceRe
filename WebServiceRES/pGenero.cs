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
    class pGenero
    {
    
        public string action { get; set; }
        //public int gender { get; set; }

        public pGenero()
        {
            action = "mostrar_generos";
        }
    };

    class resultsGenero
    {
        public string idgenero { get; set; }
        public string genero { get; set; }
        public override string ToString()
        {
            return String.Format("{0} ", genero);
        }

    };
}