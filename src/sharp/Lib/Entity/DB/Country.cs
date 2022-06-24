using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TerritoryData.Lib.Entity.DB
{
    /// <summary>
    /// Country representation (ISO 3166-1 alpha-2 standard)
    /// </summary>
    public class Country
    {
        public string Id { get; set; }
        [MaxLength(2)]
        public string Code { get; set; }
        public string Name { get; set; }

    }
}
