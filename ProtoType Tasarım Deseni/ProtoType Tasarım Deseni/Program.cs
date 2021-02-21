using System;


namespace ProtoType_Tasarım_Deseni
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ShallowCopy();
            
        }

        public static void ShallowCopy()
        {
            Arac araba1 = new Arac()
            {
                Id = Guid.NewGuid(),
                Isim = "Opel",
                AracKodu = 150,
            };

            Console.WriteLine(araba1.ToString());

            Arac araba2 = (Arac)araba1.Clone();
            araba2.Isim = "Ford";
            Console.WriteLine(araba2.ToString());

            Console.WriteLine("Araba 1'in Kodu 161 ile değiştirildi");
            araba1.AracKodu = 161;
            Console.WriteLine(araba1.ToString());
            Console.WriteLine(araba2.ToString());

            Console.ReadLine();
            
        }
        
        public static void ShallowCopyRef()
        {
            Arac Araba1 = new Arac()
            {
                Id = Guid.NewGuid(),
                Isim = "Opel",
                AracKodu = 150,

                Detaylar = new Ozellikler()
                {
                    KM = 10,
                    RenkSecenegi = 5,
                  
                    Ulke = "Almanya"
                }
            };
            Console.WriteLine(Araba1.ToString());

            Arac Araba2 = (Arac)Araba1.Clone();
            Araba2.Isim = "Ford";
            Araba2.AracKodu = 151;
            Araba2.Detaylar.RenkSecenegi = 7;
            Araba2.Detaylar.KM = 11;
            Araba2.Detaylar.Ulke = "Amerika";

            Console.WriteLine(Araba2.ToString());

            Console.WriteLine("Araba 1'in detayları değiştirildi");
            Araba1.Detaylar.KM = 30;
            Araba1.Detaylar.RenkSecenegi = 6;

            Araba1.AracKodu = 160;
            Console.WriteLine(Araba1.ToString());
            Console.WriteLine(Araba2.ToString());

            Console.ReadLine();

        }
    }
}
