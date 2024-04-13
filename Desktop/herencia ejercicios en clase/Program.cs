
using herencia_ejercicios_en_clase.Clasehija;

Nintendo sw= new Nintendo();
sw.EsPortatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "Nintendo Switch";

string resultado = sw.MostrarDetalleNintendo();
Console.WriteLine(resultado);

PlayStation ps = new PlayStation();
ps.ModeControlador = "graficos";
ps.AnioLanzamiento = 2015;
ps.Marca = "PlayStation 4";

Console.WriteLine(resultado);
