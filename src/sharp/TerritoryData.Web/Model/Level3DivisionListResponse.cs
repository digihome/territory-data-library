using System.Collections.Generic;
using TerritoryData.Lib.Entity;

namespace Module.TerritoryData.Web.Model
{
    public class Level3DivisionListResponse
    {
        public List<Level3Division> Divisions { get; set; } = new List<Level3Division>();
    }
}
