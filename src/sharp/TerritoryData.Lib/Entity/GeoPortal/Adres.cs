using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerritoryData.Lib.Entity.GeoPortal
{
    public class Adres
    {
        public long? cyklZyciaOd { get; set; }
        public string pktPrgIIPPn { get; set; }
        public string pktPrgIIPId { get; set; }
        public DateTime? pktPrgIIPWersja { get; set; }
        public string pktEmuiaIIPPn { get; set; }
        public string pktEmuiaIIPId { get; set; }
        public DateTime? pktEmuiaIIPWersja { get; set; }
        public string pktNumer { get; set; }
        public string pktStatus { get; set; }
        public string pktKodPocztowy { get; set; }
        public decimal? pktX { get; set; }
        public decimal? pktY { get; set; }
        public decimal? pktLat { get; set; }
        public decimal? pktLon { get; set; }
    }
}
