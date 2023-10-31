using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Facturare.Lib
{
    public static class ConsolePrint
    {
        public static void Print(Furnizor furnizorInfo )
        {
            if (furnizorInfo is null)
            {
                Console.WriteLine("Atentie: valoare NULL!");
                return;

            }
            Console.WriteLine($"Nume: {furnizorInfo.numeFurnizor}");
            Console.WriteLine($"CIF-Cod Identificare Fiscala: {furnizorInfo.codFurnizor}");
            Console.WriteLine($"Adresa :  {GetAddressString(furnizorInfo.adresaFurnizor)}");
        }
        private static string GetAddressString(Adresa adresaFurnizor)
        {
            if (adresaFurnizor is null)
            {
                return string.Empty;
            }
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            bool addSeparator = false;

            addAddressPart(sb, adresaFurnizor.adresaTara, ref addSeparator);
            addAddressPart(sb, adresaFurnizor.adresaJudet, ref addSeparator);
            addAddressPart(sb, adresaFurnizor.adresaOras, ref addSeparator);
            addAddressPart(sb, adresaFurnizor.adresaStrada, ref addSeparator);
            addAddressPart(sb, adresaFurnizor.adresaNumar, ref addSeparator);
                        
            return sb.ToString();

        }


        private static void addAddressPart(System.Text.StringBuilder stringBuilder, string addressPart, ref bool addSeparator)
        {
            if (!string.IsNullOrWhiteSpace(addressPart))
            {
                if (addSeparator) { stringBuilder.Append(", "); }

                stringBuilder.Append(addressPart);

                addSeparator = true;

            }
        }

    }
}
