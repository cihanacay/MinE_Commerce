﻿using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductDal
    {
    }
}
