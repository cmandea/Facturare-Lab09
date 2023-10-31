namespace Facturare.Lib
{
    public class Furnizor
    {
        public Furnizor
            (
            string numefurnizor,
            string codfurnizor,
            Adresa adresafurnizor
            )
        { 
            numeFurnizor = numefurnizor;
            codfurnizor=EliminaSpatii.SirFaraSpatiiSiLitereMari(codfurnizor);
            
            if (!ValidatorCIF.CodIdentificareFiscalaValid(codfurnizor))
            {
                return;
            }
            else
            {
                codFurnizor= codfurnizor;
                adresaFurnizor = adresafurnizor;
            }
        }

        public string numeFurnizor { get; }
        public string codFurnizor { get; }
        public Adresa adresaFurnizor { get; private set; }

            
    }
}
