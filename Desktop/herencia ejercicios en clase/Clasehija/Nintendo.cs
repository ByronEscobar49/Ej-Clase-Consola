using herencia_ejercicios_en_clase.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_ejercicios_en_clase.Clasehija
{
    internal class Nintendo : Class1
    {
        public bool EsPortatil { get; set; }
        public string MostrarDetalleNintendo()
        {
            MostrarDetalle();
            return $"Es portatil: {EsPortatil}";
        }
    }
}
