﻿using InventoryManagementProject.Core.Interfaces;
using InventoryManagementProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMangementProject.Infrustructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(InventoryManagmentContext dbContext) : base(dbContext)
        {

        }
    }
}
