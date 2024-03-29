﻿using BilgeKoleji2020.CORE.Entity.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.CORE.Entity
{
   public class CoreEntity:IEntity<Guid>
    {
        public CoreEntity()
        {
            this.CreatedDate = DateTime.Now;
            this.Status = Status.Created;
        }

    
        public Guid ID { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
