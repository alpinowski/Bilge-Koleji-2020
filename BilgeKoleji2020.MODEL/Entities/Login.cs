using BilgeKoleji2020.CORE.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MODEL.Entities
{
    public class Login:CoreEntity
    {
        public Login()
            {
                IsActive = false;
            }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Parola:")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "TC Kimlik Numarası:")]
        public string OgrenciTCKimlikNumarasi { get; set; }
        [Required(ErrorMessage = "Bu alan zorunludur."), Display(Name = "Okul Numarası:")]
        public string OkulNumarasi { get; set; }
        public bool IsActive { get; set; }
    }
}
