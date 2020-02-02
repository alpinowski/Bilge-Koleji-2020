using BilgeKoleji2020.CORE.Entity;
using BilgeKoleji2020.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.CORE.Map
{
    public class CoreMap<T> : EntityTypeConfiguration<T> where T : CoreEntity
    {
        public CoreMap()
        {
            Property(x => x.CreatedDate).HasColumnName("Created Date");
        }
    }
}
