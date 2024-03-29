﻿using OnlineStore.DataAccess.Data;
using OnlineStore.DataAccess.Repository.IRepository;
using OnlineStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataAccess.Repository
{
    public class ManufacturerRepository : Repository<Manufacturer>, IManufacturerRepository
    {
        private ApplicationDbContext _db;

        public ManufacturerRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Manufacturer> UpdateAsync(Manufacturer manufacturer)
        {
            //manufacturer.UpdatedDate = DateTime.Now;
            _db.Manufacturers.Update(manufacturer);
            await _db.SaveChangesAsync();
            return manufacturer;    
        }
    }
}
