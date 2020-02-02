using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class LoginMap:CoreMap<Login>
    {
        public LoginMap()
        {
            ToTable("dbo.Login");
            Property(x => x.OgrenciTCKimlikNumarasi).IsRequired();
            Property(x => x.OkulNumarasi).IsRequired();
            Property(x => x.UserName).IsRequired();
            Property(x => x.Password).IsRequired();
        }
    }
}
