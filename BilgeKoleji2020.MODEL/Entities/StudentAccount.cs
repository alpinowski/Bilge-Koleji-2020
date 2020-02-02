using BilgeKoleji2020.CORE.Entity;
using BilgeKoleji2020.MODEL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MODEL.Entities
{
    public class StudentAccount:CoreEntity
    {
       
        
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "TC Kimlik Numarası:")]
        public string TCKimlikNumarasi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Okul Numarası:")]
        public string OkulNumarasi { get; set; }
        public string Sinif { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Adı")]
        public string Adi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Soyadı")]
        public string Soyadi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Cinsiyet")]
        public string Cinsiyet { get; set; }
        public string Password { get; set; }


    }
}
