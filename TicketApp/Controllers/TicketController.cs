using Microsoft.AspNetCore.Mvc;
using TicketApp.Models;

namespace TicketApp.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Index()
        {
            return View(DatiCinema.Sale);  
        }

        [HttpPost]
        public IActionResult Prenota(string nome, string cognome, string sala, string tipoBiglietto)
        {
            var salaSelezionata = DatiCinema.Sale.FirstOrDefault(s => s.NomeSala == sala);

            if (salaSelezionata == null || !salaSelezionata.Disponibile)
            {
                ViewBag.Messaggio = "Sala piena o non disponibile!";
                return View("Index", DatiCinema.Sale);
            }

            var biglietto = new Biglietto
            {
                Ospite = new Ospite { Nome = nome, Cognome = cognome },
                Sala = sala,
                TipoBiglietto = tipoBiglietto
            };

            
            DatiCinema.BigliettiVenduti.Add(biglietto);
            salaSelezionata.BigliettiVenduti++;

            if (tipoBiglietto == "Ridotto")
            {
                salaSelezionata.BigliettiRidotti++;
            }

            return RedirectToAction("Index");
        }
    }
}
