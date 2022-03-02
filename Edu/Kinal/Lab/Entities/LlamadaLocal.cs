namespace Lab1.Edu.Kinal.Lab.Entities
{
    public class LlamadaLocal : Llamada
    {
        public LlamadaLocal(double precio)
        {

        }
        public double Precio { get; set; }

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