
using DalApi;
using DO;
using BO;
using System.Reflection;
using System.Xml.Linq;
using Tools;

namespace Dal;

internal class ProductImplementation : IProduct
{
    private const string PRODUCT = "Product";
    private const string IDPRODUCT = "IdProduct";
    private const string NAMEPRODUCT = "NameProduct";
    private const string CATEGORY = "Category";
    private const string PRICE = "Price";
    private const string STOCKAMOUNT = "StockAmount";
    private const string FILE_PATH = @"..\xml\products.xml";

    public int Create(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Strat - create product");
        XElement element = XElement.Load(FILE_PATH);
        if (element.HasElements)
        {
            bool temp = element.Elements().Any(c => c.Element(IDPRODUCT) != null && int.Parse(c.Element(IDPRODUCT)!.Value) == item.IdProduct);
            if (temp)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, " create product failed");
                throw new DalExistsThisId("כבר קיים כזה מוצר");
            }
        }
        Config c = new Config();
        XElement Product = new XElement(PRODUCT,
        new XElement(IDPRODUCT, c.GetProductIndex()),
        new XElement(NAMEPRODUCT, item.NameProduct),
        new XElement(CATEGORY, item.Category),
        new XElement(PRICE, item.Price),
        new XElement(STOCKAMOUNT, item.StockAmount));
        element.Add(Product);
        element.Save(FILE_PATH);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - create product");
        return item.IdProduct;
    }

    public Product Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - read product");
        XElement element = XElement.Load(FILE_PATH)
        .Elements(PRODUCT).FirstOrDefault(p => int.Parse(p.Element(IDPRODUCT)!.Value) == id);
        if (element == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - create product");
            throw new DalNotFound("לא קיים כזה מוצר");
        }
        else
        {
            Product p = new Product(int.Parse(element.Element(IDPRODUCT)!.Value),
                    element.Element(NAMEPRODUCT)!.Value,
                    Enum.Parse<Categories>(element.Element(CATEGORY)!.Value),
                    double.Parse(element.Element(PRICE)!.Value),
                    int.Parse(element.Element(STOCKAMOUNT)!.Value));
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - read product");
            return p;
        }
    }

    public Product? Read(Func<Product, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read product");
        List<Product> products = XElement.Load(FILE_PATH)
        .Elements(PRODUCT).Select(p => new Product(int.Parse(p.Element(IDPRODUCT)!.Value),
            p.Element(NAMEPRODUCT)!.Value,
            Enum.Parse<Categories>(p.Element(CATEGORY)!.Value),
            int.Parse(p.Element(PRICE)!.Value),
            int.Parse(p.Element(STOCKAMOUNT)!.Value))).ToList();
        Product product = products.FirstOrDefault(filter);
        if (product == null)
            throw new DalNotFound("לא קיים כזה מוצר");
        return product;
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll product");
        XElement element = XElement.Load(FILE_PATH);
        List<Product> products = element.Elements(PRODUCT)
                .Select(p => new Product
                (int.Parse(p.Element(IDPRODUCT)!.Value),
            p.Element(NAMEPRODUCT)!.Value,
            Enum.Parse<Categories>(p.Element(CATEGORY)!.Value),
            double.Parse(p.Element(PRICE)!.Value),
            int.Parse(p.Element(STOCKAMOUNT)!.Value))).ToList();
        if (filter != null)
            products = products.Where(filter).ToList();
        return products;
    }

    public void Update(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - update product");
        XElement products = XElement.Load(FILE_PATH);
        XElement element = products.Elements(PRODUCT).
            FirstOrDefault(p => int.Parse(p.Element(IDPRODUCT)!.Value) == item.IdProduct);

        if (element == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - update product");
            throw new DalNotFound("לא קיים כזה מוצר");
        }

        element.Element(NAMEPRODUCT)!.SetValue(item.NameProduct);
        element.Element(CATEGORY)!.SetValue(item.Category);
        element.Element(PRICE)!.SetValue(item.Price);
        element.Element(STOCKAMOUNT)!.SetValue(item.StockAmount);
        products.Save(FILE_PATH);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - update product");

    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - delete product");
        try
        {
            XElement products = XElement.Load(FILE_PATH);
            XElement productToDelete = products.Elements(PRODUCT)
            .FirstOrDefault(p => int.Parse(p.Element(IDPRODUCT)!.Value) == id);

            if (productToDelete == null)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - delete product");
                throw new DalNotFound("לא קיים לקוח עם תעודת זהות זו");
            }
            productToDelete.Remove();
            products.Save(FILE_PATH);
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - delete product");
            throw new DalNotFound("לא קיים כזה מוצר");
        }
    }
}
