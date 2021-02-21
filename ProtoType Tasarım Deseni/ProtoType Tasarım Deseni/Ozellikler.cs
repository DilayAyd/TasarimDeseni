using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType_Tasarım_Deseni
{
    public class Ozellikler
    {
        public Ozellikler() { }

        public int KM { get; set; }
        public int RenkSecenegi { get; set; }
        public int Zipcode { get; set; }
        public string Ulke { get; set; }
        public override string ToString()
            
        {
            return string.Format("Detaylar : KM : {0}, Renk Secenegi: {1}, ZipCode : {2}," +
                " Ulke  : {3}", this.KM, this.RenkSecenegi, this.Zipcode.ToString(),
                this.Ulke);
        }
    }
}
