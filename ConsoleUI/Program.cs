using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

Console.WriteLine("-BASE-\n");

ProductTest();

//CategoryTest();

Console.WriteLine("\n-PASSED-");


static void ProductTest()
{
    ProductManager productManager = new ProductManager(new EfProductDal());
    var result = productManager.GetProductDetails();
    if (result.Success == true)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " : " + product.CategoryName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
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


