using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_HarryPotterShoppingCart.BE;

namespace TDD_HarryPotterShoppingCart.Test
{
    public class ShoppingCartTestData
    {
        public static IEnumerable<object[]> TestData
        {
            get
            {
                return new[]
                {
                    new object[]
                    {
                        new ShoppingCartEntity
                        {
                            SalePageList = new List<SalePageEntity>()
                            {
                                new SalePageEntity(){Id = 1, Price = 100, Qty = 1}
                            }
                        },
                        100M
                    },
                    new object[]
                    {
                        new ShoppingCartEntity
                        {
                            SalePageList = new List<SalePageEntity>()
                            {
                                new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 2, Price = 100, Qty = 1}
                            }
                        },
                        190M
                    },
                    new object[]
                    {
                        new ShoppingCartEntity
                        {
                            SalePageList = new List<SalePageEntity>()
                            {
                                new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 3, Price = 100, Qty = 1}
                            }
                        },
                        270M
                    },
                    new object[]
                    {
                        new ShoppingCartEntity
                        {
                            SalePageList = new List<SalePageEntity>()
                            {
                                new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 3, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 4, Price = 100, Qty = 1}
                            }
                        },
                        320M
                    },
                    new object[]
                    {
                        new ShoppingCartEntity
                        {
                            SalePageList = new List<SalePageEntity>()
                            {
                                new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 3, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 4, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 5, Price = 100, Qty = 1}
                            }
                        },
                        375M
                    },
                    new object[]
                    {
                        new ShoppingCartEntity
                        {
                            SalePageList = new List<SalePageEntity>()
                            {
                                new SalePageEntity(){Id = 1, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 2, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 3, Price = 100, Qty = 1},
                                new SalePageEntity(){Id = 3, Price = 100, Qty = 1},
                            }
                        },
                        370M
                    }
                };
            }
        }
    }
}
