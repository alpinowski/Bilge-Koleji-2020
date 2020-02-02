using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class PreRegisterMap : CoreMap<PreRegister>
    {
        public PreRegisterMap()
        {
            ToTable("dbo.PreRegister");
            Property(x => x.TcKimlikNumarasi).IsRequired().HasColumnName("TC Kimlik Numarası");
            Property(x => x.OgrenciIsimSoyisim).IsRequired().HasColumnName("Öğrenci Adı Soyadı");
            Property(x => x.Cinsiyet).IsRequired().HasColumnName("Cinsiyet");
            Property(x => x.BitirdiğiOkul).IsRequired().HasColumnName("Bitirdiği Okul");
            Property(x => x.NotOrtalaması).IsRequired().HasColumnName("Not Ortalaması");
            Property(x => x.VeliAdSoyad).IsRequired().HasColumnName("Veli Adı Soyadı");
            Property(x => x.CepTelefonu).IsRequired().HasColumnName("Cep Telefonu");
            Property(x => x.DigerTelefon).IsOptional().HasColumnName("Diğer Telefon");
            Property(x => x.EvAdresi).IsRequired().HasMaxLength(200).HasColumnName("Ev Adresi");
            Property(x => x.IlçeIl).IsRequired().HasColumnName("İlçe ve İl");
        }
    }
}
