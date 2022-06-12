using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.TerritoryData.Lib.GeoPortal
{
    public class JednAdm
    {
        public long cyklZyciaOd { get; set; }
        public long waznyOd { get; set; }
        public int poziom { get; set; }

        public string wojNazwa { get; set; }
        public string wojIdTeryt { get; set; }
        public string wojIIPPn { get; set; }
        public string wojIIPId { get; set; }
        public DateTime wojIIPWersja { get; set; }

        public string powNazwa { get; set; }
        public string powIdTeryt { get; set; }
        public string powIIPPn { get; set; }
        public string powIIPId { get; set; }
        public DateTime powIIPWersja { get; set; }

        public string gmNazwa { get; set; }
        public string gmIdTeryt { get; set; }
        public string gmIIPPn { get; set; }
        public string gmIIPId { get; set; }
        public DateTime gmIIPWersja { get; set; }
    }
}
