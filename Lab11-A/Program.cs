using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            // using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                /*
                var products = AWEntities.Product;
                IQueryable<string> productNames = from p in products
                                                  select p.Name;
                Console.WriteLine("Productos:");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                var products = AWEntities.Product;
                IQueryable<string> productNames2 = products.Select(p => p.Name);
                Console.WriteLine("Productos:");
                foreach (var productName in productNames2)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                var products = AWEntities.Product;
                IQueryable<Product> productsQuery = from p in products
                                                    select p;
                IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");
                Console.WriteLine("Productos de tamaño'L':");
                foreach (var product in largeProducts)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadKey();
                */

            }
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
            //int orderQTYMin = 2;
            //int orderQTYMax = 6;
            //String color = "Red";
            //using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                //---------------------------------------------------------------------------------------------------------
                /*
                var products = context.Product;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };
                foreach (var product in query)
                {
                    Console.WriteLine("Color:{0} \t Cantidad:{1}",
                        product.Color, product.ProductCount);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                var products = context.Product;
                var query = from product in products
                            group product by product.Style into g
                            select new
                            {
                                Style = g.Key,
                                AverageListPrice = g.Average(product => product.ListPrice)
                            };
                foreach (var product in query)
                {
                    Console.WriteLine("Estilo:{0} Precio promedio:{1}",
                        product.Style, product.AverageListPrice);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                IQueryable<ContactType> sortedNames = from n in context.ContactType
                                                      orderby n.LastName
                                                      select n;
                Console.WriteLine("Lista ordenada por Apellido:");
                foreach (ContactType n in sortedNames)
                {
                    Console.WriteLine(n.LastName);
                }
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                IQueryable<Decimal> sortedPrices = from p in context.Product
                                                   orderby p.ListPrice descending
                                                   select p.ListPrice;
                Console.WriteLine("Lista de precios desde el mas alto la mas bajo");
                foreach (Decimal price in sortedPrices)
                {
                    Console.WriteLine(price);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                int?[] productModelIds = { 19, 26, 118 };
                var products = from p in context.Product
                               where productModelIds.Contains(p.ProductModelID)
                               select p;
                foreach (var product in products)
                {
                    Console.WriteLine("{0}:{1}",
                        product.ProductModelID, product.ProductID);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                var query = from product in context.Product
                            where product.Color == color
                            select new
                            {
                                Name = product.Name,
                                ProductNumber = product.ProductNumber,
                                ListPrice = product.ListPrice
                            };
                foreach (var product in query)
                {
                    Console.WriteLine("Name:{0}", product.Name);
                    Console.WriteLine("Product number:{0}", product.ProductNumber);
                    Console.WriteLine("List Price: ${0}", product.ListPrice);
                    Console.WriteLine("");
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                var query = from order in context.SalesOrderDetail
                            where order.OrderQty > orderQTYMin
                            && order.OrderQty < orderQTYMax
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                orderQty = order.OrderQty
                            };
                foreach (var order in query)
                {
                    Console.WriteLine("Order ID: {0} Order quantity:{1}",
                        order.SalesOrderID, order.orderQty);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                IQueryable<Product> productsQuery = from product in context.Product
                                                    select product;
                Console.WriteLine("Productos:");
                foreach (var prod in productsQuery)
                {
                    Console.WriteLine(prod.Name);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
                /*
                var query = from product in context.Product
                            select new
                            {
                                ProductId = product.ProductID,
                                ProductName = product.Name,
                            };
                Console.WriteLine("Informacion de procutos:");
                foreach (var productInfo in query)
                {
                    Console.WriteLine("Product Id: {0} Product name: {1}",
                        productInfo.ProductId, productInfo.ProductName);
                }
                Console.ReadKey();
                */
                //---------------------------------------------------------------------------------------------------------
            }
        }
    }
}

