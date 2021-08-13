using System;
using System.Collections.Generic;
using System.Linq;
using TrainingTask.Models;

namespace TrainingTask
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> orders = new List<Order>();
            
            Order orderOne = new Order
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Бумажное полотенце",
                        Price = 50
                    },
                    new Product()
                    {
                        Name = "Свеча декоративная",
                        Price = 77
                    }
                },
                Date = DateTime.Today,
                DeliveryCost = 40,
                PurchaseKind = PurchaseKind.Third,
                Sale = 20
            };
            orders.Add(orderOne);
            
            Order orderTwo = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Кружка",
                        Price = 19
                    }
                },
                Date = new DateTime(2021, 2, 17),
                PurchaseKind = PurchaseKind.Second,
                Sale = 5,
                DeliveryCost = 10
            };
            orders.Add(orderTwo);
            
            Order orderThree = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Солнечные очки",
                        Price = 33
                    },
                    new Product()
                    {
                        Name = "Маска для погружения",
                        Price = 60
                    },
                    new Product()
                    {
                        Name = "Тапочки для коралл",
                        Price = 20
                    }
                },
                Date = new DateTime(2020, 4, 23),
                PurchaseKind = PurchaseKind.First,
                Sale = 10,
                DeliveryCost = 30
            };
            orders.Add(orderThree);

            Order orderFour = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Гантели",
                        Price = 22
                    },
                    new Product()
                    {
                        Name = "Спортивная форма",
                        Price = 30
                    }
                },
                Date = new DateTime(2019, 12, 4),
                PurchaseKind = PurchaseKind.Second,
                DeliveryCost = 10
            };
            orders.Add(orderFour);
            
            Order orderFive = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Кленовый сироп",
                        Price = 8
                    }
                },
                DeliveryCost = 10,
                Sale = 3,
                PurchaseKind = PurchaseKind.Second,
                Date = new DateTime(2020, 5, 5)
            };
            orders.Add(orderFive);

            Order orderSix = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Кроссовки",
                        Price = 19
                    },
                    new Product()
                    {
                        Name = "Кепка",
                        Price = 26
                    },
                    new Product()
                    {
                        Name = "Футболка",
                        Price = 35
                    }
                },
                DeliveryCost = 50,
                Date = new DateTime(2019, 4, 4),
                Sale = 10,
                PurchaseKind = PurchaseKind.Second
            };
            orders.Add(orderSix);

            Order orderSeven = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Серьги",
                        Price = 40
                    }
                },
                DeliveryCost = 10,
                PurchaseKind = PurchaseKind.First,
                Sale = 5,
                Date = new DateTime(2018, 3, 2)
            };
            orders.Add(orderSeven);

            Order orderEight = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Круассаны",
                        Price = 20
                    },
                    new Product()
                    {
                        Name = "Багет",
                        Price = 12
                    },
                    new Product()
                    {
                        Name = "Платок",
                        Price = 10
                    }
                },
                Date = new DateTime(2015, 4, 6),
                DeliveryCost = 30,
                PurchaseKind = PurchaseKind.Third,
                Sale = 15
            };
            orders.Add(orderEight);

            Order orderNine = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Туфли",
                        Price = 55.5
                    },
                    new Product()
                    {
                        Name = "Платье",
                        Price = 70
                    }
                },
                DeliveryCost = 60,
                Sale = 10,
                PurchaseKind = PurchaseKind.Second,
                Date = new DateTime(2014, 6, 5)
            };
            orders.Add(orderNine);

            Order orderTen = new Order()
            {
                Products = new List<Product>()
                {
                    new Product()
                    {
                        Name = "Клавиатура",
                        Price = 44
                    },
                    new Product()
                    {
                        Name = "Монитор",
                        Price = 50
                    },
                    new Product()
                    {
                        Name = "Мышь",
                        Price = 20
                    }
                },
                DeliveryCost = 60,
                Sale = 10,
                Date = new DateTime(2014, 9, 24),
                PurchaseKind = PurchaseKind.First
            };
            orders.Add(orderTen);

            foreach (var order in orders.OrderBy(o => o.Date))
            {
                string tableOutput = null;
                foreach (var product in order.Products)
                {
                    tableOutput =$"\t" +
                                 $"Дата заказа:{order.Date}\nСтоимость доставки:{order.DeliveryCost}\n" +
                                 $"Вид покупки:{order.PurchaseKind}\n" +
                                 $"Скидка:{order.Sale}%\n" +
                                 $"{product.Name} - {product.Price}\n" +
                                 $"Сумма :{order.GetOrderCost(order.PurchaseKind)}";
                }

                Console.WriteLine(tableOutput);
            }

        }
    }
}