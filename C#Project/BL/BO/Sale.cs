using System;
namespace BO;
/// <param name="Id">מספר מזהה אוטומטי</param>
/// <param name="IdProduct">מספר מזהה של המוצר</param>
/// <param name="AmountForSale">כמות נדרשת לקבלת המבצע</param>
/// <param name="IncludingPriceInSale">מחיר כולל במבצע</param>
/// <param name="IsTheSaleForEverybody">האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון </param>
/// <param name="DateBeginSale">תאריך תחילת המבצע</param>
/// <param name="DateEndSale">תאריך סיום המבצע</param>
public class Sale
    {
 
    public int Id { get; init; }
    public int IdProduct { get; init; }
    public int AmountForSale { get; init; }
    public double IncludingPriceInSale { get; init; }
    public bool IsTheSaleForEverybody { get; init; }
    public DateTime DateBeginSale { get; init; }
    public DateTime DateEndSale { get; init; }

    public Sale(int id, int idProduct, int amountForSale, double includingPriceInSale, bool isTheSaleForEverybody, DateTime dateBeginSale, DateTime dateEndSale)
    {
        Id = id;
        IdProduct = idProduct;
        AmountForSale = amountForSale;
        IncludingPriceInSale = includingPriceInSale;
        IsTheSaleForEverybody = isTheSaleForEverybody;
        DateBeginSale = dateBeginSale;
        DateEndSale = dateEndSale;
    }
}

