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
    }
}
