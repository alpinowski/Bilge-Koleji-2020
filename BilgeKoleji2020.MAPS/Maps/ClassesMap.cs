using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class ClassesMap:CoreMap<Classes>
    {
        public ClassesMap()
        {
            ToTable("dbo.Classes");
            Property(x => x.SubeNumarasi).IsRequired().HasColumnName("ID");
            Property(x => x.Sube).IsRequired().HasColumnName("Şube");
        }
    }
}
