using BilgeKoleji2020.CORE.Map;
using BilgeKoleji2020.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.MAPS.Maps
{
    public class ArticleMap: CoreMap<Article>
    {
        public ArticleMap()
        {
            ToTable("dbo.Articles");
            Property(x => x.Header).IsRequired();
            Property(x => x.Description).IsRequired();
            Property(x => x.Content).IsRequired();
        }
        
    }
}
