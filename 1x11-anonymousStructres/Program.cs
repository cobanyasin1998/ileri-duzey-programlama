#region AnonymousObjects
{
    var anonymousObject = new
    {
        Name = "Ali",
        Surname = "Veli",
        B = 3.14m
    };
}
#endregion
#region Anonymous Methods
{
    Func<int, int, int> func = delegate (int i, int j) { return i + j; };
}
#endregion

#region Anonymous Collections
{
    var anonymousCollection = new[]
    {
        new { Name = "Ali", Surname = "Veli", B = 3.14m },
        new { Name = "Ali", Surname = "Veli", B = 3.14m },
        new { Name = "Ali", Surname = "Veli", B = 3.14m }
    };
}
#endregion