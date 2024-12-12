// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;




ProductTest();

/*CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

foreach (Category category in categoryManager.GetAll())
{
    Console.WriteLine(category.CategoryName);
}*/

void ProductTest()
{
    Console.WriteLine("Hello, World!");
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    if (result.Success)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + "/ " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }
}