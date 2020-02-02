using BilgeKoleji2020.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MODEL.Entities
{
    public class Lessons:CoreEntity
    {
        public string DersKodu { get; set; }
        public string DersAdi { get; set; }
        public int HaftalikDers { get; set; }

    }
}
