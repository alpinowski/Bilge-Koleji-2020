using BilgeKoleji2020.CORE.Entity;
using BilgeKoleji2020.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BilgeKoleji2020.MODEL.Entities
{
    public class Register:CoreEntity
    {
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "TC Kimlik Numarası:")]
        public string TcKimlikNumarasi { get; set; }
       
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "İsim Soyisim")]
        public string IsimSoyisim { get; set; }
        
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Cinsiyet")]
        public string Cinsiyet { get; set; }
        
        [Required(ErrorMessage = "Bu alan zorunludur"), Display(Name = "Geldiği Okul")]
        public string GeldigiOkul { get; set; }
        
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
