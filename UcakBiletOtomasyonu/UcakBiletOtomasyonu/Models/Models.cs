using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletOtomasyonu.Models
{
    public class Havayolu
    {
        public int HavayoluId { get; set; }
        public string HavayoluSirketi { get; set; }
    }

    public class Ucak
    {
        public int UcakId { get; set; }
        public int Model { get; set; }
        public string Marka { get; set; }
        public int SeriNumarasi { get; set; }
        public int Kapasite { get; set; }
    }

    public class Lokasyon
    {
        public int LokasyonId { get; set; }
        public string Sehir { get; set; }
        public string Ulke { get; set; }
        public string AktifMi { get; set; }
    }

    public class Ucus
    {
        public int UcusId { get; set; }
        public int LokasyonId { get; set; }
        public int Tarih { get; set; }
        public int UcakId { get; set; }

        public class Rezervasyon
        {
            public int id { get; set; }
            public string koltukNo { get; set; }
            public int UcusId { get; set; }
        }
    }
}