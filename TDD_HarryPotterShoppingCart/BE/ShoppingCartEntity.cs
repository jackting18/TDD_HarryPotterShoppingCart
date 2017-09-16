using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HarryPotterShoppingCart.BE
{
    public class ShoppingCartEntity
    {
        public ShoppingCartEntity()
        {
            this.SalePageList = new List<SalePageEntity>();
        }

        public List<SalePageEntity> SalePageList { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
