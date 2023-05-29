using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

Console.WriteLine("-BASE-\n");

ProductTest();
Console.WriteLine("--\n\n--");
//CategoryTest();

Console.WriteLine("\n-PASSED-");


static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    foreach (var product in productManager.GetProductDetails())
    {
        Console.WriteLine(product.ProductName + " : " + product.CategoryName);
    }
}
static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName + " : " + category.CategoryId);
    }
}


