using System.Collections.Generic;
using TerritoryData.Lib.Entity;

namespace Module.TerritoryData.Web.Model
{
    public class Level2DivisionListResponse
    {
        public List<Level2Division> Divisions { get; set; } = new List<Level2Division>();
    }
}
