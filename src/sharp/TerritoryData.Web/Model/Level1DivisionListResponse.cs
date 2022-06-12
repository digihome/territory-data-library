using System.Collections.Generic;
using TerritoryData.Lib.Entity;

namespace Module.TerritoryData.Web.Model
{
    public class Level1DivisionListResponse
    {
        public List<Level1Division> Divisions { get; set; } = new List<Level1Division>();
    }
}
