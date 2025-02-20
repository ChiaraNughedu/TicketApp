namespace TicketApp.Models
{
    public static class DatiCinema
    {
        public static List<Biglietto> BigliettiVenduti = new List<Biglietto>();

        public static List<Sala> Sale = new List<Sala>
        {
            new Sala { NomeSala = "Sala Nord" },
            new Sala { NomeSala = "Sala Sud" },
            new Sala { NomeSala = "Sala Est" }
        };
    }
}
