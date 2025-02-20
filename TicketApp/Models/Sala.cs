namespace TicketApp.Models
{
    public class Sala
    {
        public string NomeSala { get; set; }
        public int BigliettiVenduti { get; set; } = 0;
        public int BigliettiRidotti { get; set; } = 0;
        public const int CapienzaMassima = 120;

        public bool Disponibile => BigliettiVenduti < CapienzaMassima;

    }
}
