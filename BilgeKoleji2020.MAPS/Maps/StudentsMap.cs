using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class StudentAccountMap:CoreMap<StudentAccount>
    {
        public StudentAccountMap()
        {
            ToTable("dbo.Students");
            Property(x => x.Adi).IsRequired().HasColumnName("Adı");
            Property(x => x.Soyadi).IsRequired().HasColumnName("Soyadı");
            Property(x => x.TCKimlikNumarasi).IsRequired().HasColumnName("Tc Kimlik Numarası");
            Property(x => x.OkulNumarasi).IsRequired().HasColumnName("Okul Numarası");
            Property(x => x.Sinif).IsRequired().HasColumnName("Sınıf");
            Property(x => x.Cinsiyet).IsRequired().HasColumnName("Cinsiyet");
           
           


        }
    }
}
