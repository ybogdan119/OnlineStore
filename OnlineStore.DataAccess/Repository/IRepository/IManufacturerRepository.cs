﻿using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Repository.IRepository
{
    public interface IManufacturerRepository : IRepository<Manufacturer>
    {
        void Update(Manufacturer manufacturer);
    }
}
