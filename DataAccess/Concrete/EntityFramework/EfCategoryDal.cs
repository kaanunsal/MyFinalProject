﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }      
        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }
        public Category Get(System.Linq.Expressions.Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }
        public List<Category> GetAll(System.Linq.Expressions.Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
