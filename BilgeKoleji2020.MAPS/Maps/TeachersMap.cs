using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class TeacherAccountMap : CoreMap<TeacherAccount>
    {
        public TeacherAccountMap()
        {
            ToTable("dbo.Teachers");
            Property(x => x.Adi).IsRequired().HasColumnName("Adı");
            Property(x => x.Soyadi).IsRequired().HasColumnName("Soyadı");
            Property(x => x.Brans).IsRequired().HasColumnName("Branş");
            Property(x => x.Sira).IsRequired().HasColumnName("Sırası");
            Property(x => x.Username).IsRequired().HasColumnName("Kullanıcı Adı");
            Property(x =>x.Password).IsRequired().HasColumnName("Şifre");
        }
    }
   
}
