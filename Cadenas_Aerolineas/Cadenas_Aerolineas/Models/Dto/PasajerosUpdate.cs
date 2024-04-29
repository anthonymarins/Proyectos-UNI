namespace Cadenas_Aerolineas.Models.Dto
{
    public class PasajerosUpdate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string APaterno { get; set; }
        public string AMaterno { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public int IdPais { get; set; }
    }
}
