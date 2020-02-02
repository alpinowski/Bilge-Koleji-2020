using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class LessonsMap:CoreMap<Lessons>
    {
        public LessonsMap()
        {
            ToTable("dbo.Lessons");
            Property(x => x.DersAdi).IsRequired();
            Property(x => x.DersKodu).IsRequired();
            Property(x => x.HaftalikDers).IsRequired();
        }
    }
}
