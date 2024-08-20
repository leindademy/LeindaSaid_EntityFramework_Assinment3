using LeindaSaid_EntityFramework_Assinment3.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace LeindaSaid_EntityFramework_Assinment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new NorthwindContext())
            {
                #region Q 1
                //var category = from Category in db.Categories
                //               select Category;

                //foreach (var C in category)
                //{
                //    Console.WriteLine(C.CategoryName);
                //}
                #endregion

                #region Q 2
                //var salesEmployeesFirstNames = db.Employees
                //                         .Where(e => e.Title == "Sales Representative")
                //                         .Select(e => e.FirstName);

                //foreach (var firstName in salesEmployeesFirstNames)
                //{
                //    Console.WriteLine(firstName);
                //}
                #endregion

                #region Q 3
                //var customerOrders = db.Orders
                //              .Where(O => O.CustomerId == "ALFKI").ToList();

                //foreach (var order in customerOrders)
                //{
                //    Console.WriteLine($" EmployeeId: {order.EmployeeId} Order ID: ,{order.OrderId}, Order Date: {order.OrderDate}");
                //}

                #endregion

                #region Q 4
                //var Shippers = db.Shippers.Select(S =>  new { S.ShipperId , S.CompanyName } ).ToList();

                //foreach (var ShipperId in Shippers)
                //{
                //    Console.WriteLine($"{ShipperId}");
                //}
                #endregion

                #region Q 5
                //var SalesByCategory = db.SalesByCategories.Select(S => new { S.CategoryId, S.ProductSales }).OrderByDescending(S => S.ProductSales).ToList();

                //foreach (var SalesByCategorys in SalesByCategory)
                //{
                //    Console.WriteLine($"{SalesByCategorys.CategoryId} -- {SalesByCategorys.ProductSales}");
                //}
                #endregion

                #region Q 6
                //var Products = db.Products
                //           .Where(P => P.CategoryId == 1 || P.CategoryId == 3).ToList();

                //foreach (var Product in Products)
                //{
                //    Console.WriteLine($"{Product.ProductName} -- {Product.UnitPrice}");
                //}
                #endregion

                #region Q 7
                //var SelectAllCategoriesResult = db.Products.OrderByDescending(p => p.QuantityPerUnit)
                //                                        .Take(5) // Take the top 5 product
                //                                        .Select(p => new { CategoryID = p.CategoryId, ProductName = p.ProductName });

                //foreach (var item in SelectAllCategoriesResult)
                //{
                //    Console.WriteLine($"Product: {item.CategoryID}, Price: {item.ProductName}");
                //}
                #endregion

                #region Q 8
                //var CustOrdersDetailResult = db.Customers
                //    .Where(c => c.Orders.SelectMany(o => o.OrderDetails).Sum(o => o.UnitPrice * o.Quantity) > 10000).ToList();

                //foreach (var OrderDetail in CustOrdersDetailResult)
                //{
                //    Console.WriteLine($"Customer Id: {OrderDetail.CustomerId}, Customer Name: {OrderDetail.ContactName}");
                //}



                #endregion



                // Stored Procedures
                // Delete product
                //1- 
                //var CustOrdersOrdersResult = new NorthwindContextProcedures(db);
                //int result = CustOrdersOrdersResult.DeleteProductByIDAsync(1).Result;


                //2-
                //var DiscontinuedProductsResult = new NorthwindContextProcedures(db);
                //List<DiscontinuedProductsResult> result = DiscontinuedProductsResult.DiscontinuedProductsAsync().Result; 

                //  foreach (var item in result)
                //  {
                //      Console.WriteLine(item.ProductName + (item.ProductID));
                //  }

                //  3-
                //var EmployeeSalesbyCountryResult = new NorthwindContextProcedures(db);
                //List<EmployeeSalesbyCountryResult> results = EmployeeSalesbyCountryResult.EmployeeSalesbyCountryAsync(DateTime.Now, DateTime.Now.AddDays(1)).Result;

                //foreach (var item in results)
                //{
                //    Console.WriteLine($"{item.Country} : {item.FirstName} : {item.LastName}");
                //}

                // 4- 
                var CustOrderHistResult = new NorthwindContextProcedures(db);
                List<CustOrderHistResult> result = CustOrderHistResult.CustOrderHistAsync("CHOPS").Result;

                foreach (var item in result)
                {
                    Console.WriteLine($"{item.ProductName} :: {item.Total}");
                }


            }
        }

    }
}
