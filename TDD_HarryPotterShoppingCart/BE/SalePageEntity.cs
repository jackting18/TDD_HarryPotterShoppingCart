using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_HarryPotterShoppingCart.BE
{
    /// <summary>
    /// SalePageEntity
    /// </summary>
    public class SalePageEntity
    {
        /// <summary>
        /// Id
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Qty
        /// </summary>
        public int Qty { get; set; }

        /// <summary>
        /// Price
        /// </summary>
        public decimal Price { get; set; }
    }
}
