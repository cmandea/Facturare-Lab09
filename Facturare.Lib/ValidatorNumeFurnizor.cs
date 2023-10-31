namespace Facturare.Lib
{
    internal class ValidatorNumeFurnizor
    {
        internal ValidatorNumeFurnizor(string numeFurnizor) 
        {
            if (string.IsNullOrWhiteSpace(numeFurnizor))
            { 
            throw new ArgumentNullException(nameof(numeFurnizor), "Numele furnizorului nu poate fi null sau empty!");
            }

        }
    }
}
