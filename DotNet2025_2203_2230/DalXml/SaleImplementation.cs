
using DO;
using DalApi;
using System.Xml.Linq;
using System.Reflection;
using Tools;

namespace Dal;

internal class SaleImplementation : ISale
{
    private const string SALE = "Sale";
    private const string ID = "Id";
    private const string IDPRODUCT = "IdProduct";
    private const string AMOUNT_FOR_SALE = "AmountForSale";
    private const string INCLUDING_PRICE_IN_SALE = "IncludingPriceInSale";
    private const string IS_THE_SALE_FOR_EVERY_BODY = "IsTheSaleForEverybody";
    private const string DATE_BEGIN_SALE = "DateBeginSale";
    private const string DATE_END_SALE = "DateEndSale";
    private const string FILE_PATH = @"..\xml\sales.xml";

    public int Create(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - create sale");
        XElement element = XElement.Load(FILE_PATH);
        if (element.HasElements)
        {
            bool temp = element.Elements().Any(s => s.Element(ID) != null && int.Parse(s.Element(ID)!.Value) == item.Id);
            if (temp)
            {
                LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - create sale");
                throw new DalExistsThisId("כבר קיים כזה מבצע");
            }
        } 
            Config c = new Config();
            XElement Sale = new XElement(SALE,
            new XElement(ID, c.GetSaleIndex()),
            new XElement(IDPRODUCT, item.IdProduct),
            new XElement(AMOUNT_FOR_SALE, item.AmountForSale),
            new XElement(INCLUDING_PRICE_IN_SALE, item.IncludingPriceInSale),
            new XElement(IS_THE_SALE_FOR_EVERY_BODY, item.IsTheSaleForEverybody),
            new XElement(DATE_BEGIN_SALE, item.DateBeginSale),
            new XElement(DATE_END_SALE, item.DateEndSale));
            element.Add(Sale);
            element.Save(FILE_PATH);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - create sale");
            return item.Id;  
    }

    public Sale? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - read sale");
        XElement? element = XElement.Load(FILE_PATH).Elements(SALE)
         .FirstOrDefault(s => int.Parse(s.Element(ID)!.Value) == id);
        if (element == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - read sale");
            throw new DalNotFound("לא קיים מבצע כזו");

        }
        else
        {
            Sale sale = new Sale
            {
                Id = int.Parse(element.Element(ID)!.Value),
                IdProduct = int.Parse(element.Element(IDPRODUCT)!.Value),
                AmountForSale = int.Parse(element.Element(AMOUNT_FOR_SALE)!.Value),
                IncludingPriceInSale = double.Parse(element.Element(INCLUDING_PRICE_IN_SALE)!.Value),
                IsTheSaleForEverybody = bool.Parse(element.Element(IS_THE_SALE_FOR_EVERY_BODY)!.Value),
                DateBeginSale = DateTime.Parse(element.Element(DATE_BEGIN_SALE)!.Value),
                DateEndSale = DateTime.Parse(element.Element(DATE_END_SALE)!.Value)
            };
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - read sale");
            return sale;
        }
    }

    public Sale? Read(Func<Sale, bool>? filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read sale");
        List<Sale> sales = XElement.Load(FILE_PATH)
        .Elements(SALE)
        .Select(s => new Sale
        {
            Id = int.Parse(s.Element(ID)!.Value),
            IdProduct = int.Parse(s.Element(IDPRODUCT)!.Value),
            AmountForSale = int.Parse(s.Element(AMOUNT_FOR_SALE)!.Value),
            IncludingPriceInSale = int.Parse(s.Element(INCLUDING_PRICE_IN_SALE)!.Value),
            IsTheSaleForEverybody = bool.Parse(s.Element(IS_THE_SALE_FOR_EVERY_BODY)!.Value),
            DateBeginSale = DateTime.Parse(s.Element(DATE_BEGIN_SALE)!.Value),
            DateEndSale = DateTime.Parse(s.Element(DATE_END_SALE)!.Value)
        })
        .ToList();

        Sale? sale = sales.FirstOrDefault(filter);
        if (sale == null)
            throw new DalNotFound("לא קיים מבצע כזו");
        return sale;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "ReadAll sale");
        XElement element = XElement.Load(FILE_PATH);
        List<Sale> sales = element.Elements(SALE)
            .Select(p => new Sale
            {
                Id = int.Parse(p.Element(ID)!.Value),
                IdProduct = int.Parse(p.Element(IDPRODUCT)!.Value),
                AmountForSale = int.Parse(p.Element(AMOUNT_FOR_SALE)!.Value),
                IncludingPriceInSale = double.Parse(p.Element(INCLUDING_PRICE_IN_SALE)!.Value),
                IsTheSaleForEverybody = bool.Parse(p.Element(IS_THE_SALE_FOR_EVERY_BODY)!.Value),
                DateBeginSale = DateTime.Parse(p.Element(DATE_BEGIN_SALE)!.Value),
                DateEndSale = DateTime.Parse(p.Element(DATE_END_SALE)!.Value)
            })
            .ToList();
        if (filter != null)
            sales = sales.Where(filter).ToList();
        return sales;
    }

    public void Update(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - update sale");
        XElement sales = XElement.Load(FILE_PATH);
        XElement element = sales.Elements(SALE)
            .FirstOrDefault(p => int.Parse(p.Element(ID)!.Value) == item.Id);

        if (element == null)
            throw new DalNotFound("לא קיים כזה מבצע");

        element.Element(IDPRODUCT)!.SetValue(item.IdProduct);
        element.Element(AMOUNT_FOR_SALE)!.SetValue(item.AmountForSale);
        element.Element(INCLUDING_PRICE_IN_SALE)!.SetValue(item.IncludingPriceInSale);
        element.Element(IS_THE_SALE_FOR_EVERY_BODY)!.SetValue(item.IsTheSaleForEverybody);
        element.Element(DATE_BEGIN_SALE)!.SetValue(item.DateBeginSale);
        element.Element(DATE_END_SALE)!.SetValue(item.DateEndSale);
        sales.Save(FILE_PATH);
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - update sale");
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Start - delete sale");
        try
        {
            XElement sales = XElement.Load(FILE_PATH);
            XElement saleToDelete = sales.Elements(SALE)
            .FirstOrDefault(p => int.Parse(p.Element(ID)!.Value) == id);

            if (saleToDelete == null)
                throw new DalNotFound("לא קיים מבצע עם מזהה זה");
            saleToDelete.Remove();
            sales.Save(FILE_PATH);
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "End - delete sale");
        }
        catch
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Failed - delete sale");
            throw new DalNotFound("לא קיים כזה מבצע");
        }
    }
}
