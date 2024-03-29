﻿using BilgeKoleji2020.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeKoleji2020.CORE.Service
{
    public interface ICoreService<T> where T:CoreEntity
    {
        void Add(T item);
        void Add(List<T> item);
        void Remove(T item);
        void Update(T item);
        List<T> GetAll();
        List<T> GetActive();
    }
}
