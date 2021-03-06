using System;

namespace AP2_POO.ViewModels
{
    public class ContaCreateViewModel
    {
        public ContaCreateViewModel( int numLeitura, 
        int kmgasto, double valorPagar)
        {
            
            this.NumLeitura = numLeitura;
            this.KwGasto = kmgasto;
            this.ValorPagar = valorPagar;
        }
        public ContaCreateViewModel()
        {
            
        }

        public int NumLeitura { get; set; }
        public int KwGasto { get; set; }
        public double ValorPagar { get; set; }
    }
}