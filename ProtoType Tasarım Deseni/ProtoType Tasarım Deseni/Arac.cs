using System;
using System.Collections.Generic;
using System.Text;

namespace ProtoType_Tasarım_Deseni
{
    public partial class Arac
    {
        public Ozellikler Detaylar { get; set; }
    }
    public partial class Arac
    {
        

        public Guid Id { get; set; }
        public string Isim { get; set; }
        public int AracKodu { get; set; }
        

        public override string ToString()
        {
            return string.Format(" Isim : {0}  " + "Arac Kodu : {1}  ",
                this.Isim, this.AracKodu.ToString());
        }
    }
    public partial class Arac: ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
   

}
