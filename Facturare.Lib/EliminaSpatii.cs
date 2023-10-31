namespace Facturare.Lib
{
    internal class EliminaSpatii
    {
        public static string SirFaraSpatiiSiLitereMari(string sir) 
        {
            if (string.IsNullOrWhiteSpace(sir))
            {
                return sir;
            }
            string sirNou ="";
            

            foreach (char c in sir) 
            { 
            if (string.IsNullOrWhiteSpace(c.ToString()))
                { continue; }
            sirNou=sirNou+c.ToString();
            }
            
            return sirNou.ToUpper();
        }
    }
}
