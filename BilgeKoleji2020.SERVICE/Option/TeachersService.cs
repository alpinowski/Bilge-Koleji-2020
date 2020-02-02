using BilgeKoleji2020.MODEL.Entities;
using BilgeKoleji2020.SERVICE.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.SERVICE.Option
{
    public class TeachersService:BaseService<TeacherAccount>
    {
        public bool CheckUser(string _username, string _password)
        {
            return Any(x => x.Username == _username && x.Password == _password);
        }
    }
}
