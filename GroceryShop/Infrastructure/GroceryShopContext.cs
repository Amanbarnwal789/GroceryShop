using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryShop.Infrastructure
{
    public class GroceryShopContext : DbContext
    {
        public GroceryShopContext(DbContextOptions<GroceryShopContext> options)
            :base(options)
        {

        }
    }
}
