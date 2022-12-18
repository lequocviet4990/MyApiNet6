using API.CORE;
using API.CORE.Entities;
using API.CORE.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace API.DATA.Implement
{
  
    public class ProductModelRepository : GenericRepository<ProductModel>, IProductModelRepository
    {
        public ProductModelRepository(MovieContext context) : base(context)
        {
        }
      
    }
}
