using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.SERVICE.Option
{
    public class StudentService : BaseService<StudentAccount> 
    {
        public bool CheckUser(string _username, string _password)
        {
            return Any(x => x.TCKimlikNumarasi== _username && x.OkulNumarasi == _password);
        }
        //public bool CheckUser(string _OgrenciTCKimlikNumarasi, string _OkulNumarasi)
        //{
            //return Any(x => x.OgrenciTCKimlikNumarasi == _OgrenciTCKimlikNumarasi && x.OkulNumarasi == _OkulNumarasi && x.IsActive == true);
        //}
    }
}
