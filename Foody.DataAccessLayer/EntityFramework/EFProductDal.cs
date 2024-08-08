﻿using Foody.DataAccessLayer.Abstract;
using Foody.DataAccessLayer.Context;
using Foody.DataAccessLayer.Repositories;
using Foody.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.DataAccessLayer.EntityFramework
{
    public class EFProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly FoodyContext _context;

        public EFProductDal(FoodyContext context) : base(context)
        {
            _context = context;
        }

        public List<Product> ProductListWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            return values;
        }
    }
}
