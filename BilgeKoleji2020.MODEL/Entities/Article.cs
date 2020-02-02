using BilgeKoleji2020.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MODEL.Entities
{
    public class Article:CoreEntity
    {
        public string Header { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public virtual Login Owner { get; set; }
    }
}
