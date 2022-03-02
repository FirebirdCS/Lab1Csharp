
namespace Lab1.Edu.Kinal.Lab.Entities
{
    public class LlamadaInterior : Llamada
    {

        public LlamadaInterior(double precioUno, double precioDos, double precioTres, int franja)
        {

        }
        public double PrecioUno { get; set; }

        public double PrecioDos { get; set; }

        public double PrecioTres { get; set; }

        public int Franja { get; set; }

        public override double CalcularPrecio()
        {
            return this.Duracion * 0.0;
        }

        public override string ToString()
        {
            return "";
        }


    }
}