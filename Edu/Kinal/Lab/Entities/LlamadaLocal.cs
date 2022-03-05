namespace Lab1.Edu.Kinal.Lab.Entities
{
    public class LlamadaLocal : Llamada
    {
        public LlamadaLocal(string numeroOrigen, string numeroDestino, double duracion)
            : base(numeroOrigen,numeroDestino,duracion)
        {

        }

        public LlamadaLocal() : base()
        {

        }
        public double Precio { get; set; } = 0.25;

        public override double CalcularPrecio()
        {
            return this.Duracion * this.Precio;
        }

        override public string ToString()
        {
            return $"Registro: origen{NumeroOrigen} destino {NumeroDestino} con duracion {Duracion} s.";
        }
    }
}