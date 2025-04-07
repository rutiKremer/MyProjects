
namespace BO;
/// <summary>
///  חריגה במקרה שכבר קיים כזה מזהה
/// </summary>
[Serializable]
public class BLExistsThisId : Exception
{
    public BLExistsThisId(string? messege) : base(messege) { }

    public BLExistsThisId(string? messege, Exception innerException)
    : base(messege, innerException) { }
}

/// <summary>
/// לא קיים מזהה או קוד
/// </summary>
[Serializable]
public class BLNotFound : Exception
{
    public BLNotFound(string messege) : base(messege) { }

    public BLNotFound(string messege, Exception innerException) : base(messege, innerException) { }
}

/// <summary>
/// קלט לא תקין
/// </summary>
[Serializable]
public class BLNoValidInput : Exception
{
    public BLNoValidInput(string messege) : base(messege) { }

    public BLNoValidInput(string messege, Exception innerException) : base(messege, innerException) { }
}
/// <summary>
/// אין מספיק במלאי
/// </summary>
[Serializable]
public class BLNotEnoughInStock : Exception
{
    public BLNotEnoughInStock(string messege) : base(messege) { }

    public BLNotEnoughInStock(string messege, Exception innerException) : base(messege, innerException) { }
}