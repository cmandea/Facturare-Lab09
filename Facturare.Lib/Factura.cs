namespace Facturare.Lib
{
    public class Factura
    {
        public Factura
            (
            string seriefactura,
            long numarfactura,
            DateTime datafactura
            )
        { 
            //trebuie facute validari: Null + NumarFactura-> Numeric
            serieFactura = seriefactura;
            numarFactura = numarfactura;
            dataFactura = datafactura;
        
        }





        public string serieFactura { get; }
        public long numarFactura {  get; }
        public DateTime dataFactura { get; }
    }
}