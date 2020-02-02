using BilgeKoleji2020.DAL.Model.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.DAL.Model
{
    public class SampleData:CreateDatabaseIfNotExists<KolejContext>
    {
    }
}
