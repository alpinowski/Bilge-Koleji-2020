using BilgeKoleji2020.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MODEL.Entities
{
    public class TeacherAccount:CoreEntity
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Brans { get; set; }
        public string Sira { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
