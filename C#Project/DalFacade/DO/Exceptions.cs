
namespace DO;
/// <summary>
/// חריגה במקרה שכבר קיים כזה מזהה
/// </summary>
[Serializable]
public class DalExistsThisId: Exception
{
    public DalExistsThisId(string s)
    {
        throw new Exception(s);
    }
}
/// <summary>
/// לא קיים מזהה או קוד
/// </summary>
[Serializable]
public class DalNotFound : Exception
{
    public DalNotFound(string s)
    {
        throw new Exception(s);
    }
}
