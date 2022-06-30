using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerritoryData.Lib.Entity.GeoPortal
{
    public class Miejscowosc
    {
        public long? cyklZyciaOd { get; set; }
        public long? waznyOd { get; set; }
        public string miejscIIPPn { get; set; }
        public string miejscIIPId { get; set; }
        public DateTime? miejscIIPWersja { get; set; }
        public string miejscNazwa { get; set; }
        public string miejscRodzaj { get; set; }
        public string miejscIdTeryt { get; set; }
        public string miejscNIIPPn { get; set; }
        public string miejscNIIPId { get; set; }
        public DateTime? miejscNIIPWersja { get; set; }
        public string miejscNNazwa { get; set; }
        public string miejscNRodzaj { get; set; }
        public string miejscNIdTeryt { get; set; }
    }
}
