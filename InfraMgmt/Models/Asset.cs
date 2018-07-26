using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InfraMgmt.Models
{
    public class Asset
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public string Serial { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public DateTime CheckoutDate { get; set; }
        public DateTime CheckinDate { get; set; }
    }
}
