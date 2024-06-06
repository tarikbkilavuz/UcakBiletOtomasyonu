using UcakBiletOtomasyonu.Data;
using UcakBiletOtomasyonu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcakBiletOtomasyonu.Services
{
    public class HavayoluServis
    {
        AppDbContext _dbContext = new AppDbContext();

        public List<Havayolu> GetAll()
        {
            return _dbContext.Havayolu.ToList();
        }

        public Havayolu GetHavayoluDetailsBasedOnHavayoluId(int HavayoluId)
        {
            return _dbContext.Havayolu.FirstOrDefault(m => m.HavayoluId == HavayoluId);
        }
    }

    public class UcusServis
    {
        AppDbContext _dbContext = new AppDbContext();

        public List<Ucus> GetAll()
        {
            return _dbContext.Ucus.ToList();
        }
        public List<Ucus> HavayoluListele(string HavayoluSirketi)
        {
            var ucuslar = _dbContext.Ucus
                                     .Join(_dbContext.Ucus,
                                           Lokasyon => Lokasyon.LokasyonId,
                                           Ucak => Ucak.UcusId,
                                           (Lokasyon, Ucak) => new { Lokasyon = Lokasyon, Havayolu = Ucak }
                                     .Where(x => x.HavayoluSirketi == HavayoluSirketi)
                                     .Select(x => x.Ucus)
                                     .ToList());

            return ucuslar;
        }
        public Ucus GetUcusDetailsBasedOnUcusId(int UcusId)
        {
            return _dbContext.Ucus.FirstOrDefault(s => s.UcusId == UcusId);
        }
    }


    public class RezervasyonServis
    {

    }
}
