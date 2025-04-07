// See https://aka.ms/new-console-template for more information
using DO;
using DalApi;
using DalList;
using System.Reflection;
using Tools;

public class Program
{
    private static IDal s_dal = DalApi.Factory.Get;


    public static void Main(string[] args)
    {
          
        int selectA = printMenu();
        while (selectA!=0 )
        {
            switch(selectA)
            {
                case 1:
                    Console.WriteLine("Customer");           
                    CustomerMenu();
                    break;
                case 2:
                    Console.WriteLine("Product");
                    ProductMenu();      
                    break;
                case 3:
                    Console.WriteLine("Sale");
                    SaleMenu();
                    break;
                case 4:
                    LogManager.cleanLogDir();
                    break;
                case 5:
                    Initialization.Initalize();
                    selectA = printMenu();
                    break;
                default:
                    Console.WriteLine("Wrong selection,please select again");
                    break;

            }
            selectA = printMenu();
        }
    }

    public static int printMenu()
    {
        Console.WriteLine("For customer press 1");
        Console.WriteLine("For product press 2");
        Console.WriteLine("For sale press 3");
        Console.WriteLine("For clean log folder press 4");
        Console.WriteLine("To exit press 0");
        Console.WriteLine("For initialize press 5");

        int selectA;
        if (!int.TryParse(Console.ReadLine(), out selectA))
            selectA = -1;
        return selectA;
    }

    public static int printSubMenu(string item)
    {
        Console.WriteLine($"To add {item} press 1");
        Console.WriteLine($"To read one {item} press 2");
        Console.WriteLine($"To read all {item} press 3");
        Console.WriteLine($"To update {item} press 4");
        Console.WriteLine($"To delete {item} press 5");
        Console.WriteLine("To exit press 0");
        int selectB;
        if (!int.TryParse(Console.ReadLine(), out selectB))
            selectB = -1;
        return selectB;
    }

    public static void ProductMenu()
    {
        int select;
        select = printSubMenu("Product");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    Read(s_dal.Product);
                    break;
                case 3:
                    ReadAll(s_dal.Product.ReadAll());
                    break;
                case 4:
                    Update("Product");
                    break;
                case 5:
                    Delete("Product");
                    break;
                default:
                    Console.WriteLine("Wrong selection,please select again");
                    break;

            }
            select = printSubMenu("Product");
        }
    }

    public static void SaleMenu()
    {
        int select;
        select = printSubMenu("Sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddSale();
                    break;
                case 2:
                    Read(s_dal.Sale);
                    break;
                case 3:
                    ReadAll(s_dal.Sale.ReadAll());
                    break;
                case 4:
                    Update("Sale");
                    break;
                case 5:
                    Delete("Sale");
                    break;
                default:
                    Console.WriteLine("Wrong selection,please select again");
                    break;

            }
            select = printSubMenu("Sale");
        }
    }

    public static void CustomerMenu()
    {
        int select;
        select = printSubMenu("Customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    Read(s_dal.Customer);
                    break;
                case 3:
                    ReadAll(s_dal.Customer.ReadAll());
                    break;
                case 4:
                    Update("Customer");
                    break;
                case 5:
                    Delete("Customer");
                    break;
                default:
                    Console.WriteLine("Wrong selection,please select again");
                    break;

            }
            select = printSubMenu("Customer");
        }
    }

    public static void Update(string s)
    {
        try
        {
            if (s.Equals("Product"))
            {
                Delete("Product");
                AddProduct();
            }

            if (s.Equals("Sale"))
            {
                Delete("Sale");
                AddSale();
            }
            if (s.Equals("Customer"))
            {
                Delete("Customer");
                AddCustomer();
            }
        }
        catch
        {
            Console.WriteLine("Wrong");
        }
        
    }

    public static void Read<T>(ICrud<T> c)
    {
        Console.WriteLine("Enter code");
        int code = int.Parse(Console.ReadLine());
        try
        {          
            Console.WriteLine(c.Read(code));
            
        }catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name,"Read failed");
            Console.WriteLine(e.Message);
        }
    }

    public static void ReadAll<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    public static void Delete(string s)
    {
        Console.WriteLine("Enter code");
        int code = int.Parse(Console.ReadLine());
        try
        {
            if (s.Equals("Product"))
                s_dal.Product.Delete(code);
            if (s.Equals("Sale"))
                s_dal.Sale.Delete(code);
            if (s.Equals("Customer"))
                s_dal.Customer.Delete(code);
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Delete {s} failed");
            Console.WriteLine("Code not found");
            Delete(s);
        }
        
    }

    public static void AddProduct()
    {
        string name;
        Categories category;
        double Price;
        int StockAmount;
        int cat;
        Console.WriteLine("Enter the name of the product");
        name = Console.ReadLine();
        Console.WriteLine("Enter the category : between 0 to 4 acording to this שולחן_ואירוח,מטבח,חדר_שינה,חדר_רחצה,דקורציה_ופנאי");
        if (!int.TryParse(Console.ReadLine(), out cat))
            category = 0;
        else
            category = (Categories)cat;
        Console.WriteLine("Enter price");
        if(!double.TryParse(Console.ReadLine(),out Price)) Price = 10;
        Console.WriteLine("Enter count in stock");
        if (!int.TryParse(Console.ReadLine(), out StockAmount)) StockAmount = 0;
        Product p = new Product(0,name,category,Price,StockAmount);
        s_dal.Product.Create(p);
        Console.WriteLine("Product create successfully");
    }

    public static void AddSale()
    {
        int IdProduct;
        int AmountForSale;
        double IncludingPriceInSale;
        bool IsTheSaleForEverybody;
        DateTime DateBeginSale;
        DateTime DateEndSale;

        Console.WriteLine("Enter id of the product");
        if(!int.TryParse(Console.ReadLine() , out IdProduct)) IdProduct =0;
        Console.WriteLine("Enter amount for the sale");
        if(!int.TryParse(Console.ReadLine() , out AmountForSale)) AmountForSale =0;
        Console.WriteLine("Enter price include in sale");
        if(!double.TryParse(Console.ReadLine() , out IncludingPriceInSale)) IncludingPriceInSale =0;
        Console.WriteLine("Enter if the sale is for everyone press true or fals");
        IsTheSaleForEverybody = Console.ReadLine() == "true";
        Console.WriteLine("Enter date begin sale");
        if(!DateTime.TryParse(Console.ReadLine() ,out DateBeginSale))
            DateBeginSale = DateTime.Now;
        Console.WriteLine("Enter date end sale");
        if (!DateTime.TryParse(Console.ReadLine(), out DateEndSale))
            DateEndSale = DateTime.Now;
        Sale s = new Sale(0,IdProduct,AmountForSale,IncludingPriceInSale,IsTheSaleForEverybody,DateBeginSale,DateEndSale);
        s_dal.Sale.Create(s);
    }

    public static void AddCustomer()
    {
        int IdentityCard;
        string NameCustomer;
        string Address;
        string Phone;
        try
        {     
        Console.WriteLine("Enter identity card");
        if(!int.TryParse(Console.ReadLine(),out IdentityCard)) IdentityCard = 0;
        Console.WriteLine("Enter name");
        NameCustomer = Console.ReadLine();
        Console.WriteLine("Enter address");
        Address = Console.ReadLine();
        Console.WriteLine("Enter number phone");
        Phone = Console.ReadLine();
        Customer c = new Customer(IdentityCard, NameCustomer, Address, Phone);
        s_dal.Customer.Create(c);
        Console.WriteLine("Customer create successfully");
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Add customer failed");
            Console.WriteLine("wrong");
        }
    }

}