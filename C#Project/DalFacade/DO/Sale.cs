
namespace DO;
/// <summary>
/// 
/// </summary>
/// <param name="Id">מספר מזהה אוטומטי</param>
/// <param name="IdProduct">מספר מזהה של המוצר</param>
/// <param name="AmountForSale">כמות נדרשת לקבלת המבצע</param>
/// <param name="IncludingPriceInSale">מחיר כולל במבצע</param>
/// <param name="IsTheSaleForEverybody">האם המבצע מיועד לכלל הלקוחות או רק ללקוחות מועדון </param>
/// <param name="DateBeginSale">תאריך תחילת המבצע</param>
/// <param name="DateEndSale">תאריך סיום המבצע</param>
public record Sale
    (int Id,
    int IdProduct,
    int AmountForSale,
    double IncludingPriceInSale,
    bool IsTheSaleForEverybody,
    DateTime DateBeginSale,
    DateTime DateEndSale)
{
    public Sale():this(324,543,56,5.7,true,DateTime.Now, DateTime.Now)
    {
    }
}
