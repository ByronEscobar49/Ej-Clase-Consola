using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia_ejercicios_en_clase.ClasePadre
{
    internal class Class1
    {
        public string Marca { get; set; }
        public int AnioLanzamiento { get; set; }
        public void MostrarDetalle()
        {
            Console.WriteLine($"Algo Nuevo Marca:{Marca}, año lanzamiento:{AnioLanzamiento}");
        }
    }
}

