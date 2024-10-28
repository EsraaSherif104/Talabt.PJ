﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talabat.Core.Specifications
{
    public class ProductSpecParam
    {
        //  string? sort,int? BrandID,int? TypeId

        public string? sort { get; set; }
        public int? BrandID { get; set; }

        public int? TypeId { get; set;}

        private int pageSize=5;

        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value>10?10:value; }
        }

        public int PageIndex { get; set; } = 1;





    }
}