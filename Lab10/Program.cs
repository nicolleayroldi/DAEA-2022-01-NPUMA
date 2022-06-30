using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            //origen de datos
            NorthwndDataContext context = new NorthwndDataContext();

            //Ejecucion de consulta
            //var query = from p in context.Products
            //            select p;


            //Ejercicio 2
            //var query = from p in context.Products
            //            where p.Categories.CategoryName == "Beverages"
            //            select p;

            //foreach (var prod in query)
            //{
            //    Console.WriteLine("Id={0} \t Name={1}", prod.ProductID, prod.ProductName);

            //}

            /*
            //Ejercio 3 
            var query = from p in context.Products
                        where p.UnitPrice < 20
                        select p;
            foreach (var prod in query)
            {
                Console.WriteLine("Id={0} \t Price={1} \t Name={2}", prod.ProductID, prod.UnitPrice, prod.ProductName);
            }
            */

            /*
            //INSERTAR REGISTROS
            //creacion de consulta
            Products pe = new Products();
            pe.ProductName = "Peruvian coffee";
            pe.SupplierID = 20;
            pe.CategoryID = 1;
            pe.QuantityPerUnit = "10 pkgs";
            pe.UnitPrice = 25;
            //Ejecucion de la consulta
            context.Products.InsertOnSubmit(pe);
            context.SubmitChanges();
            Console.WriteLine("Nuevo registro en bd : " + pe.ProductID);
            */

            /*
            //MODIFICAR REGISTRO
            var product = (from p in context.Products
                           where p.ProductName == "Tofu"
                           select p).FirstOrDefault();
            product.UnitPrice = 100;
            product.UnitsInStock = 15;
            product.Discontinued = true;
            //EJecucion de la consulta
            context.SubmitChanges();
            Console.WriteLine("registro Actulizado en bd : " + product.ProductID);
             */

            /*
            //ELIMINAR UN PRODUCTO
            var productDel = (from p in context.Products
                              where p.ProductID == 78
                              select p).FirstOrDefault();
            context.Products.DeleteOnSubmit(productDel);
            context.SubmitChanges();
            Console.WriteLine("registro Eliminado en bd : " + productDel.ProductID);
            Console.ReadKey();
            */


            ////////////////////EJERCICIOS "Queso" ////////////////////////////
            /*
            var product = (from p in context.Products
                           where p.ProductName.Contains("Queso")
                           select p); 
            foreach (var prod in product)
            {
                Console.WriteLine("Id={0} \t Name={1} ", prod.ProductID, prod.ProductName);
            }
            */

            ////////////////////EJERCICIOS "II" ////////////////////////////

            /*
            var product = (from p in context.Products
                           where p.QuantityPerUnit.Contains("pkg") || p.QuantityPerUnit.Contains("pkgs")
                           select p);
            foreach (var prod in product)
            {
                Console.WriteLine("Id={0} \t Name={1} \t\t\t\t Presentacion={2} ", prod.ProductID, prod.ProductName, prod.QuantityPerUnit);
            }
            */

            /*
            var product = (from p in context.Products
                           where p.ProductName.StartsWith("A")
                           select p);
            foreach (var prod in product)
            {
                Console.WriteLine("\t Name={0} \t Precio={1} ", prod.ProductName, prod.UnitPrice);
            }
            */

            /*
            var product = (from p in context.Products
                           where p.UnitsInStock == 0
                           select p);
            foreach (var prod in product)
            {
                Console.WriteLine("Id={0} \t Name={1}  \t Stok = {2} ", prod.ProductID, prod.ProductName, prod.UnitsInStock);
            }
            */

            /*
            var product = (from p in context.Products
                           where p.Discontinued == true
                           select p);
            foreach (var prod in product)
            {
                Console.WriteLine("Id={0} \t Name={1}  \t\t\t\t\t Discontinued = {2} ", prod.ProductID, prod.ProductName, prod.Discontinued);
            }
            */

            /*
            var suppliers = (from s in context.Suppliers
                             join p in context.Products on s.SupplierID equals p.SupplierID
                             join c in context.Categories on p.CategoryID equals c.CategoryID
                             where c.CategoryName == "Dairy Products"
                             select new { 
                                
                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 CompanyName = s.CompanyName,
                                 CategoryName = c.CategoryName
                             });
            foreach (var item in suppliers)
            {
                Console.WriteLine("ProductId={0} \t ProductName={1}  \t CompanyName = {2} \t CategoryName = {3}", item.ProductId, item.ProductName, item.CompanyName, item.CategoryName);
                Console.WriteLine();
            }
            */

            /*
            var suppliers = (from s in context.Suppliers
                             join p in context.Products on s.SupplierID equals p.SupplierID
                             where s.Country == "USA"
                             select new
                             {
                                 ProductId = p.ProductID,
                                 ProductName = p.ProductName,
                                 CompanyName = s.CompanyName,
                                 Country = s.Country,
                             });
            foreach (var item in suppliers)
            {
                Console.WriteLine("ProductId={0} \t ProductName={1}  \t CompanyName = {2} \t Country = {3}", item.ProductId, item.ProductName, item.CompanyName, item.Country);
                Console.WriteLine();
            }
            */
            Console.ReadKey();
        }
    }
}
