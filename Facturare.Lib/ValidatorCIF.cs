using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Facturare.Lib
{
    internal class ValidatorCIF
    {
        public static bool CodIdentificareFiscalaValid(string codFiscal)
        {
            //verific daca e null
            if (string.IsNullOrWhiteSpace(codFiscal))
            { 
            throw new ArgumentNullException(nameof(codFiscal), "Introduceti un CIF valid !");
                
            }

            //procedura de verificare CIF

            //verific daca primele 2 caractere sunt 'RO'
            string atributFiscal = codFiscal.Substring(0, 2);
            if (atributFiscal != "RO")
            {
                //throw new ArgumentNullException(nameof(atributFiscal), "Atributul fiscal nu este RO!");
                Console.WriteLine($"Atributul cod fiscal '{atributFiscal}' este incorect!");

                return false;
            }
            //maxim 12 caractere
            if (codFiscal.Length >12)
            {
                //throw new ArgumentNullException(nameof(atributFiscal), "Atributul fiscal nu este RO!");
                Console.WriteLine($"Cod Fiscal '{codFiscal}' incorect!\nDimensiune mai mare de 12 caractere!");

                return false;
            }
                        
            //3->11 >numarul de identificarefiscala+cifra de control >max 10 caractere
            //(testez si ultimul caracter sa fie numeric)
            string txtNumar=codFiscal.Substring (2, codFiscal.Length-2);
            bool fNumar=long.TryParse(txtNumar,out long result);
            if (!fNumar)
            {
                Console.WriteLine($"Codul Fiscal '{codFiscal}' este incorect!\n" +
                                  $"Secventa '{txtNumar}' care urmeaza dupa atributul fiscal '{atributFiscal}' nu este numerica!");
                return false;
            }
            
            //daca txtnumar (numar de control+numar de verificare) este <2 >eroare
            if (txtNumar.Length <2 || txtNumar.Length>10) 
            {
                Console.WriteLine($"Codul Fiscal '{codFiscal}' este incorect!\nSecventa de verificare + cifra de verificare '{txtNumar}'\n" +
                                  $"care urmeaza dupa atributul fiscal '{atributFiscal}' nu are dimensiune intre 2 si 10 caractere!");
                return false;
            }
            
             //declar cheia de testare 753217532

            const string cheie = "753217532";
             
            Int32.TryParse(txtNumar.Substring(txtNumar.Length-1, 1),out Int32 txtCifraControl);//am cifra de control din Codul Fiscal
            txtNumar =txtNumar.Substring(0,txtNumar.Length-1); //extrag din cod ultima cifra care este cifra de control
            //nu mai inversez codurile pt ca cifrele din coduri se vor inmulti pe pozitii
            //trebuie sa formatez txtNumar la 9 caractere >adaug 0 la final

            for (int i = txtNumar.Length+1; i<10; i++)
            { 
                txtNumar = "0"+txtNumar;//nu mai inversam codurile si atunci adaugam la inceputul sirului 
            }
            //acum trebuie sa inmultesc cifrele de pe pozitii din cele 2 coduri si sa le adun rezultatele
            Int32 xSuma = 0;
            //string[] txtCodFiscal = new string[] { txtNumar };
            //string[] txtCheie = new string[] { cheie };
           

            for (Int32 i = 0; i < 9; i++)
            {

                Int32 x = Convert.ToInt32(txtNumar[i].ToString());
                Int32 y = Convert.ToInt32(cheie[i].ToString());
               // Console.WriteLine($"Elementele sunt x:{x} si y:{y}.");
                 Int32 xInmultire =x * y;
                //Console.WriteLine($"Inmultirea este:{xInmultire}.");
                xSuma += xInmultire;

            }
           //Console.WriteLine($"Codul fara cifra de control este {txtNumar}.");
            //Console.WriteLine($"Cifra de control este {txtCifraControl}.");
            //Console.WriteLine($"Cheia de control este {cheie}.");
            //Console.WriteLine($"Suma inmultirilor este {xSuma}.");

            xSuma = xSuma * 10;
            //Console.WriteLine($"Suma inmultiri cu 10 este {xSuma}.");
            xSuma=xSuma /11;
            //Console.WriteLine($"Suma impartirii la 11 este {xSuma}.");
            long xCifraVerificare = xSuma % 11;
            //Console.WriteLine($"Cifra de verificare este {xCifraVerificare}.");
            if (xCifraVerificare != Convert.ToInt32(txtCifraControl.ToString()))
            {
                Console.WriteLine($"Cod identificare fiscala {codFiscal} invalid!");
                return false;
            }
            Console.WriteLine($"Cod identificare fiscala {codFiscal} valid!");
            return true;


            

        }

    }
}
