using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using InfraMgmt.Data;

namespace InfraMgmt.Models
{
    public class AssetModel
    {
        private InfraDbContext _ctx;
        public AssetModel(InfraDbContext ctx)
        {
            _ctx = ctx;
        }
        public List<Asset> GetAll()
        {
            List<Asset> assets = new List<Asset>();
            assets = _ctx.Assets.Select(a => a).ToList();
            return assets;
        }
    }
}
