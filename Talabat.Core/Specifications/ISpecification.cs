﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entities;

namespace Talabat.Core.Specifications
{
    public interface ISpecification<T> where T : BaseEntity
    {
        
        // _dbcontext.Products.WHERE(P=>P.ID==ID).Include(p=>p.ProductBrand).Include(p=>p.ProductType).ToListAsync();

        //SIGN FOR PRoperty for where condition
        //expression<lambda type> criterie{}
        //lambda =>delegate[fun,predicate,action]
        //fun=> return bool or predicate retun bool

        public Expression<Func<T,bool>> Criteria { get; set; }

        //sign for property for list of include

        //List<expression<lambda>include

        public List<Expression<Func<T,object>>> Include { get; set; }

    }
}
