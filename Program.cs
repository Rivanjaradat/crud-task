
using crud_task.Data;
using crud_task.models;

namespace taskCrud

{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbContext = new ApplicationDbContext();
             Product p =new Product{
                  Name="Lap2",
                  Price=5000
              };
              Order o = new Order(){
                  adress="ramallah",
                  createdAt=DateTime.Now

              };


              //add data to product table
              dbContext.Products.Add(p);
          //add data to order table 
              dbContext.Orders.Add(o);
              dbContext.SaveChanges();
            //************************************************************************************************
            //get all products
            var products = dbContext.Products.ToList();
            foreach (var product in products)
            {
                System.Console.WriteLine(product);
            }
            Console.WriteLine("*************************************************************");
            //get all orders
            var orders = dbContext.Orders.ToList();
            foreach (var order in orders)
            {
                System.Console.WriteLine(order);
            }
            Console.WriteLine("*************************************************************");
            //**************************************************************************************************

            //update product name
            var productup = dbContext.Products.Find(1);
            productup.Name = "Lap3";
            dbContext.SaveChanges();
            Console.WriteLine("done");
            //update order created at
            var orderup = dbContext.Orders.Find(1);
            orderup.createdAt = DateTime.Now;
            dbContext.SaveChanges();
            Console.WriteLine("done");
            //**************************************************************************************************
            
            // Remove product with id 2
            var productdel = dbContext.Products.FirstOrDefault(prod => prod.Id == 2);
            if (productdel != null)
            {
                dbContext.Products.Remove(productdel);
                dbContext.SaveChanges();
                Console.WriteLine("Product removed");
            }

            // Remove order with id 3
            var orderdel = dbContext.Orders.FirstOrDefault(ord => ord.Id == 3);
            if (orderdel != null)
            {
                dbContext.Orders.Remove(orderdel);
                dbContext.SaveChanges();
                Console.WriteLine("Order removed");
            }
         


        }
    }
}
