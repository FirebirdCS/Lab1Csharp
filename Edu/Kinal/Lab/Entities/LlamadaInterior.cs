
namespace Lab1.Edu.Kinal.Lab.Entities
{
    public class LlamadaInterior : Llamada
    {

        public LlamadaInterior() : base()
        {

        }

        public LlamadaInterior(string numeroOrigen, string numeroDestino, double duracion, int franja)
            : base(numeroOrigen, numeroDestino, duracion)
        {
            this.Franja = franja;
        }

        public double PrecioUno { get; set; } = 0.2;

        public double PrecioDos { get; set; } = 0.35;

        public double PrecioTres { get; set; } = 0.85;

        public int Franja { get; set; }

        public override double CalcularPrecio()
        {
            double resultado = 0;
            if (Franja == 1)
            {
                resultado = this.Duracion * this.PrecioUno;
            }
            else if (Franja == 2)
            {
                resultado = this.Duracion * this.PrecioDos;
            }
            else if (Franja == 3)
            {
                resultado = this.Duracion * this.PrecioTres;
            }
            return resultado;
        }

        override public string ToString()
        {
            return $"Registro: origen {NumeroOrigen} destino {NumeroDestino} con duracion {Duracion} s y la franja {Franja}.";
        }


    }
}