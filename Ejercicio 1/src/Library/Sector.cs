using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string SectorLetter {get; set;}

        public List<Shelve> ShelveInSector {get;} = new List<Shelve>();
        public Sector(string newSector)
        {
            this.SectorLetter = newSector;
        }

        public void AddShelve(Shelve shelve)
        {
            ShelveInSector.Add(shelve);
        }
    }
}