using System.Xml.Linq;

namespace Dal;

internal class Config
{
    private const string FILE_PATH = @"..\xml\data-config.xml";
    private const string IDPRODUCT = "idProduct";
    private const string IDSALE = "idSale";

    XElement element;

    public Config()
    {
        element = XElement.Load(FILE_PATH);
    }

    private int ProductIndex => int.Parse(element.Element(IDPRODUCT)!.Value);
    private int SaleIndex => int.Parse(element.Element(IDSALE)!.Value);

    public int GetProductIndex() 
    {
        element.SetElementValue(IDPRODUCT, ProductIndex+1);
        element.Save(FILE_PATH);
        return ProductIndex; 
    }

    public int GetSaleIndex()
    {
        element.SetElementValue(IDSALE, SaleIndex + 1);
        element.Save(FILE_PATH);
        return SaleIndex;
    }

}
