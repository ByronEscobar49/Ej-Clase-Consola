using herencia_ejercicios_en_clase.ClasePadre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_ejercicios_en_clase.Clasehija
{
    internal class PlayStation : Class1
    {
        public string ModeControlador { get; set; }
        public string MostrarDetallesPS()
        {
            MostrarDetalle();
            return $"Modelo de Controlador:{ModeControlador}";
        }
    }
}
