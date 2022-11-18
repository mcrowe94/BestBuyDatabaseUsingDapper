using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace BestBuyDatabaseUsingDapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE 1! 

            //step 1- done
            //step 2- done
            //step 3- done
            //step 4- done
            //step 5- done
            //step 6 - done
            //step 7 - done
            //step 8 - done
            //step 9 - done
            //step 10 - done
            //step 11 - done
            //step 12 - done

            //EXERCISE 2!
            //step 1 - done
            //step 2 - done
            //step 3 - done
            //step 4 - done 

            //EXERCISE 3!
            //no steps - finished
            

            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            #region Department Section
            string connString = config.GetConnectionString("DefaultConnection");

            IDbConnection conn = new MySqlConnection(connString);

            var departmentRepo = new DapperDepartmentRepository(conn);

            departmentRepo.InsertDepartment("Moni's New Department!");

            var departments = departmentRepo.GetAllDepartments();

            foreach (var department in departments)
            {
                Console.WriteLine(department.DepartmentID);
                Console.WriteLine(department.Name);
                Console.WriteLine();
                Console.WriteLine();
            }
            #endregion

            var productRepository = new DapperProductRepository(conn);

            var productToUpdate = productRepository.GetProduct(943);

            productToUpdate.Name = "UPDATED!";
            productToUpdate.Price = 10.99m;
            productToUpdate.CategoryID = 10;
            productToUpdate.StockLevel = 500;
            productToUpdate.OnSale = false;

            productRepository.UpdateProduct(productToUpdate);


            var products = productRepository.GetAllProducts();

            foreach(var product in products)
            {
                Console.WriteLine(product.ProductID);
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.CategoryID);
                Console.WriteLine(product.OnSale);
                Console.WriteLine(product.StockLevel);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}