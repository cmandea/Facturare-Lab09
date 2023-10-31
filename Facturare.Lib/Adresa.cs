namespace Facturare.Lib
{
    public class Adresa
    {
        public Adresa
         (string adresatara,
          string adresajudet,
          string adresaoras,
          string adresastrada,
          string adresanumar
         )
        {
            adresaTara = adresatara;
            adresaJudet = adresajudet;
            adresaOras = adresaoras;
            adresaStrada = adresastrada;
            adresaNumar = adresanumar;
        }
        public string adresaTara { get; }
        public string adresaJudet { get; }
        public string adresaOras { get; }
        public string adresaStrada { get; }
        public string adresaNumar { get; }


        /*
           if (string.IsNullOrWhiteSpace(adresaTara))
           { 
               throw new ArgumentNullException(nameof(adresaTara),"Introduceti Tara!");
           }
           if (string.IsNullOrWhiteSpace(adresaJudet))
           {
               throw new ArgumentNullException(nameof(adresaJudet), "Introduceti Judetul!");
           }
           if (string.IsNullOrWhiteSpace(adresaOras))
           {
               throw new ArgumentNullException(nameof(adresaOras), "Introduceti Orasul!");
           }
           if (string.IsNullOrWhiteSpace(adresaStrada))
           {
               throw new ArgumentNullException(nameof(adresaStrada), "Introduceti Strada!");
           }
           if (string.IsNullOrWhiteSpace(adresaNumar))
           {
               throw new ArgumentNullException(nameof(adresaNumar), "Introduceti Numarul!");
           }*/

    }
}
