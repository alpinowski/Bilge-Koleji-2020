using BilgeKoleji2020.CORE.Entity;
using BilgeKoleji2020.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MODEL.Entities
{

    
    public class PreRegister : CoreEntity
    {
     
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "TC Kimlik Numarası:")]
        public string TcKimlikNumarasi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Öğrenci İsim Soyisim")]
        public string OgrenciIsimSoyisim { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Cinsiyet")]
        public string Cinsiyet { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Bitidiği Okul")]
        public string BitirdiğiOkul { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Not Ortalaması")]
        public decimal NotOrtalaması { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Veli Ad Soyad")]
        public string VeliAdSoyad { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Cep Telefonu")]
        public int CepTelefonu { get; set; }
        [Display(Name = "Diğer Telefon")]
        public int DigerTelefon { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Ev Adresi")]
        public string EvAdresi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "İlçe ve İl")]
        public string IlçeIl { get; set; }
        public Roles? Role { get; set; }
    }
}
