using Lab1.Edu.Kinal.Lab.Entities;

namespace Lab1.Edu.Kinal.Lab.Interfaz
{
    public interface ICentralTelefonica
    {
        public int Contador { get; set; }

        public double Acumulador { get; set; }

        public int GetTotalLlamadas();

        public double GetTotalFacturas();

        public void RegistrarLlamada(Llamada llamada);
    }
}