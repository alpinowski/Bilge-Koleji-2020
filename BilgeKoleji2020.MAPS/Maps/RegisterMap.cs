using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class RegisterMap:CoreMap<Register>
    {
        public RegisterMap()
        {
            ToTable("dbo.Register");
            Property(x => x.TcKimlikNumarasi).IsRequired().HasColumnName("TC Kimlik Numarası");
            Property(x => x.IsimSoyisim).IsRequired().HasColumnName("Adı Soyadı");
            Property(x => x.Cinsiyet).IsRequired().HasColumnName("Cinsiyet");
            Property(x => x.GeldigiOkul).IsRequired().HasColumnName("Geldiği Okul");
            Property(x => x.CepTelefonu).IsRequired().HasColumnName("Cep Telefonu");
            Property(x => x.DigerTelefon).IsOptional().HasColumnName("Diğer Telefon");
            Property(x => x.EvAdresi).IsRequired().HasMaxLength(200).HasColumnName("Ev Adresi");
            Property(x => x.IlçeIl).IsRequired().HasColumnName("İlçe ve İl");
        }
    }
}
